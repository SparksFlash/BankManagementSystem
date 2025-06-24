namespace BankManagementSystem
{
    partial class frmAttendance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnClockOut = new System.Windows.Forms.Button();
            this.btnClockIn = new System.Windows.Forms.Button();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.dgvAttendanceToday = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceToday)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(784, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(784, 70);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Employee Attendance";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentTime);
            this.groupBox1.Controls.Add(this.btnClockOut);
            this.groupBox1.Controls.Add(this.btnClockIn);
            this.groupBox1.Controls.Add(this.cmbEmployees);
            this.groupBox1.Controls.Add(this.lblSelectEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mark Attendance";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(550, 15);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(200, 30);
            this.lblCurrentTime.TabIndex = 4;
            this.lblCurrentTime.Text = "00:00:00";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClockOut
            // 
            this.btnClockOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClockOut.Enabled = false;
            this.btnClockOut.FlatAppearance.BorderSize = 0;
            this.btnClockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClockOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClockOut.ForeColor = System.Drawing.Color.White;
            this.btnClockOut.Location = new System.Drawing.Point(400, 50);
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(120, 35);
            this.btnClockOut.TabIndex = 3;
            this.btnClockOut.Text = "CLOCK OUT";
            this.btnClockOut.UseVisualStyleBackColor = false;
            this.btnClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
            // 
            // btnClockIn
            // 
            this.btnClockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnClockIn.Enabled = false;
            this.btnClockIn.FlatAppearance.BorderSize = 0;
            this.btnClockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClockIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClockIn.ForeColor = System.Drawing.Color.White;
            this.btnClockIn.Location = new System.Drawing.Point(400, 15);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(120, 35);
            this.btnClockIn.TabIndex = 2;
            this.btnClockIn.Text = "CLOCK IN";
            this.btnClockIn.UseVisualStyleBackColor = false;
            this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(20, 50);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(350, 29);
            this.cmbEmployees.TabIndex = 1;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.Location = new System.Drawing.Point(17, 30);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(107, 17);
            this.lblSelectEmployee.TabIndex = 0;
            this.lblSelectEmployee.Text = "Select Employee:";
            // 
            // dgvAttendanceToday
            // 
            this.dgvAttendanceToday.AllowUserToAddRows = false;
            this.dgvAttendanceToday.AllowUserToDeleteRows = false;
            this.dgvAttendanceToday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendanceToday.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendanceToday.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendanceToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendanceToday.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendanceToday.Location = new System.Drawing.Point(12, 200);
            this.dgvAttendanceToday.Name = "dgvAttendanceToday";
            this.dgvAttendanceToday.ReadOnly = true;
            this.dgvAttendanceToday.RowHeadersVisible = false;
            this.dgvAttendanceToday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceToday.Size = new System.Drawing.Size(760, 280);
            this.dgvAttendanceToday.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(652, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(784, 551);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAttendanceToday);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.pnlHeader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceToday)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectEmployee;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Button btnClockIn;
        private System.Windows.Forms.Button btnClockOut;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.DataGridView dgvAttendanceToday;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
    }
}
