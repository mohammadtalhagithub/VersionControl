using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO.Ports;// for serial communication
using System.Threading.Tasks;
using System.Threading;
using System.Text;
using System.Timers;
//using Tulpep.NotificationWindow;

namespace QES_Connect
{
    public partial class Connect_Control : UserControl
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
        
        public Button Show_btn
        {
            get { return show_btn; }
            set { show_btn = value; }
        }

        /// <summary>
        /// Declaring static Class "instance" helps calling an instance (non-static) method 
        /// without explicitly creating an Object of a class by [ClassName Obj = new ClassName()];.
        /// </summary>
        public static Connect_Control instance;

        public static ComboBox _SenderComboBox;
        public static Button _Sender_btn;
        public static TextBox _Receive_txtbx;
        //public static PictureBox _CornerLogo;


        Label fileName_label = new Label();

        /// <summary>
        /// Constructor of Connect_Control class, used to initialize a new instance/object
        /// of Connect_Control class at time of its creation. Here, it takes zero arguments
        /// inside parenthesis.
        /// </summary>
        public Connect_Control()
        {
            InitializeComponent();

            instance = this;

            _Sender_btn = Sender_btn;
            _SenderComboBox = SenderComboBox;
            _COMcomboBox = COMcomboBox;
            _loading_pictureBox = loading_pictureBox;
            //_CornerLogo = CornerLogo;
            //_fileName_label = fileName_label;

            hide_panel.Size = new Size(181, 100);
        }


        #region Connected Popup

        //PopupNotifier popup = new PopupNotifier();

        //popup.HeaderColor = Color.FromArgb(38, 224, 127);
        //popup.BodyColor = Color.FromArgb(38, 224, 127);

        //popup.TitleText = "QES Connect";
        //popup.TitleColor = Color.FromArgb(255, 255, 255);
        //popup.TitleFont = new Font("Verdana", 18);//, FontStyle.Bold);

        //popup.ContentText = "Port Connected.";
        //popup.ContentColor = Color.FromArgb(255, 255, 255);
        //popup.ContentFont = new Font("Verdana", 20);//, FontStyle.Bold);

        //popup.Image = Image.FromFile(@"Resources\white tick.png");
        //popup.ImageSize = new Size(50, 50);

        //popup.Popup();

        #endregion

        int ResponseCounter;
        public int _ResponseCounter
        {
            get { return ResponseCounter; }
            set { ResponseCounter = value; }
        }

