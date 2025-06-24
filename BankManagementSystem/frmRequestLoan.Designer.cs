namespace BankManagementSystem
{
    partial class frmRequestLoan
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtPresentAddress = new System.Windows.Forms.TextBox();
            this.lblPresentAddress = new System.Windows.Forms.Label();
            this.txtPermanentAddress = new System.Windows.Forms.TextBox();
            this.lblPermanentAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.lblNID = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblParentName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.grpFinancialInfo = new System.Windows.Forms.GroupBox();
            this.rdbLoansNo = new System.Windows.Forms.RadioButton();
            this.rdbLoansYes = new System.Windows.Forms.RadioButton();
            this.lblExistingLoans = new System.Windows.Forms.Label();
            this.cmbIncomeSource = new System.Windows.Forms.ComboBox();
            this.lblIncomeSource = new System.Windows.Forms.Label();
            this.numMonthlyIncome = new System.Windows.Forms.NumericUpDown();
            this.lblMonthlyIncome = new System.Windows.Forms.Label();
            this.grpLoanDetails = new System.Windows.Forms.GroupBox();
            this.txtLoanPurpose = new System.Windows.Forms.TextBox();
            this.lblLoanPurpose = new System.Windows.Forms.Label();
            this.numLoanTenure = new System.Windows.Forms.NumericUpDown();
            this.lblLoanTenure = new System.Windows.Forms.Label();
            this.numLoanAmount = new System.Windows.Forms.NumericUpDown();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.cmbLoanType = new System.Windows.Forms.ComboBox();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.grpPersonalInfo.SuspendLayout();
            this.grpFinancialInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyIncome)).BeginInit();
            this.grpLoanDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanTenure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(784, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(784, 70);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Loan Application Form";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(622, 594);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 45);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(457, 594);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.txtPresentAddress);
            this.grpPersonalInfo.Controls.Add(this.lblPresentAddress);
            this.grpPersonalInfo.Controls.Add(this.txtPermanentAddress);
            this.grpPersonalInfo.Controls.Add(this.lblPermanentAddress);
            this.grpPersonalInfo.Controls.Add(this.txtEmail);
            this.grpPersonalInfo.Controls.Add(this.lblEmail);
            this.grpPersonalInfo.Controls.Add(this.txtMobile);
            this.grpPersonalInfo.Controls.Add(this.lblMobile);
            this.grpPersonalInfo.Controls.Add(this.txtNID);
            this.grpPersonalInfo.Controls.Add(this.lblNID);
            this.grpPersonalInfo.Controls.Add(this.cmbGender);
            this.grpPersonalInfo.Controls.Add(this.lblGender);
            this.grpPersonalInfo.Controls.Add(this.dtpDOB);
            this.grpPersonalInfo.Controls.Add(this.lblDOB);
            this.grpPersonalInfo.Controls.Add(this.txtParentName);
            this.grpPersonalInfo.Controls.Add(this.lblParentName);
            this.grpPersonalInfo.Controls.Add(this.txtFullName);
            this.grpPersonalInfo.Controls.Add(this.lblFullName);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalInfo.Location = new System.Drawing.Point(12, 85);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(370, 493);
            this.grpPersonalInfo.TabIndex = 1;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "1. Personal Information";
            // 
            // txtPresentAddress
            // 
            this.txtPresentAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPresentAddress.Location = new System.Drawing.Point(20, 410);
            this.txtPresentAddress.Multiline = true;
            this.txtPresentAddress.Name = "txtPresentAddress";
            this.txtPresentAddress.Size = new System.Drawing.Size(330, 60);
            this.txtPresentAddress.TabIndex = 9;
            // 
            // lblPresentAddress
            // 
            this.lblPresentAddress.AutoSize = true;
            this.lblPresentAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentAddress.Location = new System.Drawing.Point(17, 390);
            this.lblPresentAddress.Name = "lblPresentAddress";
            this.lblPresentAddress.Size = new System.Drawing.Size(94, 15);
            this.lblPresentAddress.TabIndex = 16;
            this.lblPresentAddress.Text = "Present Address:";
            // 
            // txtPermanentAddress
            // 
            this.txtPermanentAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPermanentAddress.Location = new System.Drawing.Point(20, 325);
            this.txtPermanentAddress.Multiline = true;
            this.txtPermanentAddress.Name = "txtPermanentAddress";
            this.txtPermanentAddress.Size = new System.Drawing.Size(330, 60);
            this.txtPermanentAddress.TabIndex = 8;
            // 
            // lblPermanentAddress
            // 
            this.lblPermanentAddress.AutoSize = true;
            this.lblPermanentAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermanentAddress.Location = new System.Drawing.Point(17, 305);
            this.lblPermanentAddress.Name = "lblPermanentAddress";
            this.lblPermanentAddress.Size = new System.Drawing.Size(112, 15);
            this.lblPermanentAddress.TabIndex = 14;
            this.lblPermanentAddress.Text = "Permanent Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(20, 275);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 255);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 15);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email Address:";
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMobile.Location = new System.Drawing.Point(20, 225);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(330, 23);
            this.txtMobile.TabIndex = 6;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(17, 205);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(91, 15);
            this.lblMobile.TabIndex = 10;
            this.lblMobile.Text = "Mobile Number:";
            // 
            // txtNID
            // 
            this.txtNID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNID.Location = new System.Drawing.Point(20, 175);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(330, 23);
            this.txtNID.TabIndex = 5;
            // 
            // lblNID
            // 
            this.lblNID.AutoSize = true;
            this.lblNID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNID.Location = new System.Drawing.Point(17, 155);
            this.lblNID.Name = "lblNID";
            this.lblNID.Size = new System.Drawing.Size(76, 15);
            this.lblNID.TabIndex = 8;
            this.lblNID.Text = "NID Number:";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(210, 125);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(140, 23);
            this.cmbGender.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(207, 105);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(20, 125);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(140, 23);
            this.dtpDOB.TabIndex = 3;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(17, 105);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(76, 15);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // txtParentName
            // 
            this.txtParentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtParentName.Location = new System.Drawing.Point(20, 75);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(330, 23);
            this.txtParentName.TabIndex = 2;
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentName.Location = new System.Drawing.Point(17, 55);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(127, 15);
            this.lblParentName.TabIndex = 2;
            this.lblParentName.Text = "Father\'s/Mother\'s Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(20, 25);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(330, 23);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(17, 25);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 15);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // grpFinancialInfo
            // 
            this.grpFinancialInfo.Controls.Add(this.rdbLoansNo);
            this.grpFinancialInfo.Controls.Add(this.rdbLoansYes);
            this.grpFinancialInfo.Controls.Add(this.lblExistingLoans);
            this.grpFinancialInfo.Controls.Add(this.cmbIncomeSource);
            this.grpFinancialInfo.Controls.Add(this.lblIncomeSource);
            this.grpFinancialInfo.Controls.Add(this.numMonthlyIncome);
            this.grpFinancialInfo.Controls.Add(this.lblMonthlyIncome);
            this.grpFinancialInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpFinancialInfo.Location = new System.Drawing.Point(402, 85);
            this.grpFinancialInfo.Name = "grpFinancialInfo";
            this.grpFinancialInfo.Size = new System.Drawing.Size(370, 150);
            this.grpFinancialInfo.TabIndex = 2;
            this.grpFinancialInfo.TabStop = false;
            this.grpFinancialInfo.Text = "2. Financial Information";
            // 
            // rdbLoansNo
            // 
            this.rdbLoansNo.AutoSize = true;
            this.rdbLoansNo.Checked = true;
            this.rdbLoansNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbLoansNo.Location = new System.Drawing.Point(250, 115);
            this.rdbLoansNo.Name = "rdbLoansNo";
            this.rdbLoansNo.Size = new System.Drawing.Size(41, 19);
            this.rdbLoansNo.TabIndex = 14;
            this.rdbLoansNo.TabStop = true;
            this.rdbLoansNo.Text = "No";
            this.rdbLoansNo.UseVisualStyleBackColor = true;
            // 
            // rdbLoansYes
            // 
            this.rdbLoansYes.AutoSize = true;
            this.rdbLoansYes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbLoansYes.Location = new System.Drawing.Point(200, 115);
            this.rdbLoansYes.Name = "rdbLoansYes";
            this.rdbLoansYes.Size = new System.Drawing.Size(42, 19);
            this.rdbLoansYes.TabIndex = 13;
            this.rdbLoansYes.Text = "Yes";
            this.rdbLoansYes.UseVisualStyleBackColor = true;
            // 
            // lblExistingLoans
            // 
            this.lblExistingLoans.AutoSize = true;
            this.lblExistingLoans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingLoans.Location = new System.Drawing.Point(20, 117);
            this.lblExistingLoans.Name = "lblExistingLoans";
            this.lblExistingLoans.Size = new System.Drawing.Size(107, 15);
            this.lblExistingLoans.TabIndex = 4;
            this.lblExistingLoans.Text = "Existing Loans (if any):";
            // 
            // cmbIncomeSource
            // 
            this.cmbIncomeSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncomeSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbIncomeSource.FormattingEnabled = true;
            this.cmbIncomeSource.Location = new System.Drawing.Point(20, 85);
            this.cmbIncomeSource.Name = "cmbIncomeSource";
            this.cmbIncomeSource.Size = new System.Drawing.Size(330, 23);
            this.cmbIncomeSource.TabIndex = 12;
            // 
            // lblIncomeSource
            // 
            this.lblIncomeSource.AutoSize = true;
            this.lblIncomeSource.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeSource.Location = new System.Drawing.Point(17, 65);
            this.lblIncomeSource.Name = "lblIncomeSource";
            this.lblIncomeSource.Size = new System.Drawing.Size(87, 15);
            this.lblIncomeSource.TabIndex = 2;
            this.lblIncomeSource.Text = "Income Source:";
            // 
            // numMonthlyIncome
            // 
            this.numMonthlyIncome.DecimalPlaces = 2;
            this.numMonthlyIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numMonthlyIncome.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMonthlyIncome.Location = new System.Drawing.Point(20, 35);
            this.numMonthlyIncome.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMonthlyIncome.Name = "numMonthlyIncome";
            this.numMonthlyIncome.Size = new System.Drawing.Size(330, 23);
            this.numMonthlyIncome.TabIndex = 11;
            this.numMonthlyIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyIncome.Location = new System.Drawing.Point(17, 20);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(96, 15);
            this.lblMonthlyIncome.TabIndex = 0;
            this.lblMonthlyIncome.Text = "Monthly Income:";
            // 
            // grpLoanDetails
            // 
            this.grpLoanDetails.Controls.Add(this.txtLoanPurpose);
            this.grpLoanDetails.Controls.Add(this.lblLoanPurpose);
            this.grpLoanDetails.Controls.Add(this.numLoanTenure);
            this.grpLoanDetails.Controls.Add(this.lblLoanTenure);
            this.grpLoanDetails.Controls.Add(this.numLoanAmount);
            this.grpLoanDetails.Controls.Add(this.lblLoanAmount);
            this.grpLoanDetails.Controls.Add(this.cmbLoanType);
            this.grpLoanDetails.Controls.Add(this.lblLoanType);
            this.grpLoanDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpLoanDetails.Location = new System.Drawing.Point(402, 245);
            this.grpLoanDetails.Name = "grpLoanDetails";
            this.grpLoanDetails.Size = new System.Drawing.Size(370, 333);
            this.grpLoanDetails.TabIndex = 3;
            this.grpLoanDetails.TabStop = false;
            this.grpLoanDetails.Text = "3. Loan Details";
            // 
            // txtLoanPurpose
            // 
            this.txtLoanPurpose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoanPurpose.Location = new System.Drawing.Point(20, 205);
            this.txtLoanPurpose.Multiline = true;
            this.txtLoanPurpose.Name = "txtLoanPurpose";
            this.txtLoanPurpose.Size = new System.Drawing.Size(330, 110);
            this.txtLoanPurpose.TabIndex = 18;
            // 
            // lblLoanPurpose
            // 
            this.lblLoanPurpose.AutoSize = true;
            this.lblLoanPurpose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanPurpose.Location = new System.Drawing.Point(17, 185);
            this.lblLoanPurpose.Name = "lblLoanPurpose";
            this.lblLoanPurpose.Size = new System.Drawing.Size(95, 15);
            this.lblLoanPurpose.TabIndex = 6;
            this.lblLoanPurpose.Text = "Purpose of Loan:";
            // 
            // numLoanTenure
            // 
            this.numLoanTenure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numLoanTenure.Location = new System.Drawing.Point(20, 150);
            this.numLoanTenure.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numLoanTenure.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numLoanTenure.Name = "numLoanTenure";
            this.numLoanTenure.Size = new System.Drawing.Size(330, 23);
            this.numLoanTenure.TabIndex = 17;
            this.numLoanTenure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLoanTenure.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblLoanTenure
            // 
            this.lblLoanTenure.AutoSize = true;
            this.lblLoanTenure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanTenure.Location = new System.Drawing.Point(17, 130);
            this.lblLoanTenure.Name = "lblLoanTenure";
            this.lblLoanTenure.Size = new System.Drawing.Size(142, 15);
            this.lblLoanTenure.TabIndex = 4;
            this.lblLoanTenure.Text = "Loan Tenure (in months):";
            // 
            // numLoanAmount
            // 
            this.numLoanAmount.DecimalPlaces = 2;
            this.numLoanAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numLoanAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLoanAmount.Location = new System.Drawing.Point(20, 95);
            this.numLoanAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numLoanAmount.Name = "numLoanAmount";
            this.numLoanAmount.Size = new System.Drawing.Size(330, 23);
            this.numLoanAmount.TabIndex = 16;
            this.numLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmount.Location = new System.Drawing.Point(17, 75);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(81, 15);
            this.lblLoanAmount.TabIndex = 2;
            this.lblLoanAmount.Text = "Loan Amount:";
            // 
            // cmbLoanType
            // 
            this.cmbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLoanType.FormattingEnabled = true;
            this.cmbLoanType.Location = new System.Drawing.Point(20, 45);
            this.cmbLoanType.Name = "cmbLoanType";
            this.cmbLoanType.Size = new System.Drawing.Size(330, 23);
            this.cmbLoanType.TabIndex = 15;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanType.Location = new System.Drawing.Point(17, 25);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(63, 15);
            this.lblLoanType.TabIndex = 0;
            this.lblLoanType.Text = "Loan Type:";
            // 
            // frmRequestLoan
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 651);
            this.Controls.Add(this.grpLoanDetails);
            this.Controls.Add(this.grpFinancialInfo);
            this.Controls.Add(this.grpPersonalInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRequestLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loan Application Form";
            this.Load += new System.EventHandler(this.frmRequestLoan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpFinancialInfo.ResumeLayout(false);
            this.grpFinancialInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyIncome)).EndInit();
            this.grpLoanDetails.ResumeLayout(false);
            this.grpLoanDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanTenure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanAmount)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblNID;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPermanentAddress;
        private System.Windows.Forms.TextBox txtPermanentAddress;
        private System.Windows.Forms.Label lblPresentAddress;
        private System.Windows.Forms.TextBox txtPresentAddress;
        private System.Windows.Forms.GroupBox grpFinancialInfo;
        private System.Windows.Forms.Label lblMonthlyIncome;
        private System.Windows.Forms.NumericUpDown numMonthlyIncome;
        private System.Windows.Forms.Label lblIncomeSource;
        private System.Windows.Forms.ComboBox cmbIncomeSource;
        private System.Windows.Forms.Label lblExistingLoans;
        private System.Windows.Forms.RadioButton rdbLoansNo;
        private System.Windows.Forms.RadioButton rdbLoansYes;
        private System.Windows.Forms.GroupBox grpLoanDetails;
        private System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.ComboBox cmbLoanType;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.NumericUpDown numLoanAmount;
        private System.Windows.Forms.Label lblLoanTenure;
        private System.Windows.Forms.NumericUpDown numLoanTenure;
        private System.Windows.Forms.Label lblLoanPurpose;
        private System.Windows.Forms.TextBox txtLoanPurpose;
    }
}
