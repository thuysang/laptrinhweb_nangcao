namespace ComboBox
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
            lb_doimau = new Label();
            label2 = new Label();
            cbo_color = new System.Windows.Forms.ComboBox();
            btn_doimau = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // lb_doimau
            // 
            lb_doimau.AutoSize = true;
            lb_doimau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_doimau.Location = new Point(220, 44);
            lb_doimau.Name = "lb_doimau";
            lb_doimau.Size = new Size(301, 28);
            lb_doimau.TabIndex = 0;
            lb_doimau.Text = "Chào mừng bạn đến với Thsan";
            lb_doimau.UseMnemonic = false;
            lb_doimau.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 140);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Chọn màu";
            // 
            // cbo_color
            // 
            cbo_color.FormattingEnabled = true;
            cbo_color.Items.AddRange(new object[] { "Yellow", "Red", "Blue", "Black" });
            cbo_color.Location = new Point(267, 132);
            cbo_color.Name = "cbo_color";
            cbo_color.Size = new Size(254, 28);
            cbo_color.TabIndex = 2;
            // 
            // btn_doimau
            // 
            btn_doimau.Location = new Point(205, 234);
            btn_doimau.Name = "btn_doimau";
            btn_doimau.Size = new Size(82, 33);
            btn_doimau.TabIndex = 3;
            btn_doimau.Text = "Đổi màu";
            btn_doimau.UseVisualStyleBackColor = true;
            btn_doimau.Click += button1_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(462, 234);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(82, 33);
            btn_thoat.TabIndex = 3;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(btn_doimau);
            Controls.Add(cbo_color);
            Controls.Add(label2);
            Controls.Add(lb_doimau);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_doimau;
        private Label label2;
        private System.Windows.Forms.ComboBox cbo_color;
        private Button btn_doimau;
        private Button btn_thoat;
    }
}
