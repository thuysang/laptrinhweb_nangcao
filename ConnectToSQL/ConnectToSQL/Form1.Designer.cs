namespace ConnectToSQL
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
            btnConnect = new Button();
            btnDisconnect = new Button();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(88, 86);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(252, 68);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect to SQL Server Database";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(88, 213);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(252, 68);
            btnDisconnect.TabIndex = 0;
            btnDisconnect.Text = "Disconnect\r\n";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnect;
        private Button btnDisconnect;
    }
}
