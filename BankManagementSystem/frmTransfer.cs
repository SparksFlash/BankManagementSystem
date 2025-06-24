using System;
using System.Data.SqlClient;
using System.Globalization; // Add this using statement
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmTransfer : Form
    {
        private readonly int _sourceAccountId;
        private decimal _currentBalance;
        public bool TransferSuccessful { get; private set; } = false;

        public frmTransfer(int sourceAccountId)
        {
            InitializeComponent();
            _sourceAccountId = sourceAccountId;
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            FetchCurrentBalance();
        }

        private void FetchCurrentBalance()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT Balance FROM Accounts WHERE AccountID = @AccountID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", _sourceAccountId);
                        _currentBalance = Convert.ToDecimal(cmd.ExecuteScalar());
                        var culture = new CultureInfo("bn-BD");
                        lblCurrentBalance.Text = $"Your Balance: {_currentBalance.ToString("C", culture)}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load current balance.\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string destinationAccountNumber = txtDestinationAccount.Text.Trim();
            decimal amountToTransfer = numAmount.Value;

            if (string.IsNullOrWhiteSpace(destinationAccountNumber))
            {
                MessageBox.Show("Please enter a destination account number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (amountToTransfer <= 0)
            {
                MessageBox.Show("Please enter a positive amount to transfer.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (amountToTransfer > _currentBalance)
            {
                MessageBox.Show("Insufficient funds for this transfer.", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                int destinationAccountId = -1;
                try
                {
                    string findAccountQuery = "SELECT AccountID FROM Accounts WHERE AccountNumber = @AccountNumber";
                    using (SqlCommand findCmd = new SqlCommand(findAccountQuery, con))
                    {
                        findCmd.Parameters.AddWithValue("@AccountNumber", destinationAccountNumber);
                        object result = findCmd.ExecuteScalar();
                        if (result != null)
                        {
                            destinationAccountId = Convert.ToInt32(result);
                        }
                    }

                    if (destinationAccountId == -1)
                    {
                        MessageBox.Show("The destination account number does not exist.", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (destinationAccountId == _sourceAccountId)
                    {
                        MessageBox.Show("You cannot transfer funds to your own account.", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while verifying the destination account.\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlTransaction sqlTransaction = con.BeginTransaction();
                try
                {
                    string debitQuery = "UPDATE Accounts SET Balance = Balance - @Amount WHERE AccountID = @AccountID";
                    using (SqlCommand debitCmd = new SqlCommand(debitQuery, con, sqlTransaction))
                    {
                        debitCmd.Parameters.AddWithValue("@Amount", amountToTransfer);
                        debitCmd.Parameters.AddWithValue("@AccountID", _sourceAccountId);
                        debitCmd.ExecuteNonQuery();
                    }

                    string creditQuery = "UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountID = @AccountID";
                    using (SqlCommand creditCmd = new SqlCommand(creditQuery, con, sqlTransaction))
                    {
                        creditCmd.Parameters.AddWithValue("@Amount", amountToTransfer);
                        creditCmd.Parameters.AddWithValue("@AccountID", destinationAccountId);
                        creditCmd.ExecuteNonQuery();
                    }

                    string logQuery = "INSERT INTO Transactions (AccountID, TransactionType, Amount, DestinationAccountID) VALUES (@AccountID, 'Transfer', @Amount, @DestinationAccountID)";
                    using (SqlCommand logCmd = new SqlCommand(logQuery, con, sqlTransaction))
                    {
                        logCmd.Parameters.AddWithValue("@AccountID", _sourceAccountId);
                        logCmd.Parameters.AddWithValue("@Amount", amountToTransfer);
                        logCmd.Parameters.AddWithValue("@DestinationAccountID", destinationAccountId);
                        logCmd.ExecuteNonQuery();
                    }

                    sqlTransaction.Commit();
                    MessageBox.Show("Transfer successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TransferSuccessful = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    MessageBox.Show("An error occurred during the transfer. The transaction has been cancelled.\n\n" + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