        private void ResponseTimer_TickEvent(object source, ElapsedEventArgs e)
        {
            ResponseCounter++;

            if (ResponseCounter <= 20 && responseReceived == true && PortIsOpen == true)
            {
                ResponseCounter = 0;
                try
                {

                    //Cross-thread operation not valid: Control 'loading_pictureBox accessed from a
                    //thread other than the thread it was created on.

                    loading_pictureBox.Visible = false;
                    //loading_pictureBox.Enabled = false;
                    responseReceived = false;
                }
                catch
                {
                    responseReceived = false;
                    loading_pictureBox.Visible = false;
                }

                disconnect_btn.Normalcolor = Color.FromArgb(180, 0, 0);

                progressBar1.Value = 100;

                Form1._Status_label.Text = "Connected";
                Form1._Status_PictureBox.Image = Form1._imageList1.Images[1];
                disconnect_btn.BringToFront();
                Save_Info_btn.Enabled = true;

                statusLabel.ForeColor = Color.LimeGreen;
                statusLabel.Text = "✔";

                DevTypeLabel.ForeColor = Color.FromArgb(31, 32, 32);
                ProdIdLabel.ForeColor = Color.FromArgb(31, 32, 32);
                SNOLabel.ForeColor = Color.FromArgb(31, 32, 32);
                dateTimeLabel.ForeColor = Color.FromArgb(31, 32, 32);
                saveTimeLabel.ForeColor = Color.FromArgb(31, 32, 32);
                sendTimeLabel.ForeColor = Color.FromArgb(31, 32, 32);
                BattHealthLabel.ForeColor = Color.FromArgb(31, 32, 32);


                
                ResponseTimer.Stop();
                responseReceived = false;
            }
            else if (ResponseCounter > 20 && responseReceived == false && PortIsOpen == true)
            {
                ResponseCounter = 0;
                try
                {
                    loading_pictureBox.Visible = false;

                    ResponseTimer.Stop();
                    responseReceived = false;

                    COMcomboBox.Text = null;
                    COMcomboBox.Items.Clear();

                    MyMessageBox.ShowMessage("No Response Received...!\nMake sure that Device is \n connected and working properly",
                        "Communication Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (MySerialPort.IsOpen)
                    {
                        MySerialPort.Close();
                    }
                }
                catch (Exception)
                {

                    
                }
            }
        }

        /// <summary>
        /// If response is received as (@:connect), "responseReceived" boolean is made true,
        /// otherwise it remains false"
        /// </summary>
        private bool responseReceived = false;

        /// <summary>
        /// Public Property of bool " responseReceived "
        /// </summary>
        

        

        /// <summary>
        /// TimerResponse is to define the response time for making first 
        /// connection with the device. If response is received as (@:connect), "ResponseReceived" boolean
        /// is made true, otherwise it becomes false"
        /// </summary>
        System.Timers.Timer ResponseTimer = new System.Timers.Timer();

        /// <summary>
        /// width of Connect_Control
        /// </summary>
        //int X;
        /// <summary>
        /// width of bunifuCards
        /// </summary>
        //int x;


        //int dx;

        private async void Connect_Control_Load(object sender, EventArgs e)
        {
            try
            {
                if (ResponsiveClass.working_width >= 1920)
                {
                    bunifuCards1.Width = Form1.FillPanel_Width / 2;//800; // 1582/800 = 1.97 => 800 = 1582/~2
                    bunifuCards2.Width = Form1.FillPanel_Width / 2;//800;

                    //bunifuCards1.Left = bunifuCards1.Left - Form1.FillPanel_Width / 20;//78; // 1582/78 = 20.28 => 78 = 1582/~20
                    bunifuCards1.Left = (this.Width - bunifuCards1.Width) / 2;//bunifuCards1.Left - Form1.FillPanel_Width / 20;//78; // 1582/78 = 20.28 => 78 = 1582/~20
                    bunifuCards2.Left = (this.Width - bunifuCards2.Width) / 2;//bunifuCards2.Left - Form1.FillPanel_Width / 20;//78;

                    //bunifuCards1.Location = new Point(panel2.Width / 2 - bunifuCards1.Width / 2, panel2.Height / 2 - bunifuCards1.Height / 2
                }
                if (ReScan_btn.Enabled == true)
                {
                    ReScan_btn.Cursor = Cursors.Hand;
                }
                else if (ReScan_btn.Enabled == false)
                {
                    ReScan_btn.Cursor = Cursors.No;
                }

                ResponseTimer.Elapsed += new ElapsedEventHandler(ResponseTimer_TickEvent);
                ResponseTimer.Interval = 100;
                
                COM_Settings_label.Left = bunifuCards1.Left;
                Admin_btn.Left = bunifuCards2.Left;

                //Scanning_label.Top = 172;
                BAUDcomboBox.Items.AddRange(new object[]
                {   //-------- Baud Rates Array -------//
                    "300",
                    "1200",
                    "2400",
                    "4800",
                    "9600",
                    "19200",
                    "38400",
                    "57600",
                    "74880",
                    "115200",
                    "230400",
                    "250000",
                    "500000",
                    "1000000"
                });

                BAUDcomboBox.SelectedIndex = 4;
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "❌";

                loading_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                COMcomboBox.Text = "";
                COMcomboBox.Items.Clear();

                Scanning_label.ForeColor = Color.CadetBlue;

                FetchAvailablePorts();
                await Task.Delay(10);

                for (int i = 0; i < 2; i++)
                {
                    Scanning_label.Text = "Scanning For Available Ports";
                    await Task.Delay(250);

                    Scanning_label.Text = "Scanning For Available Ports.";
                    await Task.Delay(250);

                    Scanning_label.Text = "Scanning For Available Ports..";
                    await Task.Delay(250);

                    Scanning_label.Text = "Scanning For Available Ports...";
                    await Task.Delay(250);
                }

                COMcomboBox.SelectedIndex = 0;

                Scanning_label.Text = "Port Detected.";
                await Task.Delay(1500);

                Scanning_label.Visible = false;
                ReScan_btn.Enabled = true;

            }
            catch
            {
                //Scanning_label.Left = 458;
                Scanning_label.ForeColor = Color.Red;
                Scanning_label.Text = "No Port(s) Found...!";

                ReScan_btn.Enabled = true;
                ReScan_btn.Cursor = Cursors.Hand;

                //MessageBox.Show("No Device Detected...!", "Error Occurred...!",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);

                MyMessageBox.ShowMessage("No Device Detected...!\n\nMake sure that USB is connected.", "Error finding the port...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FetchAvailablePorts()
        {
            try
            {
                String[] ports = SerialPort.GetPortNames();// ports is local string var
                COMcomboBox.Items.AddRange(ports);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MySerialPort_Properties()
        {
            try
            {
                MySerialPort.PortName = COMcomboBox.Text.ToString();
                MySerialPort.BaudRate = Convert.ToInt32(BAUDcomboBox.Text);
                MySerialPort.Parity = Parity.None;
                MySerialPort.DataBits = 8;
                MySerialPort.StopBits = StopBits.One;
                MySerialPort.ReadBufferSize = 200000000;
                MySerialPort.DataReceived += MySerialPort_DataReceived;
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        

        public string str;

        /// <summary>
        /// click event of Connect Device button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private string MyReceivedData;

        public string _MyReceivedData
        {
            set { MyReceivedData = value; }
            get { return MyReceivedData; }
            
        }
        //public string _MyReceivedData
        //{
        //    get
        //    {
        //        return MyReceivedData;
        //    }

        //    set
        //    {
        //        MyReceivedData = value;
        //        OnVarChange?.Invoke();
        //    }
        //}

        //public event System.Action OnVarChange;

        public void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                MyReceivedData = MySerialPort.ReadLine(); // MyReceivedData = MySerialPort.ReadLine();
                Invoke(new Action(ProcessingData));
            }
            catch
            {

            }
        }
        
        /// <summary>
        /// bool [fileWrite] = true if (MyReceivedData.IndexOf("SavedData") > -1)
        /// </summary>
        private bool fileWrite = false;

        public bool FileWrite
        {
            get { return fileWrite; }
            set
            {
                fileWrite = value;
            }
        }

        public async void Rescan_btn_Function()
        {
            try
            {
                await Task.Delay(10);

                ReScan_btn.Enabled = false;
                ReScan_btn.Cursor = Cursors.No;

                //Scanning_label.Left = 423;
                Scanning_label.ForeColor = Color.CadetBlue;
                Scanning_label.Visible = true;

                for (int i = 0; i < 3; i++)
                {
                    Scanning_label.Text = "Scanning For Available Ports";
                    await Task.Delay(100);

                    Scanning_label.Text = "Scanning For Available Ports.";
                    await Task.Delay(100);

                    Scanning_label.Text = "Scanning For Available Ports..";
                    await Task.Delay(100);

                    Scanning_label.Text = "Scanning For Available Ports...";
                    await Task.Delay(100);
                }

                COMcomboBox.Text = "";
                COMcomboBox.Items.Clear();
                FetchAvailablePorts();
                COMcomboBox.SelectedIndex = 0;

                //Scanning_label.Left = 468;
                Scanning_label.Text = "Port Detected.";
                await Task.Delay(1500);

                Scanning_label.Visible = false;

                ReScan_btn.Enabled = true;
                ReScan_btn.Cursor = Cursors.Hand;
            }
            catch
            {
                //Scanning_label.Left = 458;
                Scanning_label.ForeColor = Color.Red;
                Scanning_label.Text = "No Port(s) Found...!";

                ReScan_btn.Enabled = true;
                Connect_btn.Enabled = false;
                ReScan_btn.Cursor = Cursors.Hand;

                MyMessageBox.ShowMessage("No Device Detected...!\nMake sure that USB\nis connected.", "Scanning Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// bool [openFolder] determines when to open the Saved_Data folder.
        /// </summary>
        bool openFolder = false;

        /// <summary>
        /// bool [PortIsOpen] = true if (MySerialPort.IsOpen() == true), i.e., when MySerialPort.Open() is executed successfully.
        /// </summary>
        public static bool PortIsOpen = false;

        /// <summary>
        /// 
        /// </summary>
        private string fileString;

        public string fileName;

        private void ProcessingData()
        {
            try
            {
                if (MyReceivedData.IndexOf("/*") > -1)
                {
                    fileName_label.Text = MyReceivedData.Substring(MyReceivedData.IndexOf("/*")
                                          + 2, MyReceivedData.IndexOf("*/") - 2);

                    fileName = MyReceivedData.Substring(MyReceivedData.IndexOf("/*")
                               + 2, MyReceivedData.IndexOf("*/") - 2);
                }

                if (MyReceivedData.IndexOf("@:connect") > -1)
                {
                    responseReceived = true;   
                }
                else if (MyReceivedData.IndexOf("@:disconnect") > -1)
                {
                    timer_disconnect.Start();

                    responseReceived = false;
                    //MyReceivedData = null;
                }

                else if (MyReceivedData.IndexOf("SavedData") > -1)
                {
                    fileWrite = true;

                    Form1._dashboard_Loading_Form.Show();
                    

                }
                else if (MyReceivedData.IndexOf("done") > -1)
                {
                    fileWrite = false;

                    Form1._dashboard_Loading_Form.Hide();
                }

                else if (MyReceivedData.IndexOf("AllDone") > -1) //Alldone
                {
                    openFolder = true;
                }

                /*
                if (openFolder)
                {
                    string message = "Files Saved Successfully...\nView saved files ?";
                    string title = "Files Saved...";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);

                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(@"C:\QES_Connect\Saved_Data"); // @"C:\QES_Connect\Saved_Data\"
                        openFolder = false;
                    }

                    else if (result == DialogResult.No)
                    {
                        openFolder = false;
                    }

                }*/

                if (openFolder)
                {
                    DialogResult result;
                    result = MyMessageBox.ShowMessage("Files Saved Successfully...\nView saved files ?", "Files Saved...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(@"C:\QES_Connect\Saved_Data");
                        openFolder = false;
                    }
                    else
                    {
                        openFolder = false;
                    }
                }

                if (fileWrite == true) // (Backup_Control._indices_btn_bool == true)
                {
                    fileString += MyReceivedData;

                    string dir = @"C:\QES_Connect\Saved_Data";// directory path

                    if (!Directory.Exists(dir)) // If directory does not exist, create it
                    {
                        Directory.CreateDirectory(dir);
                    }

                    string textfileName = fileName_label.Text;

                    TextWriter MyTxtFile = new StreamWriter(@"C:\QES_Connect\Saved_Data\" + textfileName + ".txt"); //"C:\\demo\\demo.txt"
                    TextWriter MyCSVFile = new StreamWriter(@"C:\QES_Connect\Saved_Data\" + textfileName + ".csv"); // 
                    TextWriter MyXLSFile = new StreamWriter(@"C:\QES_Connect\Saved_Data\" + textfileName + ".xls");

                    str = fileString.Replace("*C", "" + "" + "\x02DA" + "");
                    str = str.Replace("SavedData", null);
                    str = str.Trim();

                    string csvString = fileString.Replace("*C", "\x02DA");
                    
                    MyTxtFile.Write(str);
                    MyCSVFile.Write(csvString);
                    MyXLSFile.Write(str);

                    MyTxtFile.Close();
                    MyCSVFile.Close();
                    MyXLSFile.Close();
                }

                if (fileWrite == false)
                {
                    fileString = null;
                }

                string caseNo = MyReceivedData.Substring(MyReceivedData.IndexOf('@')
                                + 1, MyReceivedData.IndexOf(':') - 1);

                if (caseNo == "")
                {
                    caseNo = "0";
                }
                int _caseNo = int.Parse(caseNo);

                // removing start and end characters now
                MyReceivedData = MyReceivedData.Remove(0, MyReceivedData.IndexOf(':') + 1);

                switch (_caseNo)
                {
                    case 500: // Device Info Data
                        {
                            try
                            {
                                #region Device_Info

                                if (MyReceivedData.IndexOf("devtype") > -1)
                                {
                                    //dev_picBx.SizeMode = PictureBoxSizeMode.StretchImage;
                                    MyReceivedData = MyReceivedData.Remove(0, MyReceivedData.IndexOf(':') + 1);

                                    Dev_Type_Textbox1.Text = MyReceivedData;


                                    #region Device_Picture
                                    //if (MyReceivedData.IndexOf("IAQ") > -1)
                                    //{
                                    //    //dev_picBx.BackgroundImage = imageList1.Images[0]; //.Image = imageList1.Images[4];
                                    //    //imageList1.ImageSize = new Size(AutoScaleFactor);
                                    //    //dev_picBx.Size = new Size(200, 150);
                                    //}
                                    //else if (MyReceivedData.IndexOf("WMS") > -1)
                                    //{

                                    //    //dev_picBx.BackgroundImage = imageList1.Images[1];
                                    //} 
                                    #endregion
                                    MyReceivedData = null;

                                }

                                else if (MyReceivedData.IndexOf("pid") > -1)
                                {
                                    MyReceivedData = MyReceivedData.Remove(0, MyReceivedData.IndexOf(':') + 1);
                                    Prod_ID_Textbox2.Text = MyReceivedData;
                                    MyReceivedData = null;
                                }
                                else if (MyReceivedData.IndexOf("ser") > -1)
                                {
                                    MyReceivedData = MyReceivedData.Remove(0, MyReceivedData.IndexOf(':') + 1);
                                    S_No_Textbox3.Text = MyReceivedData;
                                    MyReceivedData = null;
                                }
                                else if (MyReceivedData.IndexOf("dtime") > -1)
                                {
                                    MyReceivedData = MyReceivedData.Remove(0, MyReceivedData.IndexOf(':') + 1);
                                    Date_Time_Textbox4.Text = MyReceivedData;
                                    MyReceivedData = null;
                                }

                                else if (MyReceivedData.IndexOf("savet") > -1)
                                {
                                    MyReceivedData = MyReceivedData.Remove(0, MyReceivedData.IndexOf(':') + 1);
                                    Save_T_Textbox5.Text = MyReceivedData + " mins";
                                    MyReceivedData = null;
                                }

                                else if (MyReceivedData.IndexOf("sendt") > -1)
                                {
                                    MyReceivedData = MyReceivedData.Remove(0, MyReceivedData.IndexOf(':') + 1);
                                    Send_T_Textbox6.Text = MyReceivedData + " mins";
                                    MyReceivedData = null;
                                }

                                else if (MyReceivedData.IndexOf("batvolt") > -1)
                                {
                                    MyReceivedData = MyReceivedData.Remove(0, MyReceivedData.IndexOf(':') + 1);
                                    Battery_Volt_Textbox7.Text = MyReceivedData + " V";
                                    MyReceivedData = null;

                                }
                                #endregion

                                #region bat_Icon

                                else if (MyReceivedData.IndexOf("batperc") > -1)
                                {
                                    MyReceivedData = MyReceivedData.Remove(0, MyReceivedData.IndexOf(':') + 1);
                                    MyReceivedData = MyReceivedData.Remove(MyReceivedData.IndexOf('.'));
                                    bat_icon_perc.Text = MyReceivedData;

                                    int batValue = int.Parse(MyReceivedData);
                                    battery_ProgressBar.Value = batValue;
                                    if (batValue <= 29)
                                    {
                                        battery_ProgressBar.ProgressColor = Color.FromArgb(255, 0, 0);
                                    }
                                    else if (batValue >= 30 && batValue <= 59)
                                    {
                                        battery_ProgressBar.ProgressColor = Color.FromArgb(238, 187, 67);
                                    }
                                    else if (batValue >= 60 && batValue <= 100)
                                    {
                                        battery_ProgressBar.ProgressColor = Color.FromArgb(23, 161, 165);
                                    }

                                    MyReceivedData = null;
                                }

                                #endregion

                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                            }
                            break;
                        }

                    case 502:
                        {
                            try
                            {
                                Backup_Control._Backup_textBox.Text = MyReceivedData;//.ToString();

                                MyReceivedData = null;
                            }
                            catch
                            {

                                //MessageBox.Show(err.Message);
                            }


                            break;
                        }
                    case 503: // Dashboard Data
                        {
                            try
                            {
                                //Dashboard_Control.instance.inst_ToDashboard_Label.Text += MyReceivedData.ToString();
                                Dashboard_Control._Dashboard_textBox.Text = MyReceivedData.ToString();

                                MyReceivedData = null;
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);

                            }
                            break;
                        }
                }

            }
            catch
            {
                
            }

        }

        public Color disabled_Color = Color.FromArgb(192, 192, 192);

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            MyReceivedData = null;
            connect_btn_Clicked = false;

            try
            {
                MySerialPort.Write("$:stop");
                loading_pictureBox.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void COMcomboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (COMcomboBox.Text.IndexOf("COM") > -1)
                {
                    Connect_btn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// private void Method, includes - MySerialPort.Write(SenderComboBox.Text.ToString()),
        /// followed by SenderComboBox.Text = null;
        /// </summary>
        private void Sender_Button_Click_Method()
        {
            try
            {
                MySerialPort.Write(SenderComboBox.Text.ToString());
                SenderComboBox.Text = null;
            }
            catch
            {
                MessageBox.Show("Device is  not connected...!", "Error...",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// Public "static" Method of Sender_Button_Click_Method; inclues - MySerialPort.Write(SenderComboBox.Text.ToString()), 
        /// followed by SenderComboBox.Text = null;
        /// </summary>
        public static void SenderButtonClickMethod()
        {
            Form1._cc.Sender_Button_Click_Method();
            Connect_Control.instance.Sender_Button_Click_Method(); // declaring "instance" helps calling an instance method 
            //without creating an actual Object of a class.
        }

        private void Sender_btn_Click(object sender, EventArgs e)
        {
            Sender_Button_Click_Method();
        }

        int count = 0;
        private void Admin_btn_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                click_timer.Start();
                //MessageBox.Show("click_timer started");
            }
            
            if (count == 5)
            {
                bool isOpen = false;
                foreach (Form f in Application.OpenForms)
                    try
                    {
                        {
                            if (f.Text == "Password_Form")
                            {
                                isOpen = true;
                                f.BringToFront();
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                if (isOpen == false)
                {
                    try
                    {
                        Password_Form pf = new Password_Form();
                        pf.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                count = 0;
            }
        }

        int click_duration;
        private void click_timer_Tick(object sender, EventArgs e)
        {
            click_duration++;

            if (click_duration >= 2)
            {
                count = 0;
                click_timer.Stop();
                
                click_duration = 0;
            }
        }

        int counter_Discon = 0;

        private void DisConnect_Method()
        {
            /*
            try
            {
                counter_Discon++;
                if (counter_Discon >= 1)
                {

                    try
                    {
                        if (MySerialPort.IsOpen)
                        {
                            MySerialPort.Close();
                            PortIsOpen = false;

                            progressBar1.Value = 0;
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                    Form1._Status_label.Text = "Disconnected";
                    Form1._Status_PictureBox.Image = Form1._imageList1.Images[0];
                    connect_btn.BringToFront();
                    loading_pictureBox.Visible = false;

                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "❌";

                    counter_Discon = 0;

                    timer_disconnect.Stop();
                    //MessageBox.Show(counter_Discon.ToString());

                    Dev_Type_Textbox1.Text = null;
                    Prod_ID_Textbox2.Text = null;
                    S_No_Textbox3.Text = null;
                    Date_Time_Textbox4.Text = null;
                    Save_T_Textbox5.Text = null;
                    Send_T_Textbox6.Text = null;
                    Battery_Volt_Textbox7.Text = null;

                    //progressBar1.Value = 0;
                    battery_ProgressBar.Value = 0;
                    bat_icon_perc.Text = "NA";

                    #region Disabled Label Color

                    DevTypeLabel.ForeColor = disabled_Color;
                    ProdIdLabel.ForeColor = disabled_Color;
                    SNOLabel.ForeColor = disabled_Color;
                    dateTimeLabel.ForeColor = disabled_Color;
                    saveTimeLabel.ForeColor = disabled_Color;
                    sendTimeLabel.ForeColor = disabled_Color;
                    BattHealthLabel.ForeColor = disabled_Color;

                    #endregion

                    #region DisConnected Popup

                    //PopupNotifier popup = new PopupNotifier();

                    //popup.HeaderColor = Color.FromArgb(255, 50, 50);
                    //popup.BodyColor = Color.FromArgb(255, 50, 50);

                    //popup.TitleText = "QES Connect";
                    //popup.TitleColor = Color.FromArgb(255, 255, 255);
                    //popup.TitleFont = new Font("Verdana", 18);//, FontStyle.Bold);

                    //popup.ContentText = "Port Disconnected";
                    //popup.ContentColor = Color.FromArgb(255, 255, 255);
                    //popup.ContentFont = new Font("Verdana", 20);//, FontStyle.Bold);

                    //popup.Image = Image.FromFile(@"Resources\white cross.png");
                    //popup.ImageSize = new Size(60, 60);

                    //popup.Popup();// show
                    #endregion

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        public Button _SerialWriteCheck_Btn
        {
            set { SerialWriteCheck_Btn = value; }
            get { return SerialWriteCheck_Btn; }

        }

        private void timer_disconnect_Tick(object sender, EventArgs e)
        {
            try
            {
                counter_Discon++;
                if (counter_Discon >= 1)
                {

                    try
                    {
                        if (MySerialPort.IsOpen)
                        {
                            MySerialPort.Close();
                            PortIsOpen = false;

                            progressBar1.Value = 0;
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                    Form1._Status_label.Text = "Disconnected";
                    Form1._Status_PictureBox.Image = Form1._imageList1.Images[0];

                    Connect_btn.BringToFront();
                    Save_Info_btn.Enabled = false;

                    loading_pictureBox.Visible = false;

                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "❌";

                    counter_Discon = 0;

                    timer_disconnect.Stop();
                    //MessageBox.Show(counter_Discon.ToString());

                    Dev_Type_Textbox1.Text = null;
                    Prod_ID_Textbox2.Text = null;
                    S_No_Textbox3.Text = null;
                    Date_Time_Textbox4.Text = null;
                    Save_T_Textbox5.Text = null;
                    Send_T_Textbox6.Text = null;
                    Battery_Volt_Textbox7.Text = null;

                    //progressBar1.Value = 0;
                    battery_ProgressBar.Value = 0;
                    bat_icon_perc.Text = "NA";

                    #region Disabled Label Color

                    DevTypeLabel.ForeColor = disabled_Color;
                    ProdIdLabel.ForeColor = disabled_Color;
                    SNOLabel.ForeColor = disabled_Color;
                    dateTimeLabel.ForeColor = disabled_Color;
                    saveTimeLabel.ForeColor = disabled_Color;
                    sendTimeLabel.ForeColor = disabled_Color;
                    BattHealthLabel.ForeColor = disabled_Color;

                    #endregion

                    #region DisConnected Popup

                    //PopupNotifier popup = new PopupNotifier();

                    //popup.HeaderColor = Color.FromArgb(255, 50, 50);
                    //popup.BodyColor = Color.FromArgb(255, 50, 50);

                    //popup.TitleText = "QES Connect";
                    //popup.TitleColor = Color.FromArgb(255, 255, 255);
                    //popup.TitleFont = new Font("Verdana", 18);//, FontStyle.Bold);

                    //popup.ContentText = "Port Disconnected";
                    //popup.ContentColor = Color.FromArgb(255, 255, 255);
                    //popup.ContentFont = new Font("Verdana", 20);//, FontStyle.Bold);

                    //popup.Image = Image.FromFile(@"Resources\white cross.png");
                    //popup.ImageSize = new Size(60, 60);

                    //popup.Popup();// show
                    #endregion

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Receive_txtbx_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string dir = @"C:\QES_Connect\Saved_Data";// directory address


            //    // If directory does not exist, create it
            //    if (!Directory.Exists(dir))
            //    {
            //        Directory.CreateDirectory(dir);
            //    }

            //    string textfileName = "Backup_Data";

            //    TextWriter MyTxtFile = new StreamWriter("C:\\QES_Connect\\Saved_Data\\" + textfileName + ".txt"); //"C:\\demo\\demo.txt"
            //    TextWriter MyCSVFile = new StreamWriter("C:\\QES_Connect\\Saved_Data\\" + textfileName + ".csv");

            //    MyTxtFile.Write(Receive_txtbx.Text);
            //    MyCSVFile.Write(Receive_txtbx.Text);


            //    MyTxtFile.Close();
            //    MyCSVFile.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Save_Info_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //string dir = @"C:\QES_Connect\Saved_Data";// directory address
                string folderPath = "C:\\QES_Connect\\Saved_Data\\";

                // If directory does not exist, create it
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // File Name
                int fileCount = Directory.GetFiles("C:\\QES_Connect\\Saved_Data").Length;
                string PDFfileName = "Dev_Info_" + (fileCount + 1) + "_" + ".pdf";

                #region iTextSharp_PDF

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(folderPath + PDFfileName, FileMode.Create));
                /*
                 OR
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(folderPath, FileMode.OpenOrCreate));
                 */
                doc.Open();
                
                Chunk ch1 = new Chunk("Quick Engineering Solutions", FontFactory.GetFont("Calibri", 25, 1));
                ch1.Font.Color = new BaseColor(0, 139, 139);
                Phrase ph1 = new Phrase();
                ph1.Add(ch1);

                Chunk ch2 = new Chunk("\n\nDevice Information", FontFactory.GetFont("Calibri", 20, 1));
                ch2.Font.Color = new BaseColor(0, 0, 50);
                Phrase ph2 = new Phrase();
                ph1.Add(ch2);

                Paragraph p3 = new Paragraph("\n");
                Paragraph p4 = new Paragraph(fileString);// fileString

                PdfPTable pdftable1 = new PdfPTable(2); // 2 is no of columns
                pdftable1.DefaultCell.Padding = 5;
                pdftable1.WidthPercentage = 90;
                pdftable1.DefaultCell.BorderWidth = 0.5f;

                pdftable1.AddCell(new Phrase("Device Type", FontFactory.GetFont("Calibri", 15, 1))); // 1 means BOLD
                pdftable1.AddCell(new Phrase(Dev_Type_Textbox1.Text));

                pdftable1.AddCell(new Phrase("Product ID", FontFactory.GetFont("Calibri", 15, 1)));
                pdftable1.AddCell(new Phrase(Prod_ID_Textbox2.Text));

                pdftable1.AddCell(new Phrase("S. No.", FontFactory.GetFont("Calibri", 15, 1)));
                pdftable1.AddCell(new Phrase(S_No_Textbox3.Text));

                pdftable1.AddCell(new Phrase("Date - Time", FontFactory.GetFont("Calibri", 15, 1)));
                pdftable1.AddCell(new Phrase(Date_Time_Textbox4.Text));

                pdftable1.AddCell(new Phrase("Save - Interval", FontFactory.GetFont("Calibri", 15, 1)));
                pdftable1.AddCell(new Phrase(Save_T_Textbox5.Text));

                pdftable1.AddCell(new Phrase("Send - Interval", FontFactory.GetFont("Calibri", 15, 1)));
                pdftable1.AddCell(new Phrase(Send_T_Textbox6.Text));

                pdftable1.AddCell(new Phrase("Battery Voltage", FontFactory.GetFont("Calibri", 15, 1)));
                pdftable1.AddCell(new Phrase(Battery_Volt_Textbox7.Text));

                //string imageURL = @"F:\Talha\C#\backup\17_Sep_2022_VS 2017\VS 2017\QES Solution\QES Connect\Resources\QES_Connect_LOGO.png";

                
                string imageURL = @"Resources\QES_Connect_LOGO.png";


                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(imageURL);

                png.ScaleToFit(60f, 60f);
                png.SpacingBefore = 7f;
                png.SpacingAfter = 3f;
                png.Alignment = Element.ALIGN_RIGHT;

                doc.Add(png);

                doc.Add(ph1);
                doc.Add(ph2);
                doc.Add(p3);
                doc.Add(pdftable1);

                doc.Add(new Paragraph(testString));
                doc.Add(p4);

                doc.Close();
                //MessageBox.Show("PDF saved successfully" + "\n" + @"In - C:\QES_Connect\Saved_Data");

                string message = "Device Info. Saved Successfully...\nView Saved File ?";
                string title = "Info. Saved...";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@"C:\QES_Connect\Saved_Data"); // @"C:\QES_Connect\Saved_Data\"
                    openFolder = false;
                }

                else if (result == DialogResult.No)
                {
                    openFolder = false;
                }
                /*
                DialogResult result = MyMessageBox.ShowMessage("Device Info. Saved Successfully...\nView Saved File ?", "File(s) Saved.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //System.Diagnostics.Process.Start(@"C:\QES_Connect\Saved_Data"); // @"C:\QES_Connect\Saved_Data\"
                    //openFolder = false;
                }

                else if (result == DialogResult.No)
                {
                    openFolder = false;
                }
                */
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string testString = @"QES Solution,QES Connect,Resources,QES_Connect";

        public static ComboBox _COMcomboBox;
        
        private void show_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Form1._Fill_Panel.Width + ", " + Form1._Fill_Panel.Height);
            MessageBox.Show(Width.ToString() + ", " + Height.ToString());
        }

        //private string name; // field

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int age;

        private async void RescanMethod()
        {
            try
            {
                await Task.Delay(10);

                ReScan_btn.Enabled = false;
                ReScan_btn.Cursor = Cursors.No;

                //Scanning_label.Left = 423;
                Scanning_label.ForeColor = Color.CadetBlue;
                Scanning_label.Visible = true;

                for (int i = 0; i < 3; i++)
                {
                    Scanning_label.Text = "Scanning For Available Ports";
                    await Task.Delay(100);

                    Scanning_label.Text = "Scanning For Available Ports.";
                    await Task.Delay(100);

                    Scanning_label.Text = "Scanning For Available Ports..";
                    await Task.Delay(100);

                    Scanning_label.Text = "Scanning For Available Ports...";
                    await Task.Delay(100);
                }

                COMcomboBox.Text = "";
                COMcomboBox.Items.Clear();
                FetchAvailablePorts();
                COMcomboBox.SelectedIndex = 0;

                //Scanning_label.Left = 468;
                Scanning_label.Text = "Port Detected.";
                await Task.Delay(1500);

                Scanning_label.Visible = false;

                ReScan_btn.Enabled = true;
                ReScan_btn.Cursor = Cursors.Hand;
            }
            catch
            {
                //Scanning_label.Left = 458;
                Scanning_label.ForeColor = Color.Red;
                Scanning_label.Text = "No Port(s) Found...!";

                ReScan_btn.Enabled = true;
                Connect_btn.Enabled = false;
                ReScan_btn.Cursor = Cursors.Hand;

                MyMessageBox.ShowMessage("No Device Detected...!\nMake sure that USB\nis connected.", "Scanning Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void ReScan_btn_Click(object sender, EventArgs e)
        {
            //int delay = 100;
            try
            {
                await Task.Delay(10);

                ReScan_btn.Enabled = false;
                ReScan_btn.Cursor = Cursors.No;

                //Scanning_label.Left = 423;
                Scanning_label.ForeColor = Color.CadetBlue;
                Scanning_label.Visible = true;

                for (int i = 0; i < 3; i++)
                {
                    Scanning_label.Text = "Scanning For Available Ports";
                    await Task.Delay(100);

                    Scanning_label.Text = "Scanning For Available Ports.";
                    await Task.Delay(100);

                    Scanning_label.Text = "Scanning For Available Ports..";
                    await Task.Delay(100);

                    Scanning_label.Text = "Scanning For Available Ports...";
                    await Task.Delay(100);
                }

                COMcomboBox.Text = "";
                COMcomboBox.Items.Clear();
                FetchAvailablePorts();
                COMcomboBox.SelectedIndex = 0;

                //Scanning_label.Left = 468;
                Scanning_label.Text = "Port Detected.";
                await Task.Delay(1500);

                Scanning_label.Visible = false;

                ReScan_btn.Enabled = true;
                ReScan_btn.Cursor = Cursors.Hand;
            }
            catch
            {
                //Scanning_label.Left = 458;
                Scanning_label.ForeColor = Color.Red;
                Scanning_label.Text = "No Port(s) Found...!";

                ReScan_btn.Enabled = true;
                Connect_btn.Enabled = false;
                ReScan_btn.Cursor = Cursors.Hand;

                MyMessageBox.ShowMessage("No Device Detected...!\nMake sure that USB\nis connected.", "Scanning Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PortIsOpen == true)
            {
                MessageBox.Show("PortIsOpen = true");
            }
            else if (PortIsOpen == false)
            {
                MessageBox.Show("PortIsOpen = false");
            }
        }

        private void ReScan_btn_MouseEnter(object sender, EventArgs e)
        {
            if (ReScan_btn.Enabled == true)
            {
                ReScan_btn.Cursor = Cursors.Hand;
            }
            else if (ReScan_btn.Enabled == false)
            {
                ReScan_btn.Cursor = Cursors.No;
            }
        }





        //static async Task fetchavailableports()
        //{
        //    try
        //    {
        //        String[] ports = SerialPort.GetPortNames();// ports is local string var
        //        _COMcomboBox.Items.AddRange(ports);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private int _myProperty = 0;
        //public int MyProperty
        //{
        //    get { return _myProperty; }
        //    set
        //    {
        //        _myProperty = value;
        //        if (_myProperty == 10)
        //        {
        //            MessageBox.Show("_myProperty value is now " + _myProperty.ToString());
        //        }
        //    }
        //}

        //private int _age;

        ////#1
        //public event System.EventHandler AgeChanged;

        ////#2
        //protected virtual void OnAgeChanged()
        //{
        //    if (AgeChanged != null) AgeChanged(this, EventArgs.Empty);
        //}

        //public int Age
        //{
        //    get
        //    {
        //        return _age;
        //    }

        //    set
        //    {
        //        //#3
        //        _age = value;
        //        OnAgeChanged();
        //    }
        //}


        

        private void Connect_btn_Click_1(object sender, EventArgs e)
        {
            

        }


        bool SerialWriteExecuted = false;

        private void SerialWrite_Method (string WriteToSerial)
        {
            try
            {
                MySerialPort.Write(WriteToSerial);
                SerialWriteExecuted = true;

                MessageBox.Show(SerialWriteExecuted.ToString() + ", Writing Successful");
            }
            catch
            {
                SerialWriteExecuted = false;
                MessageBox.Show(SerialWriteExecuted.ToString() + ", Writing Unsuccessful");
            }
        }

        private void SerialWriteCheck_Btn_Click(object sender, EventArgs e)
        {
            SerialWrite_Method("Write Something");

            Thread t1 = new Thread(LoadingPicBox_true);
            t1.Start();
        }

        bool connect_btn_Clicked = false;

        public static PictureBox _loading_pictureBox;

        public static void LoadingPicBox_true ()
        {
            //PictureBox PicBx = new PictureBox();
            //PicBx.Size = new Size(100,100);
            //PicBx.Left = 500;
            //PicBx.Top = 500;
            //PicBx.BackColor = Color.Red;
            //PicBx.Visible = true;
            MessageBox.Show("t1 thread");
            
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            
            //Thread t2 = new Thread(func2);
            //Thread t3 = new Thread(func3);

            connect_btn_Clicked = true;
            
            if (connect_btn_Clicked)
            {
                try
                {
                    MySerialPort_Properties();

                    MySerialPort.Open();

                    if (MySerialPort.IsOpen == true)
                    {
                        PortIsOpen = true;

                        MySerialPort.Write("$:start");
                        ResponseTimer.Start();

                        //loading_pictureBox.Image = imageList1.Images[2];

                        

                        //Thread t = Thread.CurrentThread;
                        //t.Name = "Main Thread";
                        //MessageBox.Show("Current Thread is: " + Thread.CurrentThread.Name);

                        loading_pictureBox.Visible = true;
                    }

                    else if (MySerialPort.IsOpen == false)
                    {
                        PortIsOpen = false;

                        MessageBox.Show("Not Connected");
                    }
                }
                catch
                {
                    //MessageBox.Show("COM settings not selected \n Please Select COM settings and try again...!", "Error...!");

                    //MyMessageBox.ShowMessage("COM settings not selected \n Please Select COM settings and try again...!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    DialogResult result;
                    result = MyMessageBox.ShowMessage("COM settings not selected \n Please Select COM settings and try again...!", "Error...",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                    {
                        Connect_btn.BackColor = Color.FromArgb(0, 139, 139);
                        Connect_btn.Enabled = false;
                    }
                } 
            }
        }

        private void check_label_Click(object sender, EventArgs e)
        {

        }
    }
}
