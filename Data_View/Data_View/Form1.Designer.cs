namespace Data_View
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
            lb = new Label();
            txtEnterClassID = new TextBox();
            btnViewClass = new Button();
            lbClass = new Label();
            lbName = new Label();
            lbYear = new Label();
            txtClassID = new TextBox();
            txtClassName = new TextBox();
            txtYear = new TextBox();
            btnViewStudent = new Button();
            lsvStudent = new ListView();
            studentID = new ColumnHeader();
            name = new ColumnHeader();
            classID = new ColumnHeader();
            SuspendLayout();
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(37, 55);
            lb.Name = "lb";
            lb.Size = new Size(99, 20);
            lb.TabIndex = 0;
            lb.Text = "Enter Class ID";
            // 
            // txtEnterClassID
            // 
            txtEnterClassID.Location = new Point(153, 52);
            txtEnterClassID.Name = "txtEnterClassID";
            txtEnterClassID.Size = new Size(242, 27);
            txtEnterClassID.TabIndex = 1;
            // 
            // btnViewClass
            // 
            btnViewClass.Location = new Point(42, 104);
            btnViewClass.Name = "btnViewClass";
            btnViewClass.Size = new Size(273, 44);
            btnViewClass.TabIndex = 2;
            btnViewClass.Text = "View in detail";
            btnViewClass.UseVisualStyleBackColor = true;
            btnViewClass.Click += btnViewClass_Click;
            // 
            // lbClass
            // 
            lbClass.AutoSize = true;
            lbClass.Location = new Point(62, 202);
            lbClass.Name = "lbClass";
            lbClass.Size = new Size(61, 20);
            lbClass.TabIndex = 3;
            lbClass.Text = "Class ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(62, 247);
            lbName.Name = "lbName";
            lbName.Size = new Size(86, 20);
            lbName.TabIndex = 3;
            lbName.Text = "Class Name";
            lbName.Click += label1_Click;
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new Point(62, 290);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(37, 20);
            lbYear.TabIndex = 3;
            lbYear.Text = "Year";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(168, 199);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(197, 27);
            txtClassID.TabIndex = 4;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(168, 244);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(197, 27);
            txtClassName.TabIndex = 4;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(168, 287);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(197, 27);
            txtYear.TabIndex = 4;
            // 
            // btnViewStudent
            // 
            btnViewStudent.Location = new Point(465, 102);
            btnViewStudent.Name = "btnViewStudent";
            btnViewStudent.Size = new Size(285, 46);
            btnViewStudent.TabIndex = 5;
            btnViewStudent.Text = "View of List Students";
            btnViewStudent.UseVisualStyleBackColor = true;
            btnViewStudent.Click += btnViewStudent_Click;
            // 
            // lsvStudent
            // 
            lsvStudent.Columns.AddRange(new ColumnHeader[] { studentID, name, classID });
            lsvStudent.FullRowSelect = true;
            lsvStudent.GridLines = true;
            lsvStudent.HideSelection = true;
            lsvStudent.Location = new Point(454, 184);
            lsvStudent.Name = "lsvStudent";
            lsvStudent.Size = new Size(313, 149);
            lsvStudent.TabIndex = 6;
            lsvStudent.UseCompatibleStateImageBehavior = false;
            lsvStudent.View = View.Details;
            lsvStudent.SelectedIndexChanged += lsvStudent_SelectedIndexChanged;
            // 
            // studentID
            // 
            studentID.Text = "Student ID";
            studentID.Width = 90;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 150;
            // 
            // classID
            // 
            classID.Text = "Class ID";
            classID.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsvStudent);
            Controls.Add(btnViewStudent);
            Controls.Add(txtYear);
            Controls.Add(txtClassName);
            Controls.Add(txtClassID);
            Controls.Add(lbYear);
            Controls.Add(lbName);
            Controls.Add(lbClass);
            Controls.Add(btnViewClass);
            Controls.Add(txtEnterClassID);
            Controls.Add(lb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb;
        private TextBox txtEnterClassID;
        private Button btnViewClass;
        private Label lbClass;
        private Label lbName;
        private Label lbYear;
        private TextBox txtClassID;
        private TextBox txtClassName;
        private TextBox txtYear;
        private Button btnViewStudent;
        private ListView lsvStudent;
        private ColumnHeader studentID;
        private ColumnHeader name;
        private ColumnHeader classID;
    }
}
