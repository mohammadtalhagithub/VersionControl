namespace QES_Connect
{
    partial class Admin_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Close_btn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Bottom_panel = new System.Windows.Forms.Panel();
            this.Save_pw_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Fill_panel = new System.Windows.Forms.Panel();
            this.Confirm_PW_tbx = new System.Windows.Forms.TextBox();
            this.Current_PW_tbx = new System.Windows.Forms.TextBox();
            this.New_PW_tbx = new System.Windows.Forms.TextBox();
            this.Save_Kf_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Save_SNo_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Save_Sid_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Save_Pid_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Kf_tbx = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox();
            this.SNo_tbx = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox();
            this.Sid_tbx = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox();
            this.Pid_tbx = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Top_panel.SuspendLayout();
            this.Bottom_panel.SuspendLayout();
            this.Fill_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_btn
            // 
            this.Close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(527, 0);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(50, 31);
            this.Close_btn.TabIndex = 100;
            this.Close_btn.TabStop = false;
            this.Close_btn.Text = "x";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Top_panel.Controls.Add(this.Close_btn);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(577, 31);
            this.Top_panel.TabIndex = 34;
            // 
            // Bottom_panel
            // 
            this.Bottom_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Bottom_panel.Controls.Add(this.Save_pw_btn);
            this.Bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_panel.Location = new System.Drawing.Point(0, 428);
            this.Bottom_panel.Name = "Bottom_panel";
            this.Bottom_panel.Size = new System.Drawing.Size(577, 43);
            this.Bottom_panel.TabIndex = 35;
            // 
            // Save_pw_btn
            // 
            this.Save_pw_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Save_pw_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_pw_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Save_pw_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_pw_btn.BorderRadius = 7;
            this.Save_pw_btn.ButtonText = "Save Password";
            this.Save_pw_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_pw_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Save_pw_btn.Enabled = false;
            this.Save_pw_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Save_pw_btn.Iconimage = null;
            this.Save_pw_btn.Iconimage_right = null;
            this.Save_pw_btn.Iconimage_right_Selected = null;
            this.Save_pw_btn.Iconimage_Selected = null;
            this.Save_pw_btn.IconMarginLeft = 0;
            this.Save_pw_btn.IconMarginRight = 0;
            this.Save_pw_btn.IconRightVisible = true;
            this.Save_pw_btn.IconRightZoom = 0D;
            this.Save_pw_btn.IconVisible = true;
            this.Save_pw_btn.IconZoom = 90D;
            this.Save_pw_btn.IsTab = false;
            this.Save_pw_btn.Location = new System.Drawing.Point(206, 8);
            this.Save_pw_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_pw_btn.Name = "Save_pw_btn";
            this.Save_pw_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.Save_pw_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Save_pw_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Save_pw_btn.selected = false;
            this.Save_pw_btn.Size = new System.Drawing.Size(165, 27);
            this.Save_pw_btn.TabIndex = 8;
            this.Save_pw_btn.Text = "Save Password";
            this.Save_pw_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_pw_btn.Textcolor = System.Drawing.Color.White;
            this.Save_pw_btn.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Save_pw_btn.Click += new System.EventHandler(this.Save_pw_btn_Click);
            // 
            // Fill_panel
            // 
            this.Fill_panel.Controls.Add(this.Confirm_PW_tbx);
            this.Fill_panel.Controls.Add(this.Current_PW_tbx);
            this.Fill_panel.Controls.Add(this.New_PW_tbx);
            this.Fill_panel.Controls.Add(this.Save_Kf_btn);
            this.Fill_panel.Controls.Add(this.Save_SNo_btn);
            this.Fill_panel.Controls.Add(this.Save_Sid_btn);
            this.Fill_panel.Controls.Add(this.Save_Pid_btn);
            this.Fill_panel.Controls.Add(this.label9);
            this.Fill_panel.Controls.Add(this.label4);
            this.Fill_panel.Controls.Add(this.bunifuSeparator1);
            this.Fill_panel.Controls.Add(this.Kf_tbx);
            this.Fill_panel.Controls.Add(this.SNo_tbx);
            this.Fill_panel.Controls.Add(this.Sid_tbx);
            this.Fill_panel.Controls.Add(this.Pid_tbx);
            this.Fill_panel.Controls.Add(this.bunifuSeparator4);
            this.Fill_panel.Controls.Add(this.bunifuSeparator3);
            this.Fill_panel.Controls.Add(this.bunifuSeparator2);
            this.Fill_panel.Controls.Add(this.label3);
            this.Fill_panel.Controls.Add(this.label2);
            this.Fill_panel.Controls.Add(this.label8);
            this.Fill_panel.Controls.Add(this.label7);
            this.Fill_panel.Controls.Add(this.label1);
            this.Fill_panel.Controls.Add(this.label6);
            this.Fill_panel.Controls.Add(this.label5);
            this.Fill_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fill_panel.Location = new System.Drawing.Point(0, 31);
            this.Fill_panel.Name = "Fill_panel";
            this.Fill_panel.Size = new System.Drawing.Size(577, 397);
            this.Fill_panel.TabIndex = 36;
            // 
            // Confirm_PW_tbx
            // 
            this.Confirm_PW_tbx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Confirm_PW_tbx.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Confirm_PW_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Confirm_PW_tbx.Enabled = false;
            this.Confirm_PW_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_PW_tbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Confirm_PW_tbx.Location = new System.Drawing.Point(216, 362);
            this.Confirm_PW_tbx.Name = "Confirm_PW_tbx";
            this.Confirm_PW_tbx.Size = new System.Drawing.Size(306, 23);
            this.Confirm_PW_tbx.TabIndex = 7;
            this.Confirm_PW_tbx.TextChanged += new System.EventHandler(this.Confirm_PW_tbx_TextChanged_1);
            // 
            // Current_PW_tbx
            // 
            this.Current_PW_tbx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Current_PW_tbx.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Current_PW_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Current_PW_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_PW_tbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Current_PW_tbx.Location = new System.Drawing.Point(216, 268);
            this.Current_PW_tbx.Name = "Current_PW_tbx";
            this.Current_PW_tbx.Size = new System.Drawing.Size(306, 23);
            this.Current_PW_tbx.TabIndex = 5;
            this.Current_PW_tbx.TextChanged += new System.EventHandler(this.Current_PW_tbx_TextChanged);
            // 
            // New_PW_tbx
            // 
            this.New_PW_tbx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.New_PW_tbx.BackColor = System.Drawing.Color.DarkSlateGray;
            this.New_PW_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.New_PW_tbx.Enabled = false;
            this.New_PW_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_PW_tbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.New_PW_tbx.Location = new System.Drawing.Point(216, 315);
            this.New_PW_tbx.Name = "New_PW_tbx";
            this.New_PW_tbx.Size = new System.Drawing.Size(306, 23);
            this.New_PW_tbx.TabIndex = 6;
            this.New_PW_tbx.TextChanged += new System.EventHandler(this.New_PW_tbx_TextChanged_1);
            // 
            // Save_Kf_btn
            // 
            this.Save_Kf_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Save_Kf_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Kf_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Save_Kf_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_Kf_btn.BorderRadius = 7;
            this.Save_Kf_btn.ButtonText = "Save KF";
            this.Save_Kf_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Kf_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Save_Kf_btn.Enabled = false;
            this.Save_Kf_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Save_Kf_btn.Iconimage = null;
            this.Save_Kf_btn.Iconimage_right = null;
            this.Save_Kf_btn.Iconimage_right_Selected = null;
            this.Save_Kf_btn.Iconimage_Selected = null;
            this.Save_Kf_btn.IconMarginLeft = 0;
            this.Save_Kf_btn.IconMarginRight = 0;
            this.Save_Kf_btn.IconRightVisible = true;
            this.Save_Kf_btn.IconRightZoom = 0D;
            this.Save_Kf_btn.IconVisible = true;
            this.Save_Kf_btn.IconZoom = 90D;
            this.Save_Kf_btn.IsTab = false;
            this.Save_Kf_btn.Location = new System.Drawing.Point(465, 148);
            this.Save_Kf_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Kf_btn.Name = "Save_Kf_btn";
            this.Save_Kf_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.Save_Kf_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Save_Kf_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Save_Kf_btn.selected = false;
            this.Save_Kf_btn.Size = new System.Drawing.Size(85, 27);
            this.Save_Kf_btn.TabIndex = 4;
            this.Save_Kf_btn.Text = "Save KF";
            this.Save_Kf_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_Kf_btn.Textcolor = System.Drawing.Color.White;
            this.Save_Kf_btn.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Save_Kf_btn.Click += new System.EventHandler(this.Save_pw_btn_Click);
            // 
            // Save_SNo_btn
            // 
            this.Save_SNo_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Save_SNo_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_SNo_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Save_SNo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_SNo_btn.BorderRadius = 7;
            this.Save_SNo_btn.ButtonText = "Save S.No";
            this.Save_SNo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_SNo_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Save_SNo_btn.Enabled = false;
            this.Save_SNo_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Save_SNo_btn.Iconimage = null;
            this.Save_SNo_btn.Iconimage_right = null;
            this.Save_SNo_btn.Iconimage_right_Selected = null;
            this.Save_SNo_btn.Iconimage_Selected = null;
            this.Save_SNo_btn.IconMarginLeft = 0;
            this.Save_SNo_btn.IconMarginRight = 0;
            this.Save_SNo_btn.IconRightVisible = true;
            this.Save_SNo_btn.IconRightZoom = 0D;
            this.Save_SNo_btn.IconVisible = true;
            this.Save_SNo_btn.IconZoom = 90D;
            this.Save_SNo_btn.IsTab = false;
            this.Save_SNo_btn.Location = new System.Drawing.Point(465, 109);
            this.Save_SNo_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_SNo_btn.Name = "Save_SNo_btn";
            this.Save_SNo_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.Save_SNo_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Save_SNo_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Save_SNo_btn.selected = false;
            this.Save_SNo_btn.Size = new System.Drawing.Size(85, 27);
            this.Save_SNo_btn.TabIndex = 4;
            this.Save_SNo_btn.Text = "Save S.No";
            this.Save_SNo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_SNo_btn.Textcolor = System.Drawing.Color.White;
            this.Save_SNo_btn.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Save_SNo_btn.Click += new System.EventHandler(this.Save_pw_btn_Click);
            // 
            // Save_Sid_btn
            // 
            this.Save_Sid_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Save_Sid_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Sid_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Save_Sid_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_Sid_btn.BorderRadius = 7;
            this.Save_Sid_btn.ButtonText = "Save S.ID";
            this.Save_Sid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Sid_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Save_Sid_btn.Enabled = false;
            this.Save_Sid_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Save_Sid_btn.Iconimage = null;
            this.Save_Sid_btn.Iconimage_right = null;
            this.Save_Sid_btn.Iconimage_right_Selected = null;
            this.Save_Sid_btn.Iconimage_Selected = null;
            this.Save_Sid_btn.IconMarginLeft = 0;
            this.Save_Sid_btn.IconMarginRight = 0;
            this.Save_Sid_btn.IconRightVisible = true;
            this.Save_Sid_btn.IconRightZoom = 0D;
            this.Save_Sid_btn.IconVisible = true;
            this.Save_Sid_btn.IconZoom = 90D;
            this.Save_Sid_btn.IsTab = false;
            this.Save_Sid_btn.Location = new System.Drawing.Point(465, 70);
            this.Save_Sid_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Sid_btn.Name = "Save_Sid_btn";
            this.Save_Sid_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.Save_Sid_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Save_Sid_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Save_Sid_btn.selected = false;
            this.Save_Sid_btn.Size = new System.Drawing.Size(85, 27);
            this.Save_Sid_btn.TabIndex = 4;
            this.Save_Sid_btn.Text = "Save S.ID";
            this.Save_Sid_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_Sid_btn.Textcolor = System.Drawing.Color.White;
            this.Save_Sid_btn.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Save_Sid_btn.Click += new System.EventHandler(this.Save_pw_btn_Click);
            // 
            // Save_Pid_btn
            // 
            this.Save_Pid_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Save_Pid_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Pid_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Save_Pid_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_Pid_btn.BorderRadius = 7;
            this.Save_Pid_btn.ButtonText = "Save P.ID";
            this.Save_Pid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Pid_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Save_Pid_btn.Enabled = false;
            this.Save_Pid_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Save_Pid_btn.Iconimage = null;
            this.Save_Pid_btn.Iconimage_right = null;
            this.Save_Pid_btn.Iconimage_right_Selected = null;
            this.Save_Pid_btn.Iconimage_Selected = null;
            this.Save_Pid_btn.IconMarginLeft = 0;
            this.Save_Pid_btn.IconMarginRight = 0;
            this.Save_Pid_btn.IconRightVisible = true;
            this.Save_Pid_btn.IconRightZoom = 0D;
            this.Save_Pid_btn.IconVisible = true;
            this.Save_Pid_btn.IconZoom = 90D;
            this.Save_Pid_btn.IsTab = false;
            this.Save_Pid_btn.Location = new System.Drawing.Point(465, 31);
            this.Save_Pid_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Pid_btn.Name = "Save_Pid_btn";
            this.Save_Pid_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.Save_Pid_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Save_Pid_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Save_Pid_btn.selected = false;
            this.Save_Pid_btn.Size = new System.Drawing.Size(85, 27);
            this.Save_Pid_btn.TabIndex = 4;
            this.Save_Pid_btn.Text = "Save P.ID";
            this.Save_Pid_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_Pid_btn.Textcolor = System.Drawing.Color.White;
            this.Save_Pid_btn.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Save_Pid_btn.Click += new System.EventHandler(this.Save_pw_btn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(197, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Change Device Info.";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(208, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Change Password";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(35, 210);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(506, 19);
            this.bunifuSeparator1.TabIndex = 45;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Kf_tbx
            // 
            this.Kf_tbx.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.Kf_tbx.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Kf_tbx.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.Kf_tbx.FocusedColor = System.Drawing.Color.DarkCyan;
            this.Kf_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kf_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Kf_tbx.IsEnabled = true;
            this.Kf_tbx.Location = new System.Drawing.Point(156, 148);
            this.Kf_tbx.MaxLength = 32767;
            this.Kf_tbx.Multiline = false;
            this.Kf_tbx.Name = "Kf_tbx";
            this.Kf_tbx.PasswordChar = '\0';
            this.Kf_tbx.ReadOnly = false;
            this.Kf_tbx.Size = new System.Drawing.Size(297, 24);
            this.Kf_tbx.TabIndex = 3;
            this.Kf_tbx.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Kf_tbx.TextBackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.Kf_tbx.UseSystemPasswordChar = false;
            this.Kf_tbx.WordWrap = true;
            // 
            // SNo_tbx
            // 
            this.SNo_tbx.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.SNo_tbx.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.SNo_tbx.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.SNo_tbx.FocusedColor = System.Drawing.Color.DarkCyan;
            this.SNo_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNo_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.SNo_tbx.IsEnabled = true;
            this.SNo_tbx.Location = new System.Drawing.Point(156, 110);
            this.SNo_tbx.MaxLength = 32767;
            this.SNo_tbx.Multiline = false;
            this.SNo_tbx.Name = "SNo_tbx";
            this.SNo_tbx.PasswordChar = '\0';
            this.SNo_tbx.ReadOnly = false;
            this.SNo_tbx.Size = new System.Drawing.Size(297, 24);
            this.SNo_tbx.TabIndex = 2;
            this.SNo_tbx.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.SNo_tbx.TextBackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.SNo_tbx.UseSystemPasswordChar = false;
            this.SNo_tbx.WordWrap = true;
            // 
            // Sid_tbx
            // 
            this.Sid_tbx.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.Sid_tbx.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Sid_tbx.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.Sid_tbx.FocusedColor = System.Drawing.Color.DarkCyan;
            this.Sid_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sid_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Sid_tbx.IsEnabled = true;
            this.Sid_tbx.Location = new System.Drawing.Point(156, 72);
            this.Sid_tbx.MaxLength = 32767;
            this.Sid_tbx.Multiline = false;
            this.Sid_tbx.Name = "Sid_tbx";
            this.Sid_tbx.PasswordChar = '\0';
            this.Sid_tbx.ReadOnly = false;
            this.Sid_tbx.Size = new System.Drawing.Size(297, 24);
            this.Sid_tbx.TabIndex = 1;
            this.Sid_tbx.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Sid_tbx.TextBackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.Sid_tbx.UseSystemPasswordChar = false;
            this.Sid_tbx.WordWrap = true;
            // 
            // Pid_tbx
            // 
            this.Pid_tbx.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.Pid_tbx.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Pid_tbx.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.Pid_tbx.FocusedColor = System.Drawing.Color.DarkCyan;
            this.Pid_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pid_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Pid_tbx.IsEnabled = true;
            this.Pid_tbx.Location = new System.Drawing.Point(156, 34);
            this.Pid_tbx.MaxLength = 32767;
            this.Pid_tbx.Multiline = false;
            this.Pid_tbx.Name = "Pid_tbx";
            this.Pid_tbx.PasswordChar = '\0';
            this.Pid_tbx.ReadOnly = false;
            this.Pid_tbx.Size = new System.Drawing.Size(297, 24);
            this.Pid_tbx.TabIndex = 0;
            this.Pid_tbx.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pid_tbx.TextBackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.Pid_tbx.UseSystemPasswordChar = false;
            this.Pid_tbx.WordWrap = true;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(206, 380);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(326, 19);
            this.bunifuSeparator4.TabIndex = 46;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(206, 333);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(326, 19);
            this.bunifuSeparator3.TabIndex = 43;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(206, 286);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(326, 19);
            this.bunifuSeparator2.TabIndex = 44;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(44, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(44, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "New Password";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(27, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Server ID";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(27, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(27, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "K Factor";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(27, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Serial Number";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(44, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Current Password";
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(577, 471);
            this.Controls.Add(this.Fill_panel);
            this.Controls.Add(this.Top_panel);
            this.Controls.Add(this.Bottom_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.Top_panel.ResumeLayout(false);
            this.Bottom_panel.ResumeLayout(false);
            this.Fill_panel.ResumeLayout(false);
            this.Fill_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Close_btn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel Bottom_panel;
        private Bunifu.Framework.UI.BunifuFlatButton Save_pw_btn;
        private System.Windows.Forms.Panel Fill_panel;
        private System.Windows.Forms.Label label4;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox Kf_tbx;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox SNo_tbx;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox Sid_tbx;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox Pid_tbx;
        private System.Windows.Forms.TextBox Confirm_PW_tbx;
        private System.Windows.Forms.TextBox New_PW_tbx;
        private System.Windows.Forms.TextBox Current_PW_tbx;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton Save_Pid_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton Save_Kf_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Save_SNo_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Save_Sid_btn;
    }
}