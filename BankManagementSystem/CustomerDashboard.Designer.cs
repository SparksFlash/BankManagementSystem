namespace BankManagementSystem
{
    partial class CustomerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnRequestLoan = new System.Windows.Forms.Button();
            this.btnGenerateStatement = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.lblBalanceLabel = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.pnlHeader.Controls.Add(this.btnChangePassword);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(822, 22);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(150, 35);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(984, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Customer Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(822, 504);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnRequestLoan);
            this.pnlMain.Controls.Add(this.btnGenerateStatement);
            this.pnlMain.Controls.Add(this.btnHistory);
            this.pnlMain.Controls.Add(this.btnTransfer);
            this.pnlMain.Controls.Add(this.btnWithdraw);
            this.pnlMain.Controls.Add(this.btnDeposit);
            this.pnlMain.Location = new System.Drawing.Point(12, 340);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(960, 150);
            this.pnlMain.TabIndex = 3;
            // 
            // btnRequestLoan
            // 
            this.btnRequestLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnRequestLoan.FlatAppearance.BorderSize = 0;
            this.btnRequestLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRequestLoan.ForeColor = System.Drawing.Color.White;
            this.btnRequestLoan.Location = new System.Drawing.Point(490, 80);
            this.btnRequestLoan.Name = "btnRequestLoan";
            this.btnRequestLoan.Size = new System.Drawing.Size(210, 45);
            this.btnRequestLoan.TabIndex = 5;
            this.btnRequestLoan.Text = "Request a Loan";
            this.btnRequestLoan.UseVisualStyleBackColor = false;
            this.btnRequestLoan.Click += new System.EventHandler(this.btnRequestLoan_Click);
            // 
            // btnGenerateStatement
            // 
            this.btnGenerateStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGenerateStatement.FlatAppearance.BorderSize = 0;
            this.btnGenerateStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateStatement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateStatement.ForeColor = System.Drawing.Color.White;
            this.btnGenerateStatement.Location = new System.Drawing.Point(730, 80);
            this.btnGenerateStatement.Name = "btnGenerateStatement";
            this.btnGenerateStatement.Size = new System.Drawing.Size(210, 45);
            this.btnGenerateStatement.TabIndex = 4;
            this.btnGenerateStatement.Text = "Generate Statement";
            this.btnGenerateStatement.UseVisualStyleBackColor = false;
            this.btnGenerateStatement.Click += new System.EventHandler(this.btnGenerateStatement_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(730, 25);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(210, 45);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Transaction History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(490, 25);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(210, 45);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer Funds";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(250, 25);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(210, 100);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(20, 25);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(210, 100);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // pnlBalance
            // 
            this.pnlBalance.BackColor = System.Drawing.Color.White;
            this.pnlBalance.Controls.Add(this.lblBalanceValue);
            this.pnlBalance.Controls.Add(this.lblBalanceLabel);
            this.pnlBalance.Location = new System.Drawing.Point(12, 180);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(960, 150);
            this.pnlBalance.TabIndex = 2;
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblBalanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblBalanceValue.Location = new System.Drawing.Point(0, 60);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(960, 65);
            this.lblBalanceValue.TabIndex = 1;
            this.lblBalanceValue.Text = "$0.00";
            this.lblBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalanceLabel
            // 
            this.lblBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblBalanceLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblBalanceLabel.Location = new System.Drawing.Point(0, 15);
            this.lblBalanceLabel.Name = "lblBalanceLabel";
            this.lblBalanceLabel.Size = new System.Drawing.Size(960, 35);
            this.lblBalanceLabel.TabIndex = 0;
            this.lblBalanceLabel.Text = "CURRENT BALANCE";
            this.lblBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblWelcome.Location = new System.Drawing.Point(0, 95);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(984, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, [Customer Name]!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblAccountNumber.Location = new System.Drawing.Point(0, 135);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(984, 23);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account #: [Account Number]";
            this.lblAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlBalance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Label lblBalanceLabel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Button btnGenerateStatement;
        private System.Windows.Forms.Button btnRequestLoan;
        private System.Windows.Forms.Button btnChangePassword;
    }
}
