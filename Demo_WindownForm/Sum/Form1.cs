namespace Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void btntinhtong_Click(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            try
            {
                so1 = double.Parse(txtsothunhat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap so thu nhat khong dung \n" + ex.Message);
            }
            try
            {
                so2 = double.Parse(txtsothunhat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap so thu hai  khong dung \n" + ex.Message);
            }

            double tong = so1 + so2;
            txtketqua.Text = tong.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtsothunhat.Select();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtsothunhat.Text = "";
            txtsothuhai.Text = "";
            txtketqua.Text = "";
        }
    }
}
