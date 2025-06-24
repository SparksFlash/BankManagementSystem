using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadEmployees();
            LoadTodaysAttendance();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("T");
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT EmployeeID, FullName FROM Employees WHERE IsActive = 1 ORDER BY FullName";
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);

                    // **FIX**: Temporarily detach the event handler to prevent it from firing during data loading.
                    cmbEmployees.SelectedIndexChanged -= cmbEmployees_SelectedIndexChanged;

                    cmbEmployees.DataSource = dt;
                    cmbEmployees.DisplayMember = "FullName";
                    cmbEmployees.ValueMember = "EmployeeID";
                    cmbEmployees.SelectedIndex = -1; // No employee selected initially

                    // **FIX**: Re-attach the event handler after the data is loaded.
                    cmbEmployees.SelectedIndexChanged += cmbEmployees_SelectedIndexChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load employees: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTodaysAttendance()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT 
                                        e.FullName,
                                        ar.ClockInTime,
                                        ar.ClockOutTime
                                     FROM AttendanceRecords ar
                                     JOIN Employees e ON ar.EmployeeID = e.EmployeeID
                                     WHERE ar.AttendanceDate = @TodayDate
                                     ORDER BY ar.ClockInTime DESC";

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@TodayDate", DateTime.Today);
                    adapter.Fill(dt);
                    dgvAttendanceToday.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load today's attendance: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckEmployeeStatus()
        {
            if (cmbEmployees.SelectedIndex == -1 || cmbEmployees.SelectedValue == null)
            {
                btnClockIn.Enabled = false;
                btnClockOut.Enabled = false;
                return;
            }

            int employeeId = (int)cmbEmployees.SelectedValue;
            bool hasClockedIn = false;
            bool hasClockedOut = false;

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ClockInTime, ClockOutTime FROM AttendanceRecords WHERE EmployeeID = @EmployeeID AND AttendanceDate = @TodayDate";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        cmd.Parameters.AddWithValue("@TodayDate", DateTime.Today);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                hasClockedIn = true;
                                if (!reader.IsDBNull(reader.GetOrdinal("ClockOutTime")))
                                {
                                    hasClockedOut = true;
                                }
                            }
                        }
                    }
                }

                if (hasClockedOut)
                {
                    btnClockIn.Enabled = false;
                    btnClockOut.Enabled = false;
                }
                else if (hasClockedIn)
                {
                    btnClockIn.Enabled = false;
                    btnClockOut.Enabled = true;
                }
                else
                {
                    btnClockIn.Enabled = true;
                    btnClockOut.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to check employee status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckEmployeeStatus();
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedIndex == -1) return;
            int employeeId = (int)cmbEmployees.SelectedValue;

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO AttendanceRecords (EmployeeID, ClockInTime, AttendanceDate) VALUES (@EmployeeID, @ClockInTime, @AttendanceDate)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        cmd.Parameters.AddWithValue("@ClockInTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@AttendanceDate", DateTime.Today);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadTodaysAttendance();
                CheckEmployeeStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to clock in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedIndex == -1) return;
            int employeeId = (int)cmbEmployees.SelectedValue;

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE AttendanceRecords SET ClockOutTime = @ClockOutTime WHERE EmployeeID = @EmployeeID AND AttendanceDate = @TodayDate AND ClockOutTime IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ClockOutTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        cmd.Parameters.AddWithValue("@TodayDate", DateTime.Today);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadTodaysAttendance();
                CheckEmployeeStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to clock out: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
