namespace CommonControls
{
    partial class Ibtitle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbEmpID = new Label();
            lbEmpName = new Label();
            lbPhone = new Label();
            lbGender = new Label();
            lbDegree = new Label();
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            mtxtPhone = new MaskedTextBox();
            gbGender = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            cboDegree = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 25);
            label1.Name = "label1";
            label1.Size = new Size(273, 76);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE DETAILS\r\n ";
            // 
            // lbEmpID
            // 
            lbEmpID.AutoSize = true;
            lbEmpID.Location = new Point(65, 120);
            lbEmpID.Name = "lbEmpID";
            lbEmpID.Size = new Size(94, 20);
            lbEmpID.TabIndex = 1;
            lbEmpID.Text = "Employee ID";
            lbEmpID.Click += IbEmpID_Click;
            // 
            // lbEmpName
            // 
            lbEmpName.AutoSize = true;
            lbEmpName.Location = new Point(65, 170);
            lbEmpName.Name = "lbEmpName";
            lbEmpName.Size = new Size(119, 20);
            lbEmpName.TabIndex = 1;
            lbEmpName.Text = "Employee Name";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(65, 219);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(50, 20);
            lbPhone.TabIndex = 1;
            lbPhone.Text = "Phone";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(65, 272);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(57, 20);
            lbGender.TabIndex = 1;
            lbGender.Text = "Gender\r\n";
            // 
            // lbDegree
            // 
            lbDegree.AutoSize = true;
            lbDegree.Location = new Point(65, 328);
            lbDegree.Name = "lbDegree";
            lbDegree.Size = new Size(58, 20);
            lbDegree.TabIndex = 1;
            lbDegree.Text = "Degree";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(257, 119);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(255, 27);
            txtEmployeeID.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(257, 163);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(255, 27);
            txtEmployeeName.TabIndex = 2;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(258, 219);
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(258, 27);
            mtxtPhone.TabIndex = 3;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rdFemale);
            gbGender.Controls.Add(rdMale);
            gbGender.Location = new Point(260, 273);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(261, 29);
            gbGender.TabIndex = 4;
            gbGender.TabStop = false;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(151, 5);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(82, 24);
            rdFemale.TabIndex = 0;
            rdFemale.Text = "Female ";
            rdFemale.TextAlign = ContentAlignment.MiddleCenter;
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Checked = true;
            rdMale.Location = new Point(27, 5);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 24);
            rdMale.TabIndex = 0;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // cboDegree
            // 
            cboDegree.AutoCompleteMode = AutoCompleteMode.Append;
            cboDegree.FormattingEnabled = true;
            cboDegree.Items.AddRange(new object[] { "Bachelor", "Engineer", "Master", "Ph. D.", "Technician" });
            cboDegree.Location = new Point(257, 328);
            cboDegree.Name = "cboDegree";
            cboDegree.Size = new Size(255, 28);
            cboDegree.Sorted = true;
            cboDegree.TabIndex = 5;
            cboDegree.Text = "---Select Degree---";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(260, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(410, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(83, 30);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Ibtitle
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboDegree);
            Controls.Add(gbGender);
            Controls.Add(mtxtPhone);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(lbDegree);
            Controls.Add(lbGender);
            Controls.Add(lbPhone);
            Controls.Add(lbEmpName);
            Controls.Add(lbEmpID);
            Controls.Add(label1);
            Name = "Ibtitle";
            Text = "Form1";
            Load += Ibtitle_Load;
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbEmpID;
        private Label lbEmpName;
        private Label lbPhone;
        private Label lbGender;
        private Label lbDegree;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private MaskedTextBox mtxtPhone;
        private GroupBox gbGender;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private ComboBox cboDegree;
        private Button btnSave;
        private Button btnCancel;
    }
}
