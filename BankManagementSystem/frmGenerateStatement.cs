using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace BankManagementSystem
{
    public partial class frmGenerateStatement : Form
    {
        private readonly int _accountId;
        private readonly string _accountHolderName;
        private readonly string _accountNumber;

        public frmGenerateStatement(int accountId, string accountHolderName, string accountNumber)
        {
            InitializeComponent();
            _accountId = accountId;
            _accountHolderName = accountHolderName;
            _accountNumber = accountNumber;

            // Set default dates
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1); // Include the whole end day

            if (startDate > endDate)
            {
                MessageBox.Show("The start date cannot be after the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = GetTransactionData(startDate, endDate);

            if (dt.Rows.Count > 0)
            {
                GeneratePdf(dt, startDate, endDate);
            }
            else
            {
                MessageBox.Show("No transactions found for the selected period.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable GetTransactionData(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = @"
                        SELECT 
                            t.TransactionDate,
                            t.TransactionType,
                            t.Amount,
                            ISNULL(dest_a.AccountNumber, 'N/A') AS DestinationAccount
                        FROM 
                            Transactions t
                        LEFT JOIN 
                            Accounts dest_a ON t.DestinationAccountID = dest_a.AccountID
                        WHERE 
                            (t.AccountID = @AccountID OR t.DestinationAccountID = @AccountID)
                            AND t.TransactionDate BETWEEN @StartDate AND @EndDate
                        ORDER BY 
                            t.TransactionDate ASC"; // Order ascending for statement

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", _accountId);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve transaction data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void GeneratePdf(DataTable transactionData, DateTime startDate, DateTime endDate)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"Statement_{_accountNumber}_{startDate:yyyyMMdd}-{endDate:yyyyMMdd}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document document = new Document(PageSize.A4, 40f, 40f, 60f, 60f);
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    document.Open();

                    // --- PDF Content ---

                    // Title
                    iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD);
                    Paragraph title = new Paragraph("Account Statement", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    // Account Holder Info
                    Paragraph accountInfo = new Paragraph();
                    accountInfo.SpacingBefore = 20f;
                    accountInfo.SpacingAfter = 10f;
                    accountInfo.Add(new Chunk($"Account Holder: {_accountHolderName}\n"));
                    accountInfo.Add(new Chunk($"Account Number: {_accountNumber}\n"));
                    accountInfo.Add(new Chunk($"Statement Period: {startDate:d} to {endDate:d}\n"));
                    document.Add(accountInfo);

                    document.Add(new Paragraph(" ")); // Spacer

                    // Transaction Table
                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 3f, 2f, 2f, 3f });

                    // Headers
                    table.AddCell(new PdfPCell(new Phrase("Date")) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    table.AddCell(new PdfPCell(new Phrase("Type")) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    table.AddCell(new PdfPCell(new Phrase("Amount")) { BackgroundColor = BaseColor.LIGHT_GRAY, HorizontalAlignment = Element.ALIGN_RIGHT });
                    table.AddCell(new PdfPCell(new Phrase("Details")) { BackgroundColor = BaseColor.LIGHT_GRAY });

                    // Data Rows
                    foreach (DataRow row in transactionData.Rows)
                    {
                        table.AddCell(Convert.ToDateTime(row["TransactionDate"]).ToString("g"));
                        string type = row["TransactionType"].ToString();
                        decimal amount = Convert.ToDecimal(row["Amount"]);

                        table.AddCell(type);

                        // Color code amount
                        PdfPCell amountCell = new PdfPCell(new Phrase(amount.ToString("C")));
                        if (type == "Deposit") amountCell.Phrase.Font.Color = BaseColor.GREEN;
                        else if (type == "Withdrawal" || type == "Transfer") amountCell.Phrase.Font.Color = BaseColor.RED;
                        amountCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(amountCell);

                        string details = type == "Transfer" ? $"To: {row["DestinationAccount"]}" : " ";
                        table.AddCell(details);
                    }

                    document.Add(table);
                    // --- End of PDF Content ---

                    document.Close();
                    writer.Close();

                    MessageBox.Show("Statement generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Do you want to open the statement now?", "Open Statement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start(saveFileDialog.FileName);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
