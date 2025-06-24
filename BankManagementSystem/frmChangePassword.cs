using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmChangePassword : Form
    {
        private readonly int _userId;

        public frmChangePassword(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // --- Input Validation ---
            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The new password and confirmation password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("The new password must be at least 6 characters long.", "Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Database Interaction ---
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    // Step 1: Verify the current password
                    string storedPassword = null;
                    string query = "SELECT Password FROM Users WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            storedPassword = result.ToString();
                        }
                    }

                    if (storedPassword != currentPassword)
                    {
                        MessageBox.Show("The current password you entered is incorrect.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Step 2: Update to the new password
                    string updateQuery = "UPDATE Users SET Password = @NewPassword WHERE UserID = @UserID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@UserID", _userId);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Your password has been changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while changing your password: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
