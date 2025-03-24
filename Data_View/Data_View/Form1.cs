
using System.Data;
using System.Data.SqlClient;

namespace Data_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string stringconn = "Data Source=THUYSANG\\MSSQLSERVER02;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True";
        SqlConnection conn = null;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewClass_Click(object sender, EventArgs e)
        {
            txtClassID.Text = "";
            txtClassName.Text = "";
            txtYear.Text = "";
            if (conn == null)
                conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"select * from Class where ClassID='{txtEnterClassID.Text}'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtClassID.Text = reader.GetString(0);
                txtClassName.Text = reader.GetString(1);
                txtYear.Text = reader.GetInt32(2).ToString();
            }
            conn.Close();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            lsvStudent.Items.Clear();
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"select * from Student where ClassID='{txtEnterClassID.Text}'", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);
                ListViewItem item = new ListViewItem(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classID);
                lsvStudent.Items.Add(item);
            }
            conn.Close();
        }

        private void lsvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
