﻿namespace DataQuery
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
            txtClassID = new TextBox();
            txtNumber = new TextBox();
            btnCalculate_Click = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 79);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter ClassID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 126);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 0;
            label2.Text = "Number of students";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(304, 72);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(239, 27);
            txtClassID.TabIndex = 1;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(304, 123);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(239, 27);
            txtNumber.TabIndex = 1;
            // 
            // btnCalculate_Click
            // 
            btnCalculate_Click.Location = new Point(168, 202);
            btnCalculate_Click.Name = "btnCalculate_Click";
            btnCalculate_Click.Size = new Size(394, 75);
            btnCalculate_Click.TabIndex = 2;
            btnCalculate_Click.Text = "Calculate Number of Students";
            btnCalculate_Click.UseVisualStyleBackColor = true;
            btnCalculate_Click.Click += btnCalculate_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate_Click);
            Controls.Add(txtNumber);
            Controls.Add(txtClassID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtClassID;
        private TextBox txtNumber;
        private Button btnCalculate_Click;
    }
}
