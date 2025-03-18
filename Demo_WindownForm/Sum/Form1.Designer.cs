namespace Sum
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
            label3 = new Label();
            textBox1 = new TextBox();
            txtsothunhat = new TextBox();
            txt = new Label();
            label4 = new Label();
            btntinhtong = new Button();
            btnnhaplai = new Button();
            btnthoat = new Button();
            txtsothuhai = new TextBox();
            txtketqua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 87);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 84);
            label2.Name = "label2";
            label2.Size = new Size(282, 23);
            label2.TabIndex = 1;
            label2.Text = "CHƯƠNG TRÌNH CỘNG 2 SỐ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 181);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "SỐ THỨ NHẤT";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtsothunhat
            // 
            txtsothunhat.Location = new Point(260, 178);
            txtsothunhat.Name = "txtsothunhat";
            txtsothunhat.Size = new Size(326, 27);
            txtsothunhat.TabIndex = 3;
            txtsothunhat.TextChanged += textBox1_TextChanged;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(148, 242);
            txt.Name = "txt";
            txt.Size = new Size(91, 20);
            txt.TabIndex = 2;
            txt.Text = "SỐ THỨ HAI";
            txt.Click += txt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 320);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 2;
            label4.Text = "TỔNG LÀ";
            label4.Click += txt_Click;
            // 
            // btntinhtong
            // 
            btntinhtong.Location = new Point(176, 393);
            btntinhtong.Name = "btntinhtong";
            btntinhtong.Size = new Size(113, 42);
            btntinhtong.TabIndex = 4;
            btntinhtong.Text = "TÍNH TỔNG";
            btntinhtong.UseVisualStyleBackColor = true;
            btntinhtong.Click += btntinhtong_Click;
            // 
            // btnnhaplai
            // 
            btnnhaplai.Location = new Point(373, 393);
            btnnhaplai.Name = "btnnhaplai";
            btnnhaplai.Size = new Size(94, 42);
            btnnhaplai.TabIndex = 4;
            btnnhaplai.Text = "NHẬP LẠI";
            btnnhaplai.UseVisualStyleBackColor = true;
            btnnhaplai.Click += btnnhaplai_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(553, 393);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 42);
            btnthoat.TabIndex = 4;
            btnthoat.Text = "THOÁT";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // txtsothuhai
            // 
            txtsothuhai.Location = new Point(260, 242);
            txtsothuhai.Name = "txtsothuhai";
            txtsothuhai.Size = new Size(326, 27);
            txtsothuhai.TabIndex = 3;
            txtsothuhai.TextChanged += textBox1_TextChanged;
            // 
            // txtketqua
            // 
            txtketqua.Location = new Point(260, 320);
            txtketqua.Name = "txtketqua";
            txtketqua.Size = new Size(326, 27);
            txtketqua.TabIndex = 3;
            txtketqua.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 538);
            Controls.Add(btnthoat);
            Controls.Add(btnnhaplai);
            Controls.Add(btntinhtong);
            Controls.Add(txtsothuhai);
            Controls.Add(txtketqua);
            Controls.Add(txtsothunhat);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(txt);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox textBox1;
        private TextBox txtsothunhat;
        private Label txt;
        private Label label4;
        private Button btntinhtong;
        private Button btnnhaplai;
        private Button btnthoat;
        private TextBox txtsothuhai;
        private TextBox txtketqua;
    }
}
