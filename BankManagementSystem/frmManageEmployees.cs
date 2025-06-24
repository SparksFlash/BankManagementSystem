using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmManageEmployees : Form
    {
        private int _selectedEmployeeId = -1;

        public frmManageEmployees()
        {
            InitializeComponent();
        }

        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployeesData();
        }

        private void LoadEmployeesData()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT EmployeeID, FullName, Position, JoinDate, IsActive FROM Employees";
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                    dgvEmployees.DataSource = dt;
                    dgvEmployees.Columns["EmployeeID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load employee data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtPosition.Clear();
            dtpJoinDate.Value = DateTime.Now;
            chkIsActive.Checked = true;
            _selectedEmployeeId = -1;
            dgvEmployees.ClearSelection();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                _selectedEmployeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtPosition.Text = row.Cells["Position"].Value.ToString();
                dtpJoinDate.Value = Convert.ToDateTime(row.Cells["JoinDate"].Value);
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Full Name and Position are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Employees (FullName, Position, JoinDate, IsActive) VALUES (@FullName, @Position, @JoinDate, @IsActive)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                        cmd.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value);
                        cmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("New employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeesData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeId == -1)
            {
                MessageBox.Show("Please select an employee from the list to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE Employees SET FullName = @FullName, Position = @Position, JoinDate = @JoinDate, IsActive = @IsActive WHERE EmployeeID = @EmployeeID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                        cmd.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value);
                        cmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
                        cmd.Parameters.AddWithValue("@EmployeeID", _selectedEmployeeId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeesData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
