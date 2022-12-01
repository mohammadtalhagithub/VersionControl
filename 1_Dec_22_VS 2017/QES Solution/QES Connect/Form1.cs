using Bunifu.Framework.UI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO; // for writing text file
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QES_Connect
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn ON WS_EX_COMPOSITED
                return cp;
            }
        }

        #region Keyboard Shortcuts
        /// <summary>
        /// This function is used to trigger the keyboard shortcuts assigned by the developer.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData">Different Key combinations</param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                sc.BringToFront();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                cc.Rescan_btn_Function();
            }
            else if (keyData == (Keys.Control | Keys.O))
            {
                View_files_Method();
            }
            else if (keyData == (Keys.Alt | Keys.S))
            {
                setup_btn_Method();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        public static Form _dashboard_Loading_Form;

        public static Connect_Control _cc;

        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            Padding = new Padding(borderSize);// borderSize
            BackColor = Color.FromArgb(0, 139, 139);

            instance = this;
            
            _cc = cc;

            _Fill_Panel = Fill_Panel;
            _Main_Label = Main_Label;
            _Status_label = Status_label;
            _imageList1 = imageList1;
            _Status_PictureBox = Status_PictureBox;
            _Side_panel1 = Side_panel1;

            _connect_btn = connect_btn;
            _setup_btn = setup_btn;
            _backup_btn = backup_btn;
            _dashboard_btn = dashboard_btn;
            _graph_btn = graph_btn;
            _preferences_btn = preferences_btn;

            _dashboard_Loading_Form = dashboard_Loading_Form;
            
            _dashboard_btnIsClicked = dashboard_btnIsClicked;
        }

        public static Panel _Fill_Panel;

        public Panel fillPanel
        {
            get { return Fill_Panel; }
            set { Fill_Panel = value; }
        }

        #region Commented
        
        public static void Scaling()
        {
            Form1.instance._Scaling();
            
        }
        ///// <summary>
        ///// This is (Screen Area - TaskBar Area) in pixels.
        ///// </summary>
        //public static Rectangle area;

        //public static int working_width;

        //public static int working_height;

        public static int Xfactor;
        public static int Yfactor;

        public static int SizeX;
        public static int SizeY;

        public static int dx;
        public static int dy;

        public static int FillPanel_Width;

        private void _Scaling()
        {
            //Form myForm = new Form();
            //Screen myScreen = Screen.FromControl(myForm);
            //Rectangle area = myScreen.WorkingArea;

            ResponsiveClass.working_width = ResponsiveClass.area.Width; // Developed at 1366
            ResponsiveClass.working_height = ResponsiveClass.area.Height; // Developed at 738

            Xfactor = 20; // ~ 1366/30 = 45.53333 = Xfactor
            Yfactor = 25; // ~ 738/30 = 24.6 = Yfactor

            SizeX = ResponsiveClass.working_width - ResponsiveClass.working_width / Xfactor;
            SizeY = ResponsiveClass.working_height - ResponsiveClass.working_height / Yfactor;


            if (ResponsiveClass.working_width > 1366)// And working height = 1032 of 1080
            {
                if (ResponsiveClass.working_height >= 1000 && ResponsiveClass.working_height <= 1032)
                {
                    //Page_Title_Label.ForeColor = Color.Red;


                }
            }

            //ScalingClass scalingclass_Object = new ScalingClass();

            Size = new Size(SizeX, SizeY);
            MaximumSize = new Size(SizeX, SizeY);
            MinimumSize = new Size(SizeX, SizeY);

            dx = (ResponsiveClass.working_width - Width) / 2;
            dy = (ResponsiveClass.working_height - Height) / 2;

            StartPosition = FormStartPosition.Manual;
            Left = dx;
            Top = dy;
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            
            //----------- <Form Scaling> --------------//
            try
            {
                _Scaling();

                //button1.Text = fillPanel.Width.ToString();//Fill_Panel.Width.ToString();
                FillPanel_Width = fillPanel.Width;
            }
            catch (Exception)
            {

                //throw;
            }
            //Form myForm = new Form();
            //Screen myScreen = Screen.FromControl(myForm);
            //Rectangle area = myScreen.WorkingArea;

            //int working_width = area.Width; // Developed at 1366
            //int working_height = area.Height; // Developed at 738

            //int Xfactor = 20; // ~ 1366/30 = 45.53333 = Xfactor
            //int Yfactor = 25; // ~ 738/30 = 24.6 = Yfactor

            //int SizeX = working_width - working_width / Xfactor;
            //int SizeY = working_height - working_height / Yfactor;

            //if (working_width == 1920)//1032
            //{
            //    if (working_height >= 1000 && working_height <= 1032)
            //    {
            //        //Page_Title_Label.ForeColor = Color.Red;
            //    }
            //}

            //Size = new Size(SizeX, SizeY);
            //MaximumSize = new Size(SizeX, SizeY);
            //MinimumSize = new Size(SizeX, SizeY);

            //int dx = (working_width - Width) / 2;
            //int dy = (working_height - Height) / 2;

            //StartPosition = FormStartPosition.Manual;
            //Left = dx;
            //Top = dy;

            //float formNewWidth;
            //float formNewHeight;

            //float scaleX = ((float)formNewWidth / formBaseWidth);
            //float scaleY = ((float)formNewHeight / formBaseHeight);
            //this.Scale(new SizeF(scaleX, scaleY));

            //----------- </Form Scaling> --------------//

            Title_PicBx.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources/connect_page.png"));

            Status_PictureBox.Image = imageList1.Images[0];

            foreach (var screen in Screen.AllScreens)
            {
                if (Screen.PrimaryScreen.Bounds.Width < 1366 || Screen.PrimaryScreen.Bounds.Height < 768)
                {
                    //this.Size.Width = new //.Size = new System.Drawing.Size(262, 651);
                    //this.ClientSize = new System.Drawing.Size(1300, 651);
                }
            }
            // Calling the created method

            addUserControl(sc);
            //addUserControl(Setup_Control.instance);

            addUserControl(bc);

            addUserControl(dc);

            addUserControl(gc);

            addUserControl(pc);

            addUserControl(cc);

            cc.BringToFront();

            Status_label.Text = "Disconnected";
            //Page_Title_Label.Location = new Point(295, 5);//(480, 6);
            Page_Title_Label.Text = "Connect";

            ////Status_PictureBox.Image = imageList1.Images[1];
            //pictureBox1.Image = imageList1.Images[4];
            //connect_btn.Iconimage = imageList1.Images[3];
            //setup_btn.Iconimage = imageList1.Images[8];
            //backup_btn.Iconimage = imageList1.Images[6];

            //await Task.Delay(5000);
            //Process.Start(@"CP2102 driver (1)\CP210x_VCP_Windows\CP210xVCPInstaller_x64.exe");

            Anim_Timer.Start();
        }


        private int borderSize = 1;
        //private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized
        //because it takes into account the size of the title bar and borders.

        public static BunifuFlatButton _connect_btn;
        public static BunifuFlatButton _setup_btn;
        public static BunifuFlatButton _backup_btn;
        public static BunifuFlatButton _dashboard_btn;
        public static BunifuFlatButton _graph_btn;
        public static BunifuFlatButton _preferences_btn;





        protected override void WndProc(ref Message m)
        {

            const int WM_NCCALCSIZE = 0x0083;// Remove border && keep snap window
            const int WM_SYSCOMMAND = 0x0112;
            //const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            //const int SC_RESTORE = 0xF120; //Restore form (Before)
            if (m.Msg == WM_NCCALCSIZE)// && m.WParam.ToInt32() == 1) // 1 means true || 0 means false
            {
                return;
            }

            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                //int wParam = (m.WParam.ToInt32() & 0xFFF0);

                //if (wParam == SC_MINIMIZE)  //Before
                //    formSize = this.ClientSize;
                //if (wParam == SC_RESTORE)// Restored form(Before)
                //    this.Size = formSize;
            }

            base.WndProc(ref m);
        }


        public static Form1 instance;

        public static Label _Main_Label;
        public static Label _Status_label;
        public static ImageList _imageList1;
        public static PictureBox _Status_PictureBox;
        public static Panel _Side_panel1;

        public PictureBox inst_Status_PictureBox;
        //public ImageList inst_imageList1;
        //public Label inst_Status_label;

        private void addUserControl(UserControl userControl)
        {
            Fill_Panel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        #region Objects of User_Controls
        /// <summary>
        /// Connect_Control Object.
        /// </summary>
        Connect_Control cc = new Connect_Control();
        Setup_Control sc = new Setup_Control();
        Backup_Control bc = new Backup_Control();
        Dashboard_Control dc = new Dashboard_Control();
        Graph_Control gc = new Graph_Control();
        Preferences_Control pc = new Preferences_Control();

        #endregion

        //Drag Form
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Top_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// If SerialPort.IsOpen() is true >>> pass these arguments ( string title, int imageindex, string serialport_write )
        /// </summary>
        /// <param name="title">Page Title to be displayed on button click </param>
        /// <param name="imageindex">Index of the Image to be displayed on the left of Page Title.</param>
        /// <param name="write_string">String to be written by [ SerialPort.Write ] function.</param>
        private void ButtonClick_if(string title, int imageindex, string write_string)
        {
            Page_Title_Label.Text = title;

            //pictureBox1.Image = imageList1.Images[imageindex];

            Connect_Control._SenderComboBox.Text = write_string;
            Connect_Control._Sender_btn.PerformClick();
        }

        /// <summary>
        /// If SerialPort is not open >>> pass these arguments ( BunifuFlatButton btn )
        /// </summary>
        /// <param name="btn"></param>
        private void ButtonClick_else_if(BunifuFlatButton btn)
        {
            MyMessageBox.ShowMessage("Device is  not connected...!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btn.Activecolor = Color.FromArgb(0, 139, 139);
        }

        private void BC_ldngPic_false()
        {
            Backup_Control._loading_picBox.Enabled = false;
            Backup_Control._loading_picBox.Visible = false;
        }


        bool connect_btn_IsClicked = false; // declaration

        private void connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dashboard_btnIsClicked = false;
                connect_btn_IsClicked = true; // assignment

                if (connect_btn_IsClicked) // application
                {

                }

                BC_ldngPic_false();

                if (Connect_Control.PortIsOpen == true) //Status_label.Text == "Connected"
                {
                    connect_btn.Normalcolor = Color.FromArgb(0, 100, 104);
                    setup_btn.Normalcolor = Color.DarkCyan;
                    backup_btn.Normalcolor = Color.DarkCyan;
                    dashboard_btn.Normalcolor = Color.DarkCyan;
                    graph_btn.Normalcolor = Color.DarkCyan;
                    preferences_btn.Normalcolor = Color.DarkCyan;

                    cc.BringToFront();
                    
                    Title_PicBx.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources/connect_page.png"));


                    Show_Tiles = false;
                    ButtonClick_if("Connect", 4, "$500:startconnect");// 480, 6, 4, "$500:startconnect");
                }
                else if (Connect_Control.PortIsOpen == false)
                {
                    ButtonClick_else_if(connect_btn);
                    cc.BringToFront();


                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        //public delegate void Del(string message);
        // Create a method for a delegate.
        public void setup_btn_Method()
        {
            try
            {

                BC_ldngPic_false();
                dashboard_btnIsClicked = false;

                if (Connect_Control.PortIsOpen == true)
                {
                    connect_btn.Normalcolor = Color.DarkCyan;
                    setup_btn.Normalcolor = Color.FromArgb(0, 100, 104);
                    backup_btn.Normalcolor = Color.DarkCyan;
                    dashboard_btn.Normalcolor = Color.DarkCyan;
                    graph_btn.Normalcolor = Color.DarkCyan;
                    preferences_btn.Normalcolor = Color.DarkCyan;

                    //Setup_Control.instance.BringToFront();
                    sc.BringToFront();
                    
                    Title_PicBx.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources/settings_page.png"));

                    //Anim_Timer.Start();
                    // ( string title, int left, int top, int imageindex, string serialport_write )
                    Show_Tiles = false;
                    ButtonClick_if("Setup", 9, "$501:startsetup");// 500, 6, 7, "$501:startsetup");

                }
                else if (Connect_Control.PortIsOpen == false)
                {
                    ButtonClick_else_if(setup_btn);
                    //Setup_Control.instance.BringToFront();
                    sc.BringToFront();
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void setup_btn_Click(object sender, EventArgs e)
        {
            setup_btn_Method();
            //try
            //{
            //    BC_ldngPic_false();
            //    dashboard_btnIsClicked = false;

            //    if (Connect_Control.PortIsOpen == true)
            //    {
            //        connect_btn.Normalcolor = Color.DarkCyan;
            //        setup_btn.Normalcolor = Color.FromArgb(0, 100, 104);
            //        backup_btn.Normalcolor = Color.DarkCyan;
            //        dashboard_btn.Normalcolor = Color.DarkCyan;
            //        graph_btn.Normalcolor = Color.DarkCyan;
            //        preferences_btn.Normalcolor = Color.DarkCyan;

            //        sc.BringToFront();


            //        Title_PicBx.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources/settings_page.png"));

            //        //Anim_Timer.Start();
            //        // ( string title, int left, int top, int imageindex, string serialport_write )
            //        Show_Tiles = false;
            //        ButtonClick_if("Setup", 9, "$501:startsetup");// 500, 6, 7, "$501:startsetup");

            //    }
            //    else if (Connect_Control.PortIsOpen == false)
            //    {
            //        ButtonClick_else_if(setup_btn);
            //        sc.BringToFront();
            //    }

            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show(er.Message);
            //}
        }


        private async void backup_btn_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Delay(100);
                dashboard_btnIsClicked = false;

                if (Connect_Control.PortIsOpen == true)//(Status_label.Text == "Connected")
                {


                    bc.BringToFront();

                    Page_Title_Label.Text = "Backup";

                    Title_PicBx.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources/backup_page.png"));

                    connect_btn.Normalcolor = Color.DarkCyan;
                    setup_btn.Normalcolor = Color.DarkCyan;
                    backup_btn.Normalcolor = Color.FromArgb(0, 100, 104);
                    dashboard_btn.Normalcolor = Color.DarkCyan;
                    graph_btn.Normalcolor = Color.DarkCyan;
                    preferences_btn.Normalcolor = Color.DarkCyan;

                    Backup_Control._Save_btn.Enabled = false;
                    Backup_Control._Delete_btn.Enabled = false;
                    Backup_Control._checkedListBox1.Items.Clear();
                    Backup_Control._loading_picBox.Enabled = true;
                    Backup_Control._loading_picBox.Visible = true;

                    Show_Tiles = false;
                    // ( string title, int left, int top, int imageindex, string serialport_write )
                    ButtonClick_if("Backup", 5, "$502:startbackup");
                }
                else if (Connect_Control.PortIsOpen == false)
                {
                    ButtonClick_else_if(backup_btn);
                    bc.BringToFront();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        dashboard_loading_Form dashboard_Loading_Form = new dashboard_loading_Form();

        bool dashboard_btnIsClicked = false;
        public static bool _dashboard_btnIsClicked;

        private async void dashboard_btn_Click(object sender, EventArgs e)
        {
            try
            {

                dashboard_btnIsClicked = true;

                BC_ldngPic_false();

                if (Connect_Control.PortIsOpen == true)
                {
                    Page_Title_Label.Text = "Dashboard";

                    dc.BringToFront();

                    dashboard_loading_Form._loading_picBox.Visible = true;
                    dashboard_loading_Form._loading_picBox.Enabled = true;

                    await Task.Delay(100);
                    dashboard_Loading_Form.Show();


                    dashboard_btn.Normalcolor = Color.FromArgb(0, 100, 104);
                    connect_btn.Normalcolor = Color.DarkCyan;
                    setup_btn.Normalcolor = Color.DarkCyan;
                    backup_btn.Normalcolor = Color.DarkCyan;
                    dashboard_btn.Normalcolor = Color.FromArgb(0, 100, 104);
                    graph_btn.Normalcolor = Color.DarkCyan;
                    preferences_btn.Normalcolor = Color.DarkCyan;

                    //Dashboard_Control.instance.inst_timer.Start();
                    // Dashboard_Control._Dashboard_Timer.Start();

                    Show_Tiles = true;

                    await Task.Delay(100);
                    ButtonClick_if("Dashboard", 2, "$503");
                }
                else if (Connect_Control.PortIsOpen == false)
                {
                    ButtonClick_else_if(dashboard_btn);
                    dc.BringToFront();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        /// <summary>
        /// boolean for when to show and hide the dashboard Tiles
        /// </summary>
        private bool show_Tiles = false;

        /// <summary>
        /// Public Property of show_Tiles boolean, used to trigger whenever the boolean
        /// value changes from false to true and vice-versa.
        /// </summary>
        public bool Show_Tiles
        {

            get { return show_Tiles; }
            set
            {
                if (value == show_Tiles)
                    return;

                show_Tiles = value;

                if (Show_Tiles)
                {
                    foreach (Control ctrl in Dashboard_Control._tableLayoutPanel1.Controls)
                    {
                        ctrl.Visible = false;
                    }

                    Dashboard_Control._tableLayoutPanel1.Visible = false;
                }
                else if (Show_Tiles == false)
                {
                    foreach (Control ctrl in Dashboard_Control._tableLayoutPanel1.Controls)
                    {
                        ctrl.Visible = false;

                    }
                    Dashboard_Control._tableLayoutPanel1.Visible = false;

                }
            }
        }

        private void graph_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dashboard_btnIsClicked = false;

                BC_ldngPic_false();

                if (Connect_Control.PortIsOpen == true)
                {
                    gc.BringToFront();
                    // ( string title, int left, int top, int imageindex, string serialport_write )
                    Show_Tiles = false;
                    ButtonClick_if("Graphs", 4, "$504:startgraph");// 480, 6, 4, "$504:startgraph");

                    connect_btn.Normalcolor = Color.DarkCyan;
                    setup_btn.Normalcolor = Color.DarkCyan;
                    backup_btn.Normalcolor = Color.DarkCyan;
                    dashboard_btn.Normalcolor = Color.DarkCyan;
                    graph_btn.Normalcolor = Color.FromArgb(0, 100, 104);
                    preferences_btn.Normalcolor = Color.DarkCyan;
                }
                else if (Connect_Control.PortIsOpen == false)
                {
                    ButtonClick_else_if(graph_btn);
                    gc.BringToFront();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        public static Button _backup_btn_2;

        private void preferences_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dashboard_btnIsClicked = false;

                BC_ldngPic_false();

                if (Connect_Control.PortIsOpen == true)
                {
                    pc.BringToFront();
                    // ( string title, int left, int top, int imageindex, string serialport_write )
                    ButtonClick_if("Preferences", 4, "$504:startpreferences");// 480, 6, 4, "$504:startgraph");
                    Show_Tiles = false;

                    connect_btn.Normalcolor = Color.DarkCyan;
                    setup_btn.Normalcolor = Color.DarkCyan;
                    backup_btn.Normalcolor = Color.DarkCyan;
                    dashboard_btn.Normalcolor = Color.DarkCyan;
                    graph_btn.Normalcolor = Color.DarkCyan;
                    preferences_btn.Normalcolor = Color.FromArgb(0, 100, 104);
                }
                else if (Connect_Control.PortIsOpen == false)
                {
                    ButtonClick_else_if(preferences_btn);
                    pc.BringToFront();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void ResizeAll(Control control, Size newSize)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();



        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:  //Maximized form (After)
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;

                //case FormWindowState.Minimized:
                //break;

                case FormWindowState.Normal: //Restored form (After)
                    if (Padding.Top != borderSize)
                    {
                        Padding = new Padding(borderSize);
                    }
                    break;
            }
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backup_btn_2_Click(object sender, EventArgs e)
        {
            try
            {
                Connect_Control._SenderComboBox.Text = null;
                Connect_Control._SenderComboBox.Text = "$502:startbackup";
                Connect_Control._Sender_btn.PerformClick();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        bool ExitBtn_IsClicked = false;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ExitBtn_IsClicked = true;

            try
            {
                string message = "Close QES Connect ?";
                string title = "Closing Promt.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;


                if (Status_label.Text == "Connected")
                {
                    Connect_Control._SenderComboBox.Text = "interrupt";
                    Connect_Control._Sender_btn.PerformClick();

                    if (ExitBtn_IsClicked == true)
                    {
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        else if (result == DialogResult.No)
                        {
                            if (dashboard_btnIsClicked == true)
                            {
                                Connect_Control._SenderComboBox.Text = "$503";
                                Connect_Control._Sender_btn.PerformClick();
                            }

                            ExitBtn_IsClicked = false;
                        }
                    }

                    else if (ExitBtn_IsClicked == false)
                    {
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();

                        }
                        else if (result == DialogResult.No)
                        {
                            //if (dashboard_btnIsClicked == true)
                            //{
                            //    Connect_Control._SenderComboBox.Text = "$503";
                            //    Connect_Control._Sender_btn.PerformClick();
                            //}

                            //ExitBtn_IsClicked = false;
                        }
                    }

                }
                else if (Status_label.Text == "Disconnected" && ExitBtn_IsClicked == true)
                {
                    #region Message Prompt
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();

                    }
                    else if (result == DialogResult.No)
                    {
                        //ExitBtn_IsClicked = false;
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string message = "Close QES Connect ?";
                string title = "Closing Promt.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;


                if (Status_label.Text == "Connected")
                {
                    Connect_Control._SenderComboBox.Text = "interrupt:";
                    Connect_Control._Sender_btn.PerformClick();

                    if (ExitBtn_IsClicked == false)
                    {
                        #region Message Prompt
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            e.Cancel = false; // Permits the closing event
                        }
                        else if (result == DialogResult.No)
                        {
                            e.Cancel = true; // Cancels the closing event

                            //if (dashboard_btnIsClicked == true)
                            //{
                            //    Connect_Control._SenderComboBox.Text = "$503";
                            //    Connect_Control._Sender_btn.PerformClick();
                            //}  
                        }
                        #endregion
                    }
                    else if (ExitBtn_IsClicked == true)
                    {
                        //#region Message Prompt
                        //DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                        //if (result == DialogResult.Yes)
                        //{
                        //    e.Cancel = false; // Permits the closing event
                        //}
                        //else if (result == DialogResult.No)
                        //{
                        //    e.Cancel = true; // Cancels the closing event

                        if (dashboard_btnIsClicked == true)
                        {
                            Connect_Control._SenderComboBox.Text = "$503";
                            Connect_Control._Sender_btn.PerformClick();
                        }
                        //}
                        //#endregion

                    }

                }
                else if (Status_label.Text == "Disconnected")
                {
                    if (ExitBtn_IsClicked == false)
                    {
                        #region Message Prompt
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            e.Cancel = false; // Permits the closing event
                        }
                        else if (result == DialogResult.No)
                        {
                            e.Cancel = true; // Cancels the closing event
                        }
                        #endregion 
                    }
                    else if (ExitBtn_IsClicked == true)
                    {
                        #region Message Prompt
                        //DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                        //if (result == DialogResult.Yes)
                        //{
                        //    e.Cancel = false; // Permits the closing event
                        //}
                        //else if (result == DialogResult.No)
                        //{
                        //    e.Cancel = true; // Cancels the closing event
                        //}
                        #endregion 
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //int count_backup = 0;

        private void timer_backup_Tick(object sender, EventArgs e)
        {
            //count_backup++;
            //if (count_backup == 2)
            //{
            //    ButtonClick_if("Backup", 295, 5, 5, "$502:startbackup");
            //    count_backup = 0;
            //    timer_backup.Stop();
            //}
        }

        //int count_dashboard = 0;

        #region View Files Region

        /// <summary>
        /// Defines the function when " View_files_btn " is Clicked
        /// </summary>
        private void View_files_Method()
        {
            try
            {
                string dir = @"C:\QES_Connect\Saved_Data";// directory path

                if (!Directory.Exists(dir)) // If directory does not exist, create it
                {
                    Directory.CreateDirectory(dir);
                }

                Process.Start(@"C:\QES_Connect\Saved_Data");
            }
            catch
            {
                MyMessageBox.ShowMessage("Directory does not exit, or \nerror opening directory !", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// View_files_btn_Click event
        /// </summary>
        /// <param name="sender">View_files_btn</param>
        /// <param name="e">Click Event</param>
        private void View_files_btn_Click(object sender, EventArgs e)
        {
            View_files_Method();
        }

        #endregion

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\QES_Connect\Saved_Data");
        }

        int Anim_count;
        private async void Anim_Timer_Tick(object sender, EventArgs e)
        {
            await Task.Delay(50);
            Anim_count++;

            Anim_pictureBox.Left += 2;

            if (Anim_count == 10)
            {
                Anim_Timer.Stop();
                Anim_count = 0;
            }
        }

        private void btn_Exit_MouseEnter(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.FromArgb(150, 17, 35);
        }

        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.FromArgb(150, 17, 35);
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.DarkCyan;
        }

        private void Title_PicBx_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Page_Title_Label_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Fill_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Connect_Control._SenderComboBox.Text = "gg";
            Connect_Control.SenderButtonClickMethod();
        }
    }
}
