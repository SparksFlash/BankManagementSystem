using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = null;
            string adminRole = null; // Variable to store the admin's role
            int userId = -1;

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    // Updated query to select AdminRole
                    string query = "SELECT UserID, UserType, AdminRole FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = reader.GetInt32(0);
                                userType = reader.GetString(1);
                                // Read the AdminRole. It can be null for customers.
                                if (!reader.IsDBNull(2))
                                {
                                    adminRole = reader.GetString(2);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userType != null)
            {
                this.Hide();

                if (userType == "Admin")
                {
                    // This is the corrected line that passes both the UserID and AdminRole.
                    AdminDashboard adminForm = new AdminDashboard(userId, adminRole);
                    adminForm.ShowDialog();
                }
                else if (userType == "Customer")
                {
                    CustomerDashboard customerForm = new CustomerDashboard(userId);
                    customerForm.ShowDialog();
                }

                txtUsername.Clear();
                txtPassword.Clear();
                this.Show();
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
