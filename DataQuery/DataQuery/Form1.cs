using System.Data;
using System.Data.SqlClient;

namespace DataQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string stringconn = "Data Source=THUYSANG\\MSSQLSERVER02;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True"; 
        SqlConnection conn = null;

        private void btnCalculate_Click_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand($"Select count(*) from STUDENT Where ClassID = '{txtClassID.Text}'", conn); 
            //Execute the sql command to return a value 
            int result = (int)command.ExecuteScalar();
            txtNumber.Text = result.ToString();
            conn.Close();
        }
    }
}
