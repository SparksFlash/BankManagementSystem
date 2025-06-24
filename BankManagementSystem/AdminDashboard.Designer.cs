namespace BankManagementSystem  //namespace gathers all class
{
    partial class AdminDashboard
    {
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.btnManageAdmins = new System.Windows.Forms.Button();
            this.btnManageLoans = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnManageAccounts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1179, 98);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 26);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1179, 46);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Admin Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.LightBlue;
            this.pnlMain.Controls.Add(this.btnAttendance);
            this.pnlMain.Controls.Add(this.btnManageEmployees);
            this.pnlMain.Controls.Add(this.btnManageAdmins);
            this.pnlMain.Controls.Add(this.btnManageLoans);
            this.pnlMain.Controls.Add(this.btnReports);
            this.pnlMain.Controls.Add(this.btnTransactions);
            this.pnlMain.Controls.Add(this.btnManageAccounts);
            this.pnlMain.Location = new System.Drawing.Point(67, 184);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1045, 328);
            this.pnlMain.TabIndex = 1;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(392, 194);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(267, 64);
            this.btnAttendance.TabIndex = 6;
            this.btnAttendance.Text = "Take Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnManageEmployees.FlatAppearance.BorderSize = 0;
            this.btnManageEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployees.ForeColor = System.Drawing.Color.White;
            this.btnManageEmployees.Location = new System.Drawing.Point(745, 155);
            this.btnManageEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(267, 103);
            this.btnManageEmployees.TabIndex = 5;
            this.btnManageEmployees.Text = "Manage Employees";
            this.btnManageEmployees.UseVisualStyleBackColor = false;
            this.btnManageEmployees.Click += new System.EventHandler(this.btnManageEmployees_Click);
            // 
            // btnManageAdmins
            // 
            this.btnManageAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnManageAdmins.FlatAppearance.BorderSize = 0;
            this.btnManageAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAdmins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAdmins.ForeColor = System.Drawing.Color.White;
            this.btnManageAdmins.Location = new System.Drawing.Point(33, 155);
            this.btnManageAdmins.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageAdmins.Name = "btnManageAdmins";
            this.btnManageAdmins.Size = new System.Drawing.Size(267, 103);
            this.btnManageAdmins.TabIndex = 4;
            this.btnManageAdmins.Text = "Manage Admins";
            this.btnManageAdmins.UseVisualStyleBackColor = false;
            this.btnManageAdmins.Click += new System.EventHandler(this.btnManageAdmins_Click);
            // 
            // btnManageLoans
            // 
            this.btnManageLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnManageLoans.FlatAppearance.BorderSize = 0;
            this.btnManageLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLoans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageLoans.ForeColor = System.Drawing.Color.White;
            this.btnManageLoans.Location = new System.Drawing.Point(745, 25);
            this.btnManageLoans.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageLoans.Name = "btnManageLoans";
            this.btnManageLoans.Size = new System.Drawing.Size(267, 106);
            this.btnManageLoans.TabIndex = 3;
            this.btnManageLoans.Text = "Manage Loans";
            this.btnManageLoans.UseVisualStyleBackColor = false;
            this.btnManageLoans.Click += new System.EventHandler(this.btnManageLoans_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(392, 113);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(267, 60);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Generate Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Location = new System.Drawing.Point(392, 25);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(267, 65);
            this.btnTransactions.TabIndex = 1;
            this.btnTransactions.Text = "View Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnManageAccounts
            // 
            this.btnManageAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnManageAccounts.FlatAppearance.BorderSize = 0;
            this.btnManageAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageAccounts.ForeColor = System.Drawing.Color.White;
            this.btnManageAccounts.Location = new System.Drawing.Point(33, 25);
            this.btnManageAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Size = new System.Drawing.Size(267, 106);
            this.btnManageAccounts.TabIndex = 0;
            this.btnManageAccounts.Text = "Manage Accounts";
            this.btnManageAccounts.UseVisualStyleBackColor = false;
            this.btnManageAccounts.Click += new System.EventHandler(this.btnManageAccounts_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(912, 569);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 55);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblWelcome.Location = new System.Drawing.Point(0, 117);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1179, 37);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome, Admin!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(659, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Message";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1179, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1194, 605);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnManageAccounts;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManageLoans;
        private System.Windows.Forms.Button btnManageAdmins;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button button1;
    }
}
