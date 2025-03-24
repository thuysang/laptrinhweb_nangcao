using System.Data;
using System.Data.SqlClient;

namespace Data_StudentInfor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        string stringconn = "Data Source=THUYSANG\\MSSQLSERVER02;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;";

        private void Form1_Load(object sender, EventArgs e)
        {
            Data_StudentInfor();
        }

        private void Data_StudentInfor()
        {
            lvwStudent.Items.Clear();
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("Select * from Student", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malop = reader.GetString(2);
                ListViewItem item = lvwStudent.Items.Add(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malop);
            }
            conn.Close();
        }

        int result = -1;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "insert into Student (StudentID, Name, ClassID)" +
            "values (@StudentID, @Name, @ClassID)";
            SqlParameter parameter1 = new SqlParameter("@StudentID", txtStudentID.Text);
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@Name", txtName.Text);
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("ClassID", txtClassID.Text);
            command.Parameters.Add(parameter3);
            try
            {
                result = command.ExecuteNonQuery();
                //using ExecuteNonQuery if SQL command-insert, update or delete 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInsert a record failed!!!!!!");
            }
            if (result > 0)
            {
                Data_StudentInfor();
            }
        }

        private void lvwStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwStudent.SelectedItems.Count > 0)
            {
                txtStudentID.Text = lvwStudent.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lvwStudent.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lvwStudent.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"update Student set Name = '{txtName.Text}', ClassID='{txtClassID.Text}' where StudentID = '{txtStudentID.Text}'", conn);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Update failed!!!!!");
            }
            if (result > 0)
            {
                Data_StudentInfor();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"delede from Student where StudentID = '{txtStudentID.Text}'", conn); 
            
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Update failed!!!!!");
            }          
            if (result > 0)
            {
                Data_StudentInfor();
                txtStudentID.Text = "";
                txtName.Text = "";
                txtClassID.Text = "";
            }
        }
    }

}
