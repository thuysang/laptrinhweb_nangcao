using System.Windows.Forms;

namespace DateTimerPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy";
        }
    }
}
