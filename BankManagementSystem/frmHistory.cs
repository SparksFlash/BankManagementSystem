using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization; // Add this using statement
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmHistory : Form
    {
        private readonly int _accountId;

        public frmHistory(int accountId)
        {
            InitializeComponent();
            // Hook up the cell formatting event
            this.dgvTransactions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTransactions_CellFormatting);
            _accountId = accountId;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = @"
                        SELECT 
                            t.TransactionID, t.TransactionDate, t.TransactionType, t.Amount,
                            ISNULL(dest_a.AccountNumber, 'N/A') AS DestinationAccount
                        FROM Transactions t
                        LEFT JOIN Accounts dest_a ON t.DestinationAccountID = dest_a.AccountID
                        WHERE t.AccountID = @AccountID OR t.DestinationAccountID = @AccountID
                        ORDER BY t.TransactionDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", _accountId);
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dgvTransactions.DataSource = dt;
                        CustomizeDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load transaction history.\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeDataGridView()
        {
            dgvTransactions.Columns["TransactionID"].HeaderText = "ID";
            dgvTransactions.Columns["TransactionDate"].HeaderText = "Date";
            dgvTransactions.Columns["TransactionType"].HeaderText = "Type";
            dgvTransactions.Columns["Amount"].HeaderText = "Amount";
            dgvTransactions.Columns["DestinationAccount"].HeaderText = "Destination Acc";
            dgvTransactions.Columns["TransactionID"].FillWeight = 20;
            dgvTransactions.Columns["TransactionDate"].FillWeight = 40;
            // No longer setting default currency format here
        }

        private void dgvTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvTransactions.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
            {
                decimal amount = Convert.ToDecimal(e.Value);
                var culture = new CultureInfo("bn-BD");
                e.Value = amount.ToString("C", culture);
                e.FormattingApplied = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
