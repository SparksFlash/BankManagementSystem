using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmDeposit : Form
    {
        private readonly int _accountId;
        public bool DepositSuccessful { get; private set; } = false;

        public frmDeposit(int accountId)
        {
            InitializeComponent();
            _accountId = accountId;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal amount = numAmount.Value;

            // 1. Input Validation
            if (amount <= 0)
            {
                MessageBox.Show("Please enter a positive amount to deposit.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Database Transaction
            // Use a 'using' block for the connection to ensure it's always closed.
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                // Start a SQL transaction. This ensures that both the balance update and the transaction log are completed successfully.
                // If one fails, the other is rolled back, preventing data inconsistency.
                SqlTransaction sqlTransaction = con.BeginTransaction();
                try
                {
                    // Command 1: Update the balance in the Accounts table
                    string updateBalanceQuery = "UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountID = @AccountID";
                    using (SqlCommand updateCmd = new SqlCommand(updateBalanceQuery, con, sqlTransaction))
                    {
                        updateCmd.Parameters.AddWithValue("@Amount", amount);
                        updateCmd.Parameters.AddWithValue("@AccountID", _accountId);
                        updateCmd.ExecuteNonQuery();
                    }

                    // Command 2: Log the transaction in the Transactions table
                    string logTransactionQuery = "INSERT INTO Transactions (AccountID, TransactionType, Amount) VALUES (@AccountID, 'Deposit', @Amount)";
                    using (SqlCommand logCmd = new SqlCommand(logTransactionQuery, con, sqlTransaction))
                    {
                        logCmd.Parameters.AddWithValue("@AccountID", _accountId);
                        logCmd.Parameters.AddWithValue("@Amount", amount);
                        logCmd.ExecuteNonQuery();
                    }

                    // If both commands succeed, commit the transaction
                    sqlTransaction.Commit();

                    MessageBox.Show("Deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DepositSuccessful = true; // Set the flag for the dashboard to check
                    this.Close(); // Close the deposit form
                }
                catch (Exception ex)
                {
                    // If any error occurs, roll back the entire transaction
                    sqlTransaction.Rollback();
                    MessageBox.Show("An error occurred during the deposit. The transaction has been cancelled.\n\n" + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
