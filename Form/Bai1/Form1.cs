namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên của bạn là: " + txtHoTen.Text);
        }




        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Bạn vừa click chuột phải");
            }
            else if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Bạn vừa click chuột trái");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn mở ứng dụng?", "Hỏi người dùng",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                Dispose(); // Đóng ứng dụng nếu chọn Cancel
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.H)
            {
                txtHoTen.Text = "Hello Freetuts.net";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát chương trình
            }
    }
}
}