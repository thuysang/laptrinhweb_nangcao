namespace frmMain
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
        }
        public void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&File");
            ToolStripMenuItem menuNew = new ToolStripMenuItem("&New");
            ToolStripMenuItem menuOpen = new ToolStripMenuItem("&Open");
            ToolStripSeparator separator = new ToolStripSeparator(); ;
            ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem menuAbout = new ToolStripMenuItem("&About");
            ToolStripMenuItem menuViewAbout = new ToolStripMenuItem("&View About");
            // mainMenu 
            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, menuAbout });
            // menuFile 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuNew, menuOpen, separator, menuExit });
            // mnuAbout 
            menuAbout.DropDownItems.AddRange(new ToolStripItem[] { menuViewAbout });
            // mnuNew 
            menuNew.ShortcutKeys = (Keys)((Keys.Control | Keys.N));
            // mnuOpen 
            menuOpen.ShortcutKeys = (Keys)((Keys.Control | Keys.O));
            // mnuExit 
            menuExit.ShortcutKeys = (Keys)((Keys.Alt | Keys.X));
            menuExit.Click += new EventHandler(mnuExit_Click);
            //mnuViewAbout 
            menuViewAbout.ShortcutKeys = Keys.F1;
            menuViewAbout.Click += new EventHandler(mnuViewDetail_Click);
        }//end CreateMyMainMenu 
         //Click EventHandler 
        private void mnuViewDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Windows Forms Application with .NET", "About");
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}
