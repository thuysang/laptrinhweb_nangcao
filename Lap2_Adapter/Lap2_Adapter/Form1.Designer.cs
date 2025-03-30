namespace Lap2_Adapter
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
            btnLoad = new Button();
            dtgStudent = new DataGridView();
            groupBox1 = new GroupBox();
            txtClassID = new TextBox();
            txtName = new TextBox();
            txtStudentID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgStudent).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(64, 39);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(234, 90);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load Table Student on DataGridView";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dtgStudent
            // 
            dtgStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStudent.Location = new Point(40, 167);
            dtgStudent.Name = "dtgStudent";
            dtgStudent.RowHeadersWidth = 51;
            dtgStudent.ShowEditingIcon = false;
            dtgStudent.Size = new Size(405, 200);
            dtgStudent.TabIndex = 1;
            dtgStudent.CellContentClick += dtgStudent_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtClassID);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(461, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 160);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(135, 127);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(175, 27);
            txtClassID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 27);
            txtName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(135, 29);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(175, 27);
            txtStudentID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 120);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 0;
            label3.Text = "Class ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID\r\n";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(467, 353);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(67, 27);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert\r\n";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(688, 353);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 27);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete\r\n";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(575, 353);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(67, 27);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update\r\n";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Controls.Add(dtgStudent);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgStudent).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoad;
        private DataGridView dtgStudent;
        private GroupBox groupBox1;
        private TextBox txtClassID;
        private TextBox txtName;
        private TextBox txtStudentID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
