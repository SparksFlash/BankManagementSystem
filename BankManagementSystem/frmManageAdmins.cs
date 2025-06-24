using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmManageAdmins : Form
    {
        private readonly int _superAdminId;
        private int _selectedAdminId = -1;

        public frmManageAdmins(int superAdminId)
        {
            InitializeComponent();
            _superAdminId = superAdminId;
        }

        private void frmManageAdmins_Load(object sender, EventArgs e)
        {
            // Populate the roles dropdown
            cmbRole.Items.Add("StandardAdmin");
            cmbRole.Items.Add("SuperAdmin");
            cmbRole.SelectedIndex = 0; // Default to StandardAdmin

            LoadAdminsData();
        }

        private void LoadAdminsData()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    // Query no longer selects the password for security reasons
                    string query = "SELECT UserID, Username, AdminRole FROM Users WHERE UserType = 'Admin'";
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                    dgvAdmins.DataSource = dt;

                    // Hide the ID column
                    dgvAdmins.Columns["UserID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load admin data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
            _selectedAdminId = -1;
            dgvAdmins.ClearSelection();
            // Reset the password label to its default text
            lblPassword.Text = "Password:";
        }

        private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdmins.Rows[e.RowIndex];
                _selectedAdminId = Convert.ToInt32(row.Cells["UserID"].Value);
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["AdminRole"].Value.ToString();

                // For security, never display the password. Clear the box instead.
                txtPassword.Clear();
                // Update the label to guide the user
                lblPassword.Text = "New Password (leave blank to keep unchanged):";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and Password are required for a new admin.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    // Check if username already exists to provide a better error message
                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        int userCount = (int)checkCmd.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show("This username already exists. Please choose another.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Proceed with inserting the new admin
                    string query = "INSERT INTO Users (Username, Password, UserType, AdminRole) VALUES (@Username, @Password, 'Admin', @AdminRole)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@AdminRole", cmbRole.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("New admin created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdminsData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedAdminId == -1)
            {
                MessageBox.Show("Please select an admin from the list to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    // **FIXED LOGIC**: Check if a new password has been entered.
                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        // If yes, update username, password, and role
                        string query = "UPDATE Users SET Username = @Username, Password = @Password, AdminRole = @AdminRole WHERE UserID = @UserID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@AdminRole", cmbRole.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@UserID", _selectedAdminId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // If no, update only username and role
                        string query = "UPDATE Users SET Username = @Username, AdminRole = @AdminRole WHERE UserID = @UserID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@AdminRole", cmbRole.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@UserID", _selectedAdminId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Admin updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdminsData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAdminId == -1)
            {
                MessageBox.Show("Please select an admin from the list to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent a SuperAdmin from deleting their own account
            if (_selectedAdminId == _superAdminId)
            {
                MessageBox.Show("You cannot delete your own Super Admin account.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this admin account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = DatabaseHelper.GetConnection())
                    {
                        string query = "DELETE FROM Users WHERE UserID = @UserID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@UserID", _selectedAdminId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Admin deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdminsData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
