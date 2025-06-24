using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    public partial class frmAdminViewTransactions : Form
    {
        public frmAdminViewTransactions()
        {
            InitializeComponent();
            // Hook up the cell formatting event
            this.dgvAllTransactions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAllTransactions_CellFormatting);
        }

        private void frmAdminViewTransactions_Load(object sender, EventArgs e)
        {
            SetupFilterControls();
            LoadAllTransactions();
        }

        private void SetupFilterControls()
        {
            cmbTransactionType.Items.Add("All");
            cmbTransactionType.Items.Add("Deposit");
            cmbTransactionType.Items.Add("Withdrawal");
            cmbTransactionType.Items.Add("Transfer");
            cmbTransactionType.Items.Add("Loan");
            cmbTransactionType.SelectedIndex = 0;

            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
        }

        private void LoadAllTransactions()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    var queryBuilder = new StringBuilder(@"
                        SELECT 
                            t.TransactionID, t.TransactionDate, t.TransactionType,
                            source_a.AccountNumber AS SourceAccount, t.Amount,
                            ISNULL(dest_a.AccountNumber, 'N/A') AS DestinationAccount
                        FROM Transactions t
                        JOIN Accounts source_a ON t.AccountID = source_a.AccountID
                        LEFT JOIN Accounts dest_a ON t.DestinationAccountID = dest_a.AccountID
                        WHERE 1=1");

                    var parameters = new Dictionary<string, object>();

                    if (!string.IsNullOrWhiteSpace(txtSearchAccount.Text))
                    {
                        queryBuilder.Append(" AND (source_a.AccountNumber LIKE @AccountNumber OR dest_a.AccountNumber LIKE @AccountNumber)");
                        parameters["@AccountNumber"] = "%" + txtSearchAccount.Text.Trim() + "%";
                    }

                    if (cmbTransactionType.SelectedItem.ToString() != "All")
                    {
                        queryBuilder.Append(" AND t.TransactionType = @TransactionType");
                        parameters["@TransactionType"] = cmbTransactionType.SelectedItem.ToString();
                    }

                    queryBuilder.Append(" AND t.TransactionDate BETWEEN @StartDate AND @EndDate");
                    parameters["@StartDate"] = dtpStartDate.Value.Date;
                    parameters["@EndDate"] = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);

                    queryBuilder.Append(" ORDER BY t.TransactionDate DESC");

                    using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), con))
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        dgvAllTransactions.DataSource = dt;
                        CustomizeDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load transaction data.\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeDataGridView()
        {
            dgvAllTransactions.Columns["TransactionID"].HeaderText = "ID";
            dgvAllTransactions.Columns["TransactionDate"].HeaderText = "Date & Time";
            dgvAllTransactions.Columns["TransactionType"].HeaderText = "Type";
            dgvAllTransactions.Columns["SourceAccount"].HeaderText = "Source Account";
            dgvAllTransactions.Columns["Amount"].HeaderText = "Amount";
            dgvAllTransactions.Columns["DestinationAccount"].HeaderText = "Destination Account";
        }

        private void dgvAllTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvAllTransactions.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
            {
                decimal amount = Convert.ToDecimal(e.Value);
                var culture = new CultureInfo("bn-BD");
                e.Value = amount.ToString("C", culture);
                e.FormattingApplied = true;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadAllTransactions();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchAccount.Clear();
            cmbTransactionType.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
            LoadAllTransactions();
        }

        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            if (dgvAllTransactions.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "TransactionReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document document = new Document(PageSize.A4.Rotate(), 25f, 25f, 30f, 30f);
                        PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                        document.Open();

                        iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD);
                        Paragraph title = new Paragraph("Bank Transaction Report", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 20f;
                        document.Add(title);

                        PdfPTable pdfTable = new PdfPTable(dgvAllTransactions.ColumnCount);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn column in dgvAllTransactions.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = new BaseColor(240, 240, 240);
                            pdfTable.AddCell(cell);
                        }

                        // **FIXED LOGIC**: Use the FormattedValue to ensure the PDF matches the grid exactly.
                        foreach (DataGridViewRow row in dgvAllTransactions.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                // The FormattedValue property gives the string as it is displayed in the grid,
                                // including the "Tk" symbol applied by the CellFormatting event.
                                string formattedValue = cell.FormattedValue.ToString();
                                pdfTable.AddCell(formattedValue);
                            }
                        }

                        document.Add(pdfTable);
                        document.Close();

                        MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Do you want to open the report now? You can print it from your PDF viewer.", "Open Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Process.Start(saveFileDialog.FileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data available to generate a report.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
