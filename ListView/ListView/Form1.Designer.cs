namespace ListView
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
            ListViewItem listViewItem1 = new ListViewItem("Tên phòng");
            ListViewItem listViewItem2 = new ListViewItem("Số lượng");
            lbThem = new Label();
            lbTenphong = new Label();
            lbSoluong = new Label();
            txtSoluong = new TextBox();
            txtTenphong = new TextBox();
            listView1 = new System.Windows.Forms.ListView();
            btnThem = new Button();
            btnXoa = new Button();
            btnXoahet = new Button();
            btnThoat = new Button();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // lbThem
            // 
            lbThem.AutoSize = true;
            lbThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThem.Location = new Point(281, 41);
            lbThem.Name = "lbThem";
            lbThem.Size = new Size(217, 28);
            lbThem.TabIndex = 0;
            lbThem.Text = "Thêm Phòng Ban Mới";
            lbThem.Click += label1_Click;
            // 
            // lbTenphong
            // 
            lbTenphong.AutoSize = true;
            lbTenphong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenphong.Location = new Point(117, 105);
            lbTenphong.Name = "lbTenphong";
            lbTenphong.Size = new Size(93, 23);
            lbTenphong.TabIndex = 1;
            lbTenphong.Text = "Tên Phòng";
            lbTenphong.Click += lbTenphong_Click;
            // 
            // lbSoluong
            // 
            lbSoluong.AutoSize = true;
            lbSoluong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoluong.Location = new Point(117, 149);
            lbSoluong.Name = "lbSoluong";
            lbSoluong.Size = new Size(160, 23);
            lbSoluong.TabIndex = 1;
            lbSoluong.Text = "Số Lượng Nhân Sự";
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(313, 149);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(341, 27);
            txtSoluong.TabIndex = 2;
            txtSoluong.TextChanged += textBox1_TextChanged;
            // 
            // txtTenphong
            // 
            txtTenphong.Location = new Point(313, 101);
            txtTenphong.Name = "txtTenphong";
            txtTenphong.Size = new Size(341, 27);
            txtTenphong.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(143, 216);
            listView1.Name = "listView1";
            listView1.Size = new Size(475, 158);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(143, 390);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(76, 38);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(292, 390);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(76, 38);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXoahet
            // 
            btnXoahet.Location = new Point(451, 390);
            btnXoahet.Name = "btnXoahet";
            btnXoahet.Size = new Size(76, 38);
            btnXoahet.TabIndex = 4;
            btnXoahet.Text = "Xóa hết";
            btnXoahet.UseVisualStyleBackColor = true;
            btnXoahet.Click += btnXoahet_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(600, 390);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(76, 38);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoahet);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(listView1);
            Controls.Add(txtTenphong);
            Controls.Add(txtSoluong);
            Controls.Add(lbSoluong);
            Controls.Add(lbTenphong);
            Controls.Add(lbThem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbThem;
        public Label lbTenphong;
        public Label lbSoluong;
        private TextBox txtSoluong;
        private TextBox txtTenphong;
        private System.Windows.Forms.ListView listView1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnXoahet;
        private Button btnThoat;
        private ColumnHeader columnHeader3;
    }
}
