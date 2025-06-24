using System;
using System.Data.SqlClient;
using System.Globalization; // Used to specify currency culture
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmWithdraw : Form
    {
        private readonly int _accountId;
        private decimal _currentBalance;
        public bool WithdrawalSuccessful { get; private set; } = false;

        public frmWithdraw(int accountId)
        {
            InitializeComponent();
            _accountId = accountId;
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            // Load the current balance when the form opens to display it and use it for validation
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
                        cmd.Parameters.AddWithValue("@AccountID", _accountId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            _currentBalance = Convert.ToDecimal(result);
                            // Format the balance using Bangladeshi Taka culture
                            var culture = new CultureInfo("bn-BD");
                            lblCurrentBalance.Text = $"Current Balance: {_currentBalance.ToString("C", culture)}";
                        }
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
            decimal amountToWithdraw = numAmount.Value;

            // 1. Input Validation
            if (amountToWithdraw <= 0)
            {
                MessageBox.Show("Please enter a positive amount to withdraw.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Business Logic Validation (Sufficient Funds)
            if (amountToWithdraw > _currentBalance)
            {
                MessageBox.Show("Insufficient funds. You cannot withdraw more than your current balance.", "Withdrawal Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Database Transaction
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlTransaction sqlTransaction = con.BeginTransaction();
                try
                {
                    // Command 1: Update the balance in the Accounts table
                    string updateBalanceQuery = "UPDATE Accounts SET Balance = Balance - @Amount WHERE AccountID = @AccountID";
                    using (SqlCommand updateCmd = new SqlCommand(updateBalanceQuery, con, sqlTransaction))
                    {
                        updateCmd.Parameters.AddWithValue("@Amount", amountToWithdraw);
                        updateCmd.Parameters.AddWithValue("@AccountID", _accountId);
                        updateCmd.ExecuteNonQuery();
                    }

                    // Command 2: Log the transaction in the Transactions table
                    string logTransactionQuery = "INSERT INTO Transactions (AccountID, TransactionType, Amount) VALUES (@AccountID, 'Withdrawal', @Amount)";
                    using (SqlCommand logCmd = new SqlCommand(logTransactionQuery, con, sqlTransaction))
                    {
                        logCmd.Parameters.AddWithValue("@AccountID", _accountId);
                        logCmd.Parameters.AddWithValue("@Amount", amountToWithdraw);
                        logCmd.ExecuteNonQuery();
                    }

                    // If both commands succeed, commit the transaction
                    sqlTransaction.Commit();

                    MessageBox.Show("Withdrawal successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.WithdrawalSuccessful = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    // If any error occurs, roll back the entire transaction
                    sqlTransaction.Rollback();
                    MessageBox.Show("An error occurred during the withdrawal. The transaction has been cancelled.\n\n" + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
