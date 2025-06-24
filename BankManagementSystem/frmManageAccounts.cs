using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmManageAccounts : Form
    {
        private int _selectedAccountId = -1;
        private int _selectedUserId = -1;

        public frmManageAccounts()
        {
            InitializeComponent();
        }

        private void frmManageAccounts_Load(object sender, EventArgs e)
        {
            // Load all data initially
            LoadAccountsData();
        }

        // The method now accepts an optional search term
        private void LoadAccountsData(string searchTerm = null)
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT 
                                        a.AccountID, 
                                        a.UserID, 
                                        a.AccountNumber, 
                                        a.AccountHolderName, 
                                        a.AccountType, 
                                        a.Balance, 
                                        u.Username, 
                                        u.Password
                                     FROM Accounts a
                                     JOIN Users u ON a.UserID = u.UserID
                                     WHERE u.UserType = 'Customer'";

                    // If a search term is provided, add a WHERE clause to filter the results
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query += " AND (a.AccountHolderName LIKE @SearchTerm OR a.AccountNumber LIKE @SearchTerm)";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the search term parameter if it exists
                        if (!string.IsNullOrWhiteSpace(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dgvAccounts.DataSource = dt;
                    }

                    // Hide ID columns as they are not for the user
                    if (dgvAccounts.Columns.Contains("AccountID"))
                    {
                        dgvAccounts.Columns["AccountID"].Visible = false;
                    }
                    if (dgvAccounts.Columns.Contains("UserID"))
                    {
                        dgvAccounts.Columns["UserID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load account data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccounts.Rows[e.RowIndex];
                _selectedAccountId = Convert.ToInt32(row.Cells["AccountID"].Value);
                _selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);

                txtAccountNumber.Text = row.Cells["AccountNumber"].Value.ToString();
                txtHolderName.Text = row.Cells["AccountHolderName"].Value.ToString();
                txtAccountType.Text = row.Cells["AccountType"].Value.ToString();
                numBalance.Value = Convert.ToDecimal(row.Cells["Balance"].Value);
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                lblPassword.Text = "Login Password:";
            }
        }

        private void ClearFields()
        {
            txtAccountNumber.Clear();
            txtHolderName.Clear();
            txtAccountType.Clear();
            numBalance.Value = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            _selectedAccountId = -1;
            _selectedUserId = -1;
            dgvAccounts.ClearSelection();
            lblPassword.Text = "Login Password:";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtAccountNumber.Text))
            {
                MessageBox.Show("Username, Password, and Account Number are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    string userQuery = "INSERT INTO Users (Username, Password, UserType) OUTPUT INSERTED.UserID VALUES (@Username, @Password, 'Customer');";
                    int newUserId;
                    using (SqlCommand userCmd = new SqlCommand(userQuery, con, transaction))
                    {
                        userCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        userCmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        newUserId = (int)userCmd.ExecuteScalar();
                    }

                    string accountQuery = "INSERT INTO Accounts (UserID, AccountNumber, AccountHolderName, AccountType, Balance) VALUES (@UserID, @AccountNumber, @AccountHolderName, @AccountType, @Balance);";
                    using (SqlCommand accountCmd = new SqlCommand(accountQuery, con, transaction))
                    {
                        accountCmd.Parameters.AddWithValue("@UserID", newUserId);
                        accountCmd.Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text);
                        accountCmd.Parameters.AddWithValue("@AccountHolderName", txtHolderName.Text);
                        accountCmd.Parameters.AddWithValue("@AccountType", txtAccountType.Text);
                        accountCmd.Parameters.AddWithValue("@Balance", numBalance.Value);
                        accountCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("New account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccountsData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to create new account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedAccountId == -1)
            {
                MessageBox.Show("Please select an account from the list to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    string userQuery = "UPDATE Users SET Username = @Username, Password = @Password WHERE UserID = @UserID;";
                    using (SqlCommand userCmd = new SqlCommand(userQuery, con, transaction))
                    {
                        userCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        userCmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        userCmd.Parameters.AddWithValue("@UserID", _selectedUserId);
                        userCmd.ExecuteNonQuery();
                    }

                    string accountQuery = "UPDATE Accounts SET AccountNumber = @AccountNumber, AccountHolderName = @AccountHolderName, AccountType = @AccountType, Balance = @Balance WHERE AccountID = @AccountID;";
                    using (SqlCommand accountCmd = new SqlCommand(accountQuery, con, transaction))
                    {
                        accountCmd.Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text);
                        accountCmd.Parameters.AddWithValue("@AccountHolderName", txtHolderName.Text);
                        accountCmd.Parameters.AddWithValue("@AccountType", txtAccountType.Text);
                        accountCmd.Parameters.AddWithValue("@Balance", numBalance.Value);
                        accountCmd.Parameters.AddWithValue("@AccountID", _selectedAccountId);
                        accountCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccountsData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to update account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAccountId == -1)
            {
                MessageBox.Show("Please select an account from the list to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to permanently delete this account and all its transactions? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        string transQuery = "DELETE FROM Transactions WHERE AccountID = @AccountID OR DestinationAccountID = @AccountID;";
                        using (SqlCommand transCmd = new SqlCommand(transQuery, con, transaction))
                        {
                            transCmd.Parameters.AddWithValue("@AccountID", _selectedAccountId);
                            transCmd.ExecuteNonQuery();
                        }

                        string accQuery = "DELETE FROM Accounts WHERE AccountID = @AccountID;";
                        using (SqlCommand accCmd = new SqlCommand(accQuery, con, transaction))
                        {
                            accCmd.Parameters.AddWithValue("@AccountID", _selectedAccountId);
                            accCmd.ExecuteNonQuery();
                        }

                        string userQuery = "DELETE FROM Users WHERE UserID = @UserID;";
                        using (SqlCommand userCmd = new SqlCommand(userQuery, con, transaction))
                        {
                            userCmd.Parameters.AddWithValue("@UserID", _selectedUserId);
                            userCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountsData();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed to delete account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        // New event handler for the search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAccountsData(txtSearch.Text);
        }

        // New event handler for the show all button
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadAccountsData();
        }
    }
}
