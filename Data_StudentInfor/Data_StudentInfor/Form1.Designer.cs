namespace Data_StudentInfor
{
    partial class Form1
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
            lvwStudent = new ListView();
            masv = new ColumnHeader();
            hoten = new ColumnHeader();
            malop = new ColumnHeader();
            grb = new GroupBox();
            txtClassID = new TextBox();
            txtName = new TextBox();
            txtStudentID = new TextBox();
            lbClassID = new Label();
            lbName = new Label();
            lbStudentID = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            grb.SuspendLayout();
            SuspendLayout();
            // 
            // lvwStudent
            // 
            lvwStudent.Columns.AddRange(new ColumnHeader[] { masv, hoten, malop });
            lvwStudent.FullRowSelect = true;
            lvwStudent.GridLines = true;
            lvwStudent.HideSelection = true;
            lvwStudent.Location = new Point(7, 18);
            lvwStudent.Name = "lvwStudent";
            lvwStudent.ShowGroups = false;
            lvwStudent.Size = new Size(399, 425);
            lvwStudent.TabIndex = 0;
            lvwStudent.UseCompatibleStateImageBehavior = false;
            lvwStudent.View = View.Details;
            lvwStudent.SelectedIndexChanged += lvwStudent_SelectedIndexChanged;
            // 
            // masv
            // 
            masv.Text = "Class ID";
            masv.Width = 120;
            // 
            // hoten
            // 
            hoten.Text = "Name";
            hoten.Width = 120;
            // 
            // malop
            // 
            malop.Text = "Class ID";
            malop.Width = 150;
            // 
            // grb
            // 
            grb.Controls.Add(txtClassID);
            grb.Controls.Add(txtName);
            grb.Controls.Add(txtStudentID);
            grb.Controls.Add(lbClassID);
            grb.Controls.Add(lbName);
            grb.Controls.Add(lbStudentID);
            grb.Location = new Point(428, 30);
            grb.Name = "grb";
            grb.Size = new Size(363, 196);
            grb.TabIndex = 1;
            grb.TabStop = false;
            grb.Text = "Student Information";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(146, 154);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(209, 27);
            txtClassID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 27);
            txtName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(146, 48);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(209, 27);
            txtStudentID.TabIndex = 1;
            // 
            // lbClassID
            // 
            lbClassID.AutoSize = true;
            lbClassID.Location = new Point(34, 154);
            lbClassID.Name = "lbClassID";
            lbClassID.Size = new Size(61, 20);
            lbClassID.TabIndex = 0;
            lbClassID.Text = "Class ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(34, 100);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // lbStudentID
            // 
            lbStudentID.AutoSize = true;
            lbStudentID.Location = new Point(34, 50);
            lbStudentID.Name = "lbStudentID";
            lbStudentID.Size = new Size(79, 20);
            lbStudentID.TabIndex = 0;
            lbStudentID.Text = "Student ID";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(440, 263);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(71, 40);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 263);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(71, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(685, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(71, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(grb);
            Controls.Add(lvwStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grb.ResumeLayout(false);
            grb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvwStudent;
        private ColumnHeader masv;
        private ColumnHeader hoten;
        private ColumnHeader malop;
        private GroupBox grb;
        private TextBox txtClassID;
        private TextBox txtName;
        private TextBox txtStudentID;
        private Label lbClassID;
        private Label lbName;
        private Label lbStudentID;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
