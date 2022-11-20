namespace QES_Connect
{
    partial class Connect_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect_Control));
            this.COM_Settings_label = new System.Windows.Forms.Label();
            this.COMcomboBox = new System.Windows.Forms.ComboBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ReScan_btn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.loading_pictureBox = new System.Windows.Forms.PictureBox();
            this.BAUDcomboBox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Connect_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.disconnect_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.Save_Info_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Dev_Type_Textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Prod_ID_Textbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.S_No_Textbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Date_Time_Textbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Save_T_Textbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Send_T_Textbox6 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Battery_Volt_Textbox7 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BattHealthLabel = new System.Windows.Forms.Label();
            this.sendTimeLabel = new System.Windows.Forms.Label();
            this.saveTimeLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.SNOLabel = new System.Windows.Forms.Label();
            this.DevTypeLabel = new System.Windows.Forms.Label();
            this.ProdIdLabel = new System.Windows.Forms.Label();
            this.Admin_btn = new System.Windows.Forms.Button();
            this.SenderComboBox = new System.Windows.Forms.ComboBox();
            this.Sender_btn = new System.Windows.Forms.Button();
            this.hide_panel = new System.Windows.Forms.Panel();
            this.MySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer_disconnect = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Scanning_label = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.click_timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.battery_ProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bat_icon_perc = new System.Windows.Forms.Label();
            this.SerialWriteCheck_Btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CornerLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading_pictureBox)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // COM_Settings_label
            // 
            this.COM_Settings_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.COM_Settings_label.AutoSize = true;
            this.COM_Settings_label.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COM_Settings_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.COM_Settings_label.Location = new System.Drawing.Point(205, 31);
            this.COM_Settings_label.Name = "COM_Settings_label";
            this.COM_Settings_label.Size = new System.Drawing.Size(124, 23);
            this.COM_Settings_label.TabIndex = 3;
            this.COM_Settings_label.Text = "COM Settings";
            // 
            // COMcomboBox
            // 
            this.COMcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.COMcomboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.COMcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMcomboBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMcomboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.COMcomboBox.FormattingEnabled = true;
            this.COMcomboBox.Location = new System.Drawing.Point(163, 30);
            this.COMcomboBox.Name = "COMcomboBox";
            this.COMcomboBox.Size = new System.Drawing.Size(121, 24);
            this.COMcomboBox.TabIndex = 0;
            this.COMcomboBox.TextChanged += new System.EventHandler(this.COMcomboBox_TextChanged);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 25;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkCyan;
            this.bunifuCards1.Controls.Add(this.panel4);
            this.bunifuCards1.Controls.Add(this.panel3);
            this.bunifuCards1.Controls.Add(this.BAUDcomboBox);
            this.bunifuCards1.Controls.Add(this.COMcomboBox);
            this.bunifuCards1.Controls.Add(this.progressBar1);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.Connect_btn);
            this.bunifuCards1.Controls.Add(this.disconnect_btn);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(208, 53);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 30;
            this.bunifuCards1.Size = new System.Drawing.Size(645, 121);
            this.bunifuCards1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.Controls.Add(this.ReScan_btn);
            this.panel4.Location = new System.Drawing.Point(488, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 90);
            this.panel4.TabIndex = 38;
            // 
            // ReScan_btn
            // 
            this.ReScan_btn.AllowClickAnimation = true;
            this.ReScan_btn.AllowTransparency = true;
            this.ReScan_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReScan_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ReScan_btn.BackgroundImage = global::QES_Connect.Properties.Resources.restart_solid;
            this.ReScan_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReScan_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ReScan_btn.BorderRadius = 15;
            this.ReScan_btn.ClickMaxOffset = 3;
            this.ReScan_btn.ClickOffset = 1;
            this.ReScan_btn.ClickSpeed = 1;
            this.ReScan_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReScan_btn.Enabled = false;
            this.ReScan_btn.Location = new System.Drawing.Point(40, 16);
            this.ReScan_btn.Name = "ReScan_btn";
            this.ReScan_btn.RippleColor = System.Drawing.Color.Blue;
            this.ReScan_btn.RippleOpacity = 0;
            this.ReScan_btn.Size = new System.Drawing.Size(60, 60);
            this.ReScan_btn.TabIndex = 40;
            this.ReScan_btn.Click += new System.EventHandler(this.ReScan_btn_Click);
            this.ReScan_btn.MouseEnter += new System.EventHandler(this.ReScan_btn_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.Controls.Add(this.statusLabel);
            this.panel3.Controls.Add(this.loading_pictureBox);
            this.panel3.Location = new System.Drawing.Point(3, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 94);
            this.panel3.TabIndex = 38;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(59, 35);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(30, 25);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "❌";
            // 
            // loading_pictureBox
            // 
            this.loading_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loading_pictureBox.Image = global::QES_Connect.Properties.Resources.blueCircle;
            this.loading_pictureBox.Location = new System.Drawing.Point(36, 7);
            this.loading_pictureBox.Name = "loading_pictureBox";
            this.loading_pictureBox.Size = new System.Drawing.Size(80, 80);
            this.loading_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading_pictureBox.TabIndex = 9;
            this.loading_pictureBox.TabStop = false;
            this.loading_pictureBox.Visible = false;
            // 
            // BAUDcomboBox
            // 
            this.BAUDcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BAUDcomboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BAUDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BAUDcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAUDcomboBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAUDcomboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BAUDcomboBox.FormattingEnabled = true;
            this.BAUDcomboBox.Location = new System.Drawing.Point(360, 30);
            this.BAUDcomboBox.Name = "BAUDcomboBox";
            this.BAUDcomboBox.Size = new System.Drawing.Size(121, 24);
            this.BAUDcomboBox.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 114);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(642, 4);
            this.progressBar1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(359, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "BAUD Rate";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(164, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available Ports";
            // 
            // Connect_btn
            // 
            this.Connect_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Connect_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Connect_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Connect_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Connect_btn.BorderRadius = 7;
            this.Connect_btn.ButtonText = "Connect Device";
            this.Connect_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Connect_btn.Enabled = false;
            this.Connect_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Connect_btn.Iconimage = null;
            this.Connect_btn.Iconimage_right = null;
            this.Connect_btn.Iconimage_right_Selected = null;
            this.Connect_btn.Iconimage_Selected = null;
            this.Connect_btn.IconMarginLeft = 0;
            this.Connect_btn.IconMarginRight = 0;
            this.Connect_btn.IconRightVisible = true;
            this.Connect_btn.IconRightZoom = 0D;
            this.Connect_btn.IconVisible = true;
            this.Connect_btn.IconZoom = 90D;
            this.Connect_btn.IsTab = false;
            this.Connect_btn.Location = new System.Drawing.Point(163, 64);
            this.Connect_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.Connect_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Connect_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Connect_btn.selected = false;
            this.Connect_btn.Size = new System.Drawing.Size(318, 42);
            this.Connect_btn.TabIndex = 2;
            this.Connect_btn.Text = "Connect Device";
            this.Connect_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Connect_btn.Textcolor = System.Drawing.Color.White;
            this.Connect_btn.TextFont = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Activecolor = System.Drawing.Color.Red;
            this.disconnect_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disconnect_btn.BackColor = System.Drawing.Color.Red;
            this.disconnect_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.disconnect_btn.BorderRadius = 7;
            this.disconnect_btn.ButtonText = "Disconnect Device";
            this.disconnect_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnect_btn.DisabledColor = System.Drawing.Color.Gray;
            this.disconnect_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.disconnect_btn.Iconimage = null;
            this.disconnect_btn.Iconimage_right = null;
            this.disconnect_btn.Iconimage_right_Selected = null;
            this.disconnect_btn.Iconimage_Selected = null;
            this.disconnect_btn.IconMarginLeft = 0;
            this.disconnect_btn.IconMarginRight = 0;
            this.disconnect_btn.IconRightVisible = true;
            this.disconnect_btn.IconRightZoom = 0D;
            this.disconnect_btn.IconVisible = true;
            this.disconnect_btn.IconZoom = 90D;
            this.disconnect_btn.IsTab = false;
            this.disconnect_btn.Location = new System.Drawing.Point(163, 64);
            this.disconnect_btn.Margin = new System.Windows.Forms.Padding(4);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Normalcolor = System.Drawing.Color.Red;
            this.disconnect_btn.OnHovercolor = System.Drawing.Color.Red;
            this.disconnect_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.disconnect_btn.selected = false;
            this.disconnect_btn.Size = new System.Drawing.Size(318, 42);
            this.disconnect_btn.TabIndex = 3;
            this.disconnect_btn.Text = "Disconnect Device";
            this.disconnect_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.disconnect_btn.Textcolor = System.Drawing.Color.White;
            this.disconnect_btn.TextFont = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 25;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DarkCyan;
            this.bunifuCards2.Controls.Add(this.Save_Info_btn);
            this.bunifuCards2.Controls.Add(this.Dev_Type_Textbox1);
            this.bunifuCards2.Controls.Add(this.Prod_ID_Textbox2);
            this.bunifuCards2.Controls.Add(this.S_No_Textbox3);
            this.bunifuCards2.Controls.Add(this.Date_Time_Textbox4);
            this.bunifuCards2.Controls.Add(this.Save_T_Textbox5);
            this.bunifuCards2.Controls.Add(this.Send_T_Textbox6);
            this.bunifuCards2.Controls.Add(this.Battery_Volt_Textbox7);
            this.bunifuCards2.Controls.Add(this.pictureBox1);
            this.bunifuCards2.Controls.Add(this.BattHealthLabel);
            this.bunifuCards2.Controls.Add(this.sendTimeLabel);
            this.bunifuCards2.Controls.Add(this.saveTimeLabel);
            this.bunifuCards2.Controls.Add(this.dateTimeLabel);
            this.bunifuCards2.Controls.Add(this.SNOLabel);
            this.bunifuCards2.Controls.Add(this.DevTypeLabel);
            this.bunifuCards2.Controls.Add(this.ProdIdLabel);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(209, 212);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 30;
            this.bunifuCards2.Size = new System.Drawing.Size(642, 419);
            this.bunifuCards2.TabIndex = 6;
            // 
            // Save_Info_btn
            // 
            this.Save_Info_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Save_Info_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Save_Info_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Save_Info_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_Info_btn.BorderRadius = 7;
            this.Save_Info_btn.ButtonText = "Save Info As PDF";
            this.Save_Info_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Info_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Save_Info_btn.Enabled = false;
            this.Save_Info_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Save_Info_btn.Iconimage = null;
            this.Save_Info_btn.Iconimage_right = null;
            this.Save_Info_btn.Iconimage_right_Selected = null;
            this.Save_Info_btn.Iconimage_Selected = null;
            this.Save_Info_btn.IconMarginLeft = 0;
            this.Save_Info_btn.IconMarginRight = 0;
            this.Save_Info_btn.IconRightVisible = true;
            this.Save_Info_btn.IconRightZoom = 0D;
            this.Save_Info_btn.IconVisible = true;
            this.Save_Info_btn.IconZoom = 90D;
            this.Save_Info_btn.IsTab = false;
            this.Save_Info_btn.Location = new System.Drawing.Point(229, 375);
            this.Save_Info_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Info_btn.Name = "Save_Info_btn";
            this.Save_Info_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.Save_Info_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Save_Info_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Save_Info_btn.selected = false;
            this.Save_Info_btn.Size = new System.Drawing.Size(185, 35);
            this.Save_Info_btn.TabIndex = 29;
            this.Save_Info_btn.Text = "Save Info As PDF";
            this.Save_Info_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_Info_btn.Textcolor = System.Drawing.Color.White;
            this.Save_Info_btn.TextFont = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Info_btn.Click += new System.EventHandler(this.Save_Info_btn_Click);
            // 
            // Dev_Type_Textbox1
            // 
            this.Dev_Type_Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Dev_Type_Textbox1.Enabled = false;
            this.Dev_Type_Textbox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dev_Type_Textbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Dev_Type_Textbox1.HintForeColor = System.Drawing.Color.Empty;
            this.Dev_Type_Textbox1.HintText = "";
            this.Dev_Type_Textbox1.isPassword = false;
            this.Dev_Type_Textbox1.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.Dev_Type_Textbox1.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.Dev_Type_Textbox1.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.Dev_Type_Textbox1.LineThickness = 2;
            this.Dev_Type_Textbox1.Location = new System.Drawing.Point(325, 28);
            this.Dev_Type_Textbox1.Margin = new System.Windows.Forms.Padding(5);
            this.Dev_Type_Textbox1.Name = "Dev_Type_Textbox1";
            this.Dev_Type_Textbox1.Size = new System.Drawing.Size(246, 41);
            this.Dev_Type_Textbox1.TabIndex = 12;
            this.Dev_Type_Textbox1.TabStop = false;
            this.Dev_Type_Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Prod_ID_Textbox2
            // 
            this.Prod_ID_Textbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Prod_ID_Textbox2.Enabled = false;
            this.Prod_ID_Textbox2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_ID_Textbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Prod_ID_Textbox2.HintForeColor = System.Drawing.Color.Empty;
            this.Prod_ID_Textbox2.HintText = "";
            this.Prod_ID_Textbox2.isPassword = false;
            this.Prod_ID_Textbox2.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.Prod_ID_Textbox2.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.Prod_ID_Textbox2.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.Prod_ID_Textbox2.LineThickness = 2;
            this.Prod_ID_Textbox2.Location = new System.Drawing.Point(325, 75);
            this.Prod_ID_Textbox2.Margin = new System.Windows.Forms.Padding(5);
            this.Prod_ID_Textbox2.Name = "Prod_ID_Textbox2";
            this.Prod_ID_Textbox2.Size = new System.Drawing.Size(246, 41);
            this.Prod_ID_Textbox2.TabIndex = 13;
            this.Prod_ID_Textbox2.TabStop = false;
            this.Prod_ID_Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // S_No_Textbox3
            // 
            this.S_No_Textbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.S_No_Textbox3.Enabled = false;
            this.S_No_Textbox3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_No_Textbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.S_No_Textbox3.HintForeColor = System.Drawing.Color.Empty;
            this.S_No_Textbox3.HintText = "";
            this.S_No_Textbox3.isPassword = false;
            this.S_No_Textbox3.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.S_No_Textbox3.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.S_No_Textbox3.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.S_No_Textbox3.LineThickness = 2;
            this.S_No_Textbox3.Location = new System.Drawing.Point(325, 122);
            this.S_No_Textbox3.Margin = new System.Windows.Forms.Padding(5);
            this.S_No_Textbox3.Name = "S_No_Textbox3";
            this.S_No_Textbox3.Size = new System.Drawing.Size(246, 41);
            this.S_No_Textbox3.TabIndex = 14;
            this.S_No_Textbox3.TabStop = false;
            this.S_No_Textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Date_Time_Textbox4
            // 
            this.Date_Time_Textbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Date_Time_Textbox4.Enabled = false;
            this.Date_Time_Textbox4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Time_Textbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Date_Time_Textbox4.HintForeColor = System.Drawing.Color.Empty;
            this.Date_Time_Textbox4.HintText = "";
            this.Date_Time_Textbox4.isPassword = false;
            this.Date_Time_Textbox4.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.Date_Time_Textbox4.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.Date_Time_Textbox4.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.Date_Time_Textbox4.LineThickness = 2;
            this.Date_Time_Textbox4.Location = new System.Drawing.Point(325, 169);
            this.Date_Time_Textbox4.Margin = new System.Windows.Forms.Padding(5);
            this.Date_Time_Textbox4.Name = "Date_Time_Textbox4";
            this.Date_Time_Textbox4.Size = new System.Drawing.Size(246, 41);
            this.Date_Time_Textbox4.TabIndex = 15;
            this.Date_Time_Textbox4.TabStop = false;
            this.Date_Time_Textbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Save_T_Textbox5
            // 
            this.Save_T_Textbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Save_T_Textbox5.Enabled = false;
            this.Save_T_Textbox5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_T_Textbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Save_T_Textbox5.HintForeColor = System.Drawing.Color.Empty;
            this.Save_T_Textbox5.HintText = "";
            this.Save_T_Textbox5.isPassword = false;
            this.Save_T_Textbox5.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.Save_T_Textbox5.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.Save_T_Textbox5.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.Save_T_Textbox5.LineThickness = 2;
            this.Save_T_Textbox5.Location = new System.Drawing.Point(325, 216);
            this.Save_T_Textbox5.Margin = new System.Windows.Forms.Padding(5);
            this.Save_T_Textbox5.Name = "Save_T_Textbox5";
            this.Save_T_Textbox5.Size = new System.Drawing.Size(246, 41);
            this.Save_T_Textbox5.TabIndex = 16;
            this.Save_T_Textbox5.TabStop = false;
            this.Save_T_Textbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Send_T_Textbox6
            // 
            this.Send_T_Textbox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Send_T_Textbox6.Enabled = false;
            this.Send_T_Textbox6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_T_Textbox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Send_T_Textbox6.HintForeColor = System.Drawing.Color.Empty;
            this.Send_T_Textbox6.HintText = "";
            this.Send_T_Textbox6.isPassword = false;
            this.Send_T_Textbox6.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.Send_T_Textbox6.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.Send_T_Textbox6.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.Send_T_Textbox6.LineThickness = 2;
            this.Send_T_Textbox6.Location = new System.Drawing.Point(325, 263);
            this.Send_T_Textbox6.Margin = new System.Windows.Forms.Padding(5);
            this.Send_T_Textbox6.Name = "Send_T_Textbox6";
            this.Send_T_Textbox6.Size = new System.Drawing.Size(246, 41);
            this.Send_T_Textbox6.TabIndex = 17;
            this.Send_T_Textbox6.TabStop = false;
            this.Send_T_Textbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Battery_Volt_Textbox7
            // 
            this.Battery_Volt_Textbox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Battery_Volt_Textbox7.Enabled = false;
            this.Battery_Volt_Textbox7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Battery_Volt_Textbox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Battery_Volt_Textbox7.HintForeColor = System.Drawing.Color.Empty;
            this.Battery_Volt_Textbox7.HintText = "";
            this.Battery_Volt_Textbox7.isPassword = false;
            this.Battery_Volt_Textbox7.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.Battery_Volt_Textbox7.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.Battery_Volt_Textbox7.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.Battery_Volt_Textbox7.LineThickness = 2;
            this.Battery_Volt_Textbox7.Location = new System.Drawing.Point(325, 310);
            this.Battery_Volt_Textbox7.Margin = new System.Windows.Forms.Padding(5);
            this.Battery_Volt_Textbox7.Name = "Battery_Volt_Textbox7";
            this.Battery_Volt_Textbox7.Size = new System.Drawing.Size(246, 41);
            this.Battery_Volt_Textbox7.TabIndex = 18;
            this.Battery_Volt_Textbox7.TabStop = false;
            this.Battery_Volt_Textbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pictureBox1.Location = new System.Drawing.Point(274, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(4, 311);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BattHealthLabel
            // 
            this.BattHealthLabel.AutoSize = true;
            this.BattHealthLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattHealthLabel.ForeColor = System.Drawing.Color.Silver;
            this.BattHealthLabel.Location = new System.Drawing.Point(114, 315);
            this.BattHealthLabel.Name = "BattHealthLabel";
            this.BattHealthLabel.Size = new System.Drawing.Size(160, 25);
            this.BattHealthLabel.TabIndex = 4;
            this.BattHealthLabel.Text = "Battery Health";
            // 
            // sendTimeLabel
            // 
            this.sendTimeLabel.AutoSize = true;
            this.sendTimeLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendTimeLabel.ForeColor = System.Drawing.Color.Silver;
            this.sendTimeLabel.Location = new System.Drawing.Point(155, 269);
            this.sendTimeLabel.Name = "sendTimeLabel";
            this.sendTimeLabel.Size = new System.Drawing.Size(119, 25);
            this.sendTimeLabel.TabIndex = 5;
            this.sendTimeLabel.Text = "Send Time";
            // 
            // saveTimeLabel
            // 
            this.saveTimeLabel.AutoSize = true;
            this.saveTimeLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTimeLabel.ForeColor = System.Drawing.Color.Silver;
            this.saveTimeLabel.Location = new System.Drawing.Point(156, 223);
            this.saveTimeLabel.Name = "saveTimeLabel";
            this.saveTimeLabel.Size = new System.Drawing.Size(118, 25);
            this.saveTimeLabel.TabIndex = 6;
            this.saveTimeLabel.Text = "Save Time";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.ForeColor = System.Drawing.Color.Silver;
            this.dateTimeLabel.Location = new System.Drawing.Point(158, 177);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(116, 25);
            this.dateTimeLabel.TabIndex = 7;
            this.dateTimeLabel.Text = "Date-Time";
            // 
            // SNOLabel
            // 
            this.SNOLabel.AutoSize = true;
            this.SNOLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNOLabel.ForeColor = System.Drawing.Color.Silver;
            this.SNOLabel.Location = new System.Drawing.Point(162, 131);
            this.SNOLabel.Name = "SNOLabel";
            this.SNOLabel.Size = new System.Drawing.Size(112, 25);
            this.SNOLabel.TabIndex = 8;
            this.SNOLabel.Text = "Serial No.";
            // 
            // DevTypeLabel
            // 
            this.DevTypeLabel.AutoSize = true;
            this.DevTypeLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevTypeLabel.ForeColor = System.Drawing.Color.Silver;
            this.DevTypeLabel.Location = new System.Drawing.Point(142, 39);
            this.DevTypeLabel.Name = "DevTypeLabel";
            this.DevTypeLabel.Size = new System.Drawing.Size(132, 25);
            this.DevTypeLabel.TabIndex = 9;
            this.DevTypeLabel.Text = "Device Type";
            // 
            // ProdIdLabel
            // 
            this.ProdIdLabel.AutoSize = true;
            this.ProdIdLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIdLabel.ForeColor = System.Drawing.Color.Silver;
            this.ProdIdLabel.Location = new System.Drawing.Point(156, 85);
            this.ProdIdLabel.Name = "ProdIdLabel";
            this.ProdIdLabel.Size = new System.Drawing.Size(118, 25);
            this.ProdIdLabel.TabIndex = 10;
            this.ProdIdLabel.Text = "Product ID";
            // 
            // Admin_btn
            // 
            this.Admin_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Admin_btn.AutoSize = true;
            this.Admin_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Admin_btn.FlatAppearance.BorderSize = 0;
            this.Admin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Admin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_btn.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.Admin_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Admin_btn.Location = new System.Drawing.Point(199, 184);
            this.Admin_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(188, 33);
            this.Admin_btn.TabIndex = 14;
            this.Admin_btn.TabStop = false;
            this.Admin_btn.Text = "Device Information";
            this.Admin_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin_btn.UseVisualStyleBackColor = true;
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // SenderComboBox
            // 
            this.SenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderComboBox.FormattingEnabled = true;
            this.SenderComboBox.Location = new System.Drawing.Point(887, 125);
            this.SenderComboBox.Name = "SenderComboBox";
            this.SenderComboBox.Size = new System.Drawing.Size(122, 21);
            this.SenderComboBox.TabIndex = 20;
            // 
            // Sender_btn
            // 
            this.Sender_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sender_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Sender_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sender_btn.Location = new System.Drawing.Point(887, 152);
            this.Sender_btn.Name = "Sender_btn";
            this.Sender_btn.Size = new System.Drawing.Size(122, 23);
            this.Sender_btn.TabIndex = 21;
            this.Sender_btn.Text = "Sender_btn";
            this.Sender_btn.UseVisualStyleBackColor = true;
            this.Sender_btn.Click += new System.EventHandler(this.Sender_btn_Click);
            // 
            // hide_panel
            // 
            this.hide_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hide_panel.Location = new System.Drawing.Point(880, 114);
            this.hide_panel.Name = "hide_panel";
            this.hide_panel.Size = new System.Drawing.Size(28, 138);
            this.hide_panel.TabIndex = 27;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "successful_Tick_PNG.png");
            this.imageList1.Images.SetKeyName(1, "alert_cross_PNG.png");
            // 
            // timer_disconnect
            // 
            this.timer_disconnect.Interval = 50;
            this.timer_disconnect.Tick += new System.EventHandler(this.timer_disconnect_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(887, 181);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 24);
            this.textBox1.TabIndex = 28;
            // 
            // Scanning_label
            // 
            this.Scanning_label.AutoSize = true;
            this.Scanning_label.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.Scanning_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(180)))), ((int)(((byte)(181)))));
            this.Scanning_label.Location = new System.Drawing.Point(5, 8);
            this.Scanning_label.Name = "Scanning_label";
            this.Scanning_label.Size = new System.Drawing.Size(245, 22);
            this.Scanning_label.TabIndex = 3;
            this.Scanning_label.Text = "Scanning For Available Ports...";
            // 
            // show_btn
            // 
            this.show_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.show_btn.Location = new System.Drawing.Point(911, 389);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(134, 25);
            this.show_btn.TabIndex = 31;
            this.show_btn.Text = "show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // click_timer
            // 
            this.click_timer.Interval = 500;
            this.click_timer.Tick += new System.EventHandler(this.click_timer_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(911, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 28);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::QES_Connect.Properties.Resources.PanelCurve_Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 626);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::QES_Connect.Properties.Resources.Battery_Shadow_Panel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.battery_ProgressBar);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bat_icon_perc);
            this.panel1.Location = new System.Drawing.Point(887, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 76);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Battery";
            // 
            // battery_ProgressBar
            // 
            this.battery_ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.battery_ProgressBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.battery_ProgressBar.BorderRadius = 5;
            this.battery_ProgressBar.Location = new System.Drawing.Point(90, 25);
            this.battery_ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.battery_ProgressBar.MaximumValue = 100;
            this.battery_ProgressBar.Name = "battery_ProgressBar";
            this.battery_ProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.battery_ProgressBar.Size = new System.Drawing.Size(50, 28);
            this.battery_ProgressBar.TabIndex = 16;
            this.battery_ProgressBar.Value = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::QES_Connect.Properties.Resources.battery_landscape_Cropped2;
            this.pictureBox3.Location = new System.Drawing.Point(85, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(58, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "%";
            // 
            // bat_icon_perc
            // 
            this.bat_icon_perc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bat_icon_perc.AutoSize = true;
            this.bat_icon_perc.BackColor = System.Drawing.Color.White;
            this.bat_icon_perc.Font = new System.Drawing.Font("Corbel", 9.5F);
            this.bat_icon_perc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bat_icon_perc.Location = new System.Drawing.Point(21, 39);
            this.bat_icon_perc.Margin = new System.Windows.Forms.Padding(0);
            this.bat_icon_perc.Name = "bat_icon_perc";
            this.bat_icon_perc.Size = new System.Drawing.Size(24, 15);
            this.bat_icon_perc.TabIndex = 17;
            this.bat_icon_perc.Text = "NA";
            // 
            // SerialWriteCheck_Btn
            // 
            this.SerialWriteCheck_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialWriteCheck_Btn.Location = new System.Drawing.Point(911, 354);
            this.SerialWriteCheck_Btn.Name = "SerialWriteCheck_Btn";
            this.SerialWriteCheck_Btn.Size = new System.Drawing.Size(134, 21);
            this.SerialWriteCheck_Btn.TabIndex = 38;
            this.SerialWriteCheck_Btn.Text = "Serial Write Check";
            this.SerialWriteCheck_Btn.UseVisualStyleBackColor = true;
            this.SerialWriteCheck_Btn.Click += new System.EventHandler(this.SerialWriteCheck_Btn_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(983, 504);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(62, 59);
            this.panel5.TabIndex = 39;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox5.Location = new System.Drawing.Point(0, 51);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 8);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Location = new System.Drawing.Point(54, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 59);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // CornerLogo
            // 
            this.CornerLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CornerLogo.BackgroundImage = global::QES_Connect.Properties.Resources.QES_Watermark;
            this.CornerLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CornerLogo.Location = new System.Drawing.Point(1010, 599);
            this.CornerLogo.Name = "CornerLogo";
            this.CornerLogo.Size = new System.Drawing.Size(52, 46);
            this.CornerLogo.TabIndex = 40;
            this.CornerLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // Connect_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CornerLogo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.SerialWriteCheck_Btn);
            this.Controls.Add(this.Scanning_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hide_panel);
            this.Controls.Add(this.Sender_btn);
            this.Controls.Add(this.SenderComboBox);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.Admin_btn);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.COM_Settings_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "Connect_Control";
            this.Size = new System.Drawing.Size(1060, 645);
            this.Load += new System.EventHandler(this.Connect_Control_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loading_pictureBox)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label COM_Settings_label;
        private System.Windows.Forms.ComboBox COMcomboBox;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton disconnect_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Connect_btn;
        private System.Windows.Forms.ComboBox BAUDcomboBox;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Button Admin_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Dev_Type_Textbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Prod_ID_Textbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox S_No_Textbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Date_Time_Textbox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Save_T_Textbox5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Send_T_Textbox6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Battery_Volt_Textbox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BattHealthLabel;
        private System.Windows.Forms.Label sendTimeLabel;
        private System.Windows.Forms.Label saveTimeLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label SNOLabel;
        private System.Windows.Forms.Label DevTypeLabel;
        private System.Windows.Forms.Label ProdIdLabel;
        private Bunifu.Framework.UI.BunifuProgressBar battery_ProgressBar;
        private System.Windows.Forms.Label bat_icon_perc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox loading_pictureBox;
        private System.Windows.Forms.ComboBox SenderComboBox;
        private System.Windows.Forms.Button Sender_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel hide_panel;
        public System.IO.Ports.SerialPort MySerialPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer_disconnect;
        private Bunifu.Framework.UI.BunifuFlatButton Save_Info_btn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label Scanning_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button show_btn;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton ReScan_btn;
        private System.Windows.Forms.Timer click_timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SerialWriteCheck_Btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox CornerLogo;
        private System.Windows.Forms.Label label1;
    }
}
