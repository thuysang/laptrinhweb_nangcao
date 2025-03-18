namespace RichTextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            CreaRichTextBox();
        }
        public void CreaRichTextBox()
        {
            RichTextBox rtbData = new RichTextBox();
            rtbData.Dock = DockStyle.Fill;
            rtbData.Find("Richtexbox", RichTextBoxFinds.MatchCase);
            rtbData.SelectionFont = new Font("Verdata", 12, FontStyle.Bold);
            rtbData.SelectionColor = Color.Pink;
            rtbData.SaveFile("MyData.rft", RichTextBoxStreamType.RichText);
            this.Controls.Add(rtbData);
        }
    }
}
