using System.Data;
using System.Data.SqlClient;

namespace ConnectToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strconn = "Data Source=THUYSANG\\MSSQLSERVER02;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True";
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                MessageBox.Show("Successful connection!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server \n" + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Successful Disconnection");
            }
        }
    }
}
