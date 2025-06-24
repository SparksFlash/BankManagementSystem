using System;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class AdminDashboard : Form
    {
        private readonly int _adminId;
        private readonly string _adminRole;

        public AdminDashboard(int adminId, string adminRole)
        {
            InitializeComponent();
            _adminId = adminId;
            _adminRole = adminRole;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            btnManageAdmins.Visible = (_adminRole == "SuperAdmin");
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            frmManageAccounts manageAccountsForm = new frmManageAccounts();
            manageAccountsForm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmAdminViewTransactions viewTransactionsForm = new frmAdminViewTransactions();
            viewTransactionsForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmAdminViewTransactions viewTransactionsForm = new frmAdminViewTransactions();
            viewTransactionsForm.ShowDialog();
        }

        private void btnManageLoans_Click(object sender, EventArgs e)
        {
            frmManageLoans manageLoansForm = new frmManageLoans(_adminId);
            manageLoansForm.ShowDialog();
        }

        private void btnManageAdmins_Click(object sender, EventArgs e)
        {
            frmManageAdmins manageAdminsForm = new frmManageAdmins(_adminId);
            manageAdminsForm.ShowDialog();
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            frmManageEmployees manageEmployeesForm = new frmManageEmployees();
            manageEmployeesForm.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance attendanceForm = new frmAttendance();
            attendanceForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Sir", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
