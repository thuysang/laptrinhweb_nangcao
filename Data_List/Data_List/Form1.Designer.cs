namespace Data_List
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
            label1 = new Label();
            label2 = new Label();
            lsbClass = new ListBox();
            lsvStudent = new ListView();
            studentID = new ColumnHeader();
            name = new ColumnHeader();
            classIDRow = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 93);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "List of Classes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(537, 71);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 0;
            label2.Text = "List of Students";
            label2.Click += label2_Click;
            // 
            // lsbClass
            // 
            lsbClass.FormattingEnabled = true;
            lsbClass.Location = new Point(26, 146);
            lsbClass.Name = "lsbClass";
            lsbClass.Size = new Size(285, 164);
            lsbClass.TabIndex = 1;
            lsbClass.SelectedIndexChanged += lsbClass_SelectedIndexChanged;
            // 
            // lsvStudent
            // 
            lsvStudent.Columns.AddRange(new ColumnHeader[] { studentID, name, classIDRow });
            lsvStudent.FullRowSelect = true;
            lsvStudent.GridLines = true;
            lsvStudent.HideSelection = true;
            lsvStudent.Location = new Point(398, 136);
            lsvStudent.MultiSelect = false;
            lsvStudent.Name = "lsvStudent";
            lsvStudent.Scrollable = false;
            lsvStudent.Size = new Size(379, 188);
            lsvStudent.TabIndex = 2;
            lsvStudent.UseCompatibleStateImageBehavior = false;
            lsvStudent.View = View.Details;
            lsvStudent.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // studentID
            // 
            studentID.Text = "Students ID";
            studentID.Width = 120;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 100;
            // 
            // classIDRow
            // 
            classIDRow.Text = "Class ID";
            classIDRow.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsvStudent);
            Controls.Add(lsbClass);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lsbClass;
        private ListView lsvStudent;
        private ColumnHeader studentsID;
        private ColumnHeader name;
        private ColumnHeader classID;
        private ColumnHeader studentID;
        private ColumnHeader classIDRow;
    }
}
