using System.Data;
using System.Data.SqlClient;

namespace Data_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string stringconn = "Data Source=THUYSANG\\MSSQLSERVER02;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True";
        SqlConnection conn = null;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lsbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("Select * from Class", conn);
            // Execute SQL Command 
            lsbClass.ClearSelected();
            SqlDataReader reader = command.ExecuteReader(); // Execute SQL Command 
            while (reader.Read())
            {
                string classIDRow = reader.GetString(0);
                string className = reader.GetString(1);
                int year = reader.GetInt32(2);
                string line = classIDRow + "-" + className + "-" + year.ToString();
                lsbClass.Items.Add(line);
            }
            conn.Close();
        }
        private void lbsClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudent.Items.Clear();
            if (lsbClass.SelectedIndex == -1) return;
            string line = lsbClass.SelectedItem.ToString();
            string[] array = line.Split('-');
            string classIDRow = array[0];

            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"Select * from Student where ClassID='{classID}'", conn); 
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);
                ListViewItem item = lsvStudent.Items.Add(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classIDRow);
                lsvStudent.Items.Add(item);
            }
            conn.Close();
        }
    }
}
