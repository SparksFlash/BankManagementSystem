using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmManageLoans : Form
    {
        private int _selectedLoanAppId = -1;
        private int _selectedAccountId = -1;
        private decimal _selectedLoanAmount = 0;
        private readonly int _adminId;

        public frmManageLoans(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;
        }

        private void frmManageLoans_Load(object sender, EventArgs e)
        {
            LoadLoanApplications();
        }

        private void LoadLoanApplications()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    // Using an explicit column list is safer than SELECT *
                    string query = @"SELECT 
                                        la.*,
                                        a.AccountNumber
                                     FROM LoanApplications la
                                     JOIN Accounts a ON la.AccountID = a.AccountID
                                     WHERE la.Status = 'Pending'
                                     ORDER BY la.ApplicationDate ASC";

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                    dgvLoanApps.DataSource = dt;

                    // Hide columns for a cleaner view in the grid
                    dgvLoanApps.Columns["LoanAppID"].Visible = false;
                    dgvLoanApps.Columns["AccountID"].Visible = false;
                    // Hide other detailed columns from the grid view if desired
                    dgvLoanApps.Columns["FathersName"].Visible = false;
                    dgvLoanApps.Columns["DateOfBirth"].Visible = false;
                    dgvLoanApps.Columns["PermanentAddress"].Visible = false;
                    dgvLoanApps.Columns["PresentAddress"].Visible = false;
                    dgvLoanApps.Columns["ReferenceName"].Visible = false;
                    dgvLoanApps.Columns["ReferenceContact"].Visible = false;
                    dgvLoanApps.Columns["EmploymentDetails"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load loan applications: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLoanApps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoanApps.Rows[e.RowIndex];

                _selectedLoanAppId = Convert.ToInt32(row.Cells["LoanAppID"].Value);
                _selectedAccountId = Convert.ToInt32(row.Cells["AccountID"].Value);
                _selectedLoanAmount = Convert.ToDecimal(row.Cells["LoanAmount"].Value);

                // Populate the details view with the comprehensive information
                lblHolderName.Text = "Applicant: " + row.Cells["FullName"].Value.ToString();
                lblAccountNumber.Text = "Account Number: " + row.Cells["AccountNumber"].Value.ToString();
                lblLoanAmount.Text = "Loan Amount: " + _selectedLoanAmount.ToString("C");
                lblMonthlyIncome.Text = "Monthly Income: " + Convert.ToDecimal(row.Cells["MonthlyIncome"].Value).ToString("C");
                lblRepaymentPeriod.Text = "Repayment Period: " + row.Cells["RepaymentPeriodMonths"].Value.ToString() + " months";
                txtReason.Text = "Loan Type: " + row.Cells["LoanType"].Value.ToString() + "\r\n" +
                                 "Purpose: " + row.Cells["LoanPurpose"].Value.ToString();
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (_selectedLoanAppId == -1)
            {
                MessageBox.Show("Please select a loan application to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to approve this loan? The funds will be transferred immediately.", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        string updateBalanceQuery = "UPDATE Accounts SET Balance = Balance + @LoanAmount WHERE AccountID = @AccountID";
                        using (SqlCommand cmd = new SqlCommand(updateBalanceQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@LoanAmount", _selectedLoanAmount);
                            cmd.Parameters.AddWithValue("@AccountID", _selectedAccountId);
                            cmd.ExecuteNonQuery();
                        }

                        string logTransactionQuery = "INSERT INTO Transactions (AccountID, TransactionType, Amount) VALUES (@AccountID, 'Loan', @LoanAmount)";
                        using (SqlCommand cmd = new SqlCommand(logTransactionQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AccountID", _selectedAccountId);
                            cmd.Parameters.AddWithValue("@LoanAmount", _selectedLoanAmount);
                            cmd.ExecuteNonQuery();
                        }

                        string updateStatusQuery = "UPDATE LoanApplications SET Status = 'Approved', ReviewDate = GETDATE(), ReviewedByAdminID = @AdminID WHERE LoanAppID = @LoanAppID";
                        // **FIXED THE SYNTAX ERROR HERE**
                        using (SqlCommand cmd = new SqlCommand(updateStatusQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AdminID", _adminId);
                            cmd.Parameters.AddWithValue("@LoanAppID", _selectedLoanAppId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Loan approved and funds transferred successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadLoanApplications();
                        ClearDetails();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred during the approval process: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (_selectedLoanAppId == -1)
            {
                MessageBox.Show("Please select a loan application to reject.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to reject this loan application?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = DatabaseHelper.GetConnection())
                    {
                        string updateStatusQuery = "UPDATE LoanApplications SET Status = 'Rejected', ReviewDate = GETDATE(), ReviewedByAdminID = @AdminID WHERE LoanAppID = @LoanAppID";
                        using (SqlCommand cmd = new SqlCommand(updateStatusQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@AdminID", _adminId);
                            cmd.Parameters.AddWithValue("@LoanAppID", _selectedLoanAppId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Loan application rejected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoanApplications();
                    ClearDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearDetails()
        {
            lblHolderName.Text = "Applicant Name";
            lblAccountNumber.Text = "Account Number:";
            lblLoanAmount.Text = "Loan Amount:";
            lblMonthlyIncome.Text = "Monthly Income:";
            lblRepaymentPeriod.Text = "Repayment Period:";
            txtReason.Clear();
            _selectedLoanAppId = -1;
            _selectedAccountId = -1;
            _selectedLoanAmount = 0;
            dgvLoanApps.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
