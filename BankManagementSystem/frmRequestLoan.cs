using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmRequestLoan : Form
    {
        private readonly int _accountId;

        public frmRequestLoan(int accountId)
        {
            InitializeComponent();
            _accountId = accountId;
        }

        private void frmRequestLoan_Load(object sender, EventArgs e)
        {
            // Pre-populate dropdowns
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbIncomeSource.Items.AddRange(new object[] { "Salaried", "Business", "Rental Income", "Other" });
            cmbLoanType.Items.AddRange(new object[] { "Personal Loan", "Business Loan", "Home Loan", "Auto Loan" });

            // Set default selections
            cmbGender.SelectedIndex = 0;
            cmbIncomeSource.SelectedIndex = 0;
            cmbLoanType.SelectedIndex = 0;

            // Load any existing customer info to pre-fill the form
            LoadCustomerInfo();
        }

        private void LoadCustomerInfo()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT AccountHolderName, Email FROM Accounts WHERE AccountID = @AccountID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", _accountId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader["AccountHolderName"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load customer information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // --- Basic Validation ---
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtMobile.Text) ||
                numLoanAmount.Value <= 0)
            {
                MessageBox.Show("Please fill in all required fields (Full Name, Mobile, Loan Amount).", "Required Fields Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO LoanApplications 
                                     (AccountID, LoanAmount, RepaymentPeriodMonths, Reason, MonthlyIncome,
                                      FullName, FathersName, DateOfBirth, Gender, NIDNumber, MobileNumber, EmailAddress,
                                      PermanentAddress, PresentAddress, IncomeSource, HasExistingLoans, LoanType, LoanPurpose) 
                                     VALUES 
                                     (@AccountID, @LoanAmount, @RepaymentPeriod, @Reason, @MonthlyIncome,
                                      @FullName, @FathersName, @DateOfBirth, @Gender, @NIDNumber, @MobileNumber, @EmailAddress,
                                      @PermanentAddress, @PresentAddress, @IncomeSource, @HasExistingLoans, @LoanType, @LoanPurpose)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add all parameters from the form controls
                        cmd.Parameters.AddWithValue("@AccountID", _accountId);
                        cmd.Parameters.AddWithValue("@LoanAmount", numLoanAmount.Value);
                        cmd.Parameters.AddWithValue("@RepaymentPeriod", (int)numLoanTenure.Value);
                        cmd.Parameters.AddWithValue("@Reason", txtLoanPurpose.Text); // Note: txtLoanPurpose is used for Reason
                        cmd.Parameters.AddWithValue("@MonthlyIncome", numMonthlyIncome.Value);

                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@FathersName", txtParentName.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@NIDNumber", txtNID.Text);
                        cmd.Parameters.AddWithValue("@MobileNumber", txtMobile.Text);
                        cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@PermanentAddress", txtPermanentAddress.Text);
                        cmd.Parameters.AddWithValue("@PresentAddress", txtPresentAddress.Text);

                        cmd.Parameters.AddWithValue("@IncomeSource", cmbIncomeSource.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@HasExistingLoans", rdbLoansYes.Checked);

                        cmd.Parameters.AddWithValue("@LoanType", cmbLoanType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@LoanPurpose", txtLoanPurpose.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your loan application has been submitted successfully. It is now pending review.", "Application Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting your application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
