namespace BankManagementSystem
{
    partial class frmManageLoans
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvLoanApps = new System.Windows.Forms.DataGridView();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblRepaymentPeriod = new System.Windows.Forms.Label();
            this.lblMonthlyIncome = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblHolderName = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanApps)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DarkRed;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1312, 86);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1312, 86);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Manage Loan Applications";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLoanApps
            // 
            this.dgvLoanApps.AllowUserToAddRows = false;
            this.dgvLoanApps.AllowUserToDeleteRows = false;
            this.dgvLoanApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoanApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoanApps.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoanApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoanApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoanApps.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoanApps.Location = new System.Drawing.Point(16, 105);
            this.dgvLoanApps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLoanApps.MultiSelect = false;
            this.dgvLoanApps.Name = "dgvLoanApps";
            this.dgvLoanApps.ReadOnly = true;
            this.dgvLoanApps.RowHeadersVisible = false;
            this.dgvLoanApps.RowHeadersWidth = 51;
            this.dgvLoanApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoanApps.Size = new System.Drawing.Size(1280, 308);
            this.dgvLoanApps.TabIndex = 9;
            this.dgvLoanApps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanApps_CellClick);
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.txtReason);
            this.grpDetails.Controls.Add(this.lblReason);
            this.grpDetails.Controls.Add(this.lblRepaymentPeriod);
            this.grpDetails.Controls.Add(this.lblMonthlyIncome);
            this.grpDetails.Controls.Add(this.lblLoanAmount);
            this.grpDetails.Controls.Add(this.lblAccountNumber);
            this.grpDetails.Controls.Add(this.lblHolderName);
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpDetails.Location = new System.Drawing.Point(16, 425);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetails.Size = new System.Drawing.Size(1051, 251);
            this.grpDetails.TabIndex = 10;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Application Details";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.White;
            this.txtReason.Location = new System.Drawing.Point(560, 62);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(465, 159);
            this.txtReason.TabIndex = 6;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(556, 37);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(163, 23);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Loan Type & Purpose:";
            // 
            // lblRepaymentPeriod
            // 
            this.lblRepaymentPeriod.AutoSize = true;
            this.lblRepaymentPeriod.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepaymentPeriod.Location = new System.Drawing.Point(27, 197);
            this.lblRepaymentPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepaymentPeriod.Name = "lblRepaymentPeriod";
            this.lblRepaymentPeriod.Size = new System.Drawing.Size(168, 25);
            this.lblRepaymentPeriod.TabIndex = 4;
            this.lblRepaymentPeriod.Text = "Repayment Period:";
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyIncome.Location = new System.Drawing.Point(27, 154);
            this.lblMonthlyIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(153, 25);
            this.lblMonthlyIncome.TabIndex = 3;
            this.lblMonthlyIncome.Text = "Monthly Income:";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmount.Location = new System.Drawing.Point(27, 111);
            this.lblLoanAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(129, 25);
            this.lblLoanAmount.TabIndex = 2;
            this.lblLoanAmount.Text = "Loan Amount:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(27, 68);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(159, 25);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblHolderName
            // 
            this.lblHolderName.AutoSize = true;
            this.lblHolderName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolderName.Location = new System.Drawing.Point(27, 31);
            this.lblHolderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHolderName.Name = "lblHolderName";
            this.lblHolderName.Size = new System.Drawing.Size(157, 28);
            this.lblHolderName.TabIndex = 0;
            this.lblHolderName.Text = "Applicant Name";
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.BackColor = System.Drawing.Color.Green;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(1096, 443);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(200, 62);
            this.btnApprove.TabIndex = 11;
            this.btnApprove.Text = "APPROVE";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(1096, 527);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(200, 62);
            this.btnReject.TabIndex = 12;
            this.btnReject.Text = "REJECT";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1096, 614);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 62);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmManageLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.dgvLoanApps);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManageLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Loan Applications";
            this.Load += new System.EventHandler(this.frmManageLoans_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanApps)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvLoanApps;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblHolderName;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblRepaymentPeriod;
        private System.Windows.Forms.Label lblMonthlyIncome;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnClose;
    }
}
