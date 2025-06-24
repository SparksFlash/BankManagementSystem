using System;
using System.Data.SqlClient;
using System.Globalization; // Add this using statement
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class CustomerDashboard : Form
    {
        private readonly int _userId;
        private int _accountId;
        private string _accountHolderName;
        private string _accountNumber;

        public CustomerDashboard(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            LoadAccountDetails();
        }

        private void LoadAccountDetails()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT AccountID, AccountHolderName, AccountNumber, Balance FROM Accounts WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _accountId = Convert.ToInt32(reader["AccountID"]);
                                _accountHolderName = reader["AccountHolderName"].ToString();
                                _accountNumber = reader["AccountNumber"].ToString();
                                decimal balance = Convert.ToDecimal(reader["Balance"]);

                                lblWelcome.Text = $"Welcome, {_accountHolderName}!";
                                lblAccountNumber.Text = $"Account #: {_accountNumber}";

                                // Format the balance using Bangladeshi Taka culture
                                var culture = new CultureInfo("bn-BD");
                                lblBalanceValue.Text = balance.ToString("C", culture);
                            }
                            else
                            {
                                MessageBox.Show("Could not find account details for this user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A database error occurred while loading account details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDeposit depositForm = new frmDeposit(_accountId);
            depositForm.ShowDialog();
            if (depositForm.DepositSuccessful) LoadAccountDetails();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmWithdraw withdrawForm = new frmWithdraw(_accountId);
            withdrawForm.ShowDialog();
            if (withdrawForm.WithdrawalSuccessful) LoadAccountDetails();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer transferForm = new frmTransfer(_accountId);
            transferForm.ShowDialog();
            if (transferForm.TransferSuccessful) LoadAccountDetails();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory historyForm = new frmHistory(_accountId);
            historyForm.ShowDialog();
        }

        private void btnGenerateStatement_Click(object sender, EventArgs e)
        {
            frmGenerateStatement statementForm = new frmGenerateStatement(_accountId, _accountHolderName, _accountNumber);
            statementForm.ShowDialog();
        }

        private void btnRequestLoan_Click(object sender, EventArgs e)
        {
            frmRequestLoan loanForm = new frmRequestLoan(_accountId);
            loanForm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword changePasswordForm = new frmChangePassword(_userId);
            changePasswordForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
