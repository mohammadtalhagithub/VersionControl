namespace QES_Connect
{
    partial class Backup_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.loading_picBox = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Indices_btn = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedFileCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.Delete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Backup_textBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sender_txtbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading_picBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 25;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkCyan;
            this.bunifuCards1.Controls.Add(this.loading_picBox);
            this.bunifuCards1.Controls.Add(this.checkedListBox1);
            this.bunifuCards1.Controls.Add(this.groupBox1);
            this.bunifuCards1.Controls.Add(this.Indices_btn);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.Delete_btn);
            this.bunifuCards1.Controls.Add(this.Save_btn);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(117, 30);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 30;
            this.bunifuCards1.Size = new System.Drawing.Size(827, 498);
            this.bunifuCards1.TabIndex = 0;
            // 
            // loading_picBox
            // 
            this.loading_picBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loading_picBox.Enabled = false;
            this.loading_picBox.Image = global::QES_Connect.Properties.Resources.blueCircle;
            this.loading_picBox.Location = new System.Drawing.Point(359, 204);
            this.loading_picBox.Name = "loading_picBox";
            this.loading_picBox.Size = new System.Drawing.Size(109, 91);
            this.loading_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading_picBox.TabIndex = 50;
            this.loading_picBox.TabStop = false;
            this.loading_picBox.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.BackColor = System.Drawing.Color.White;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "No File"});
            this.checkedListBox1.Location = new System.Drawing.Point(42, 91);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(756, 288);
            this.checkedListBox1.TabIndex = 38;
            this.checkedListBox1.TabStop = false;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.Click += new System.EventHandler(this.checkedListBox1_Click);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.MouseHover += new System.EventHandler(this.checkedListBox1_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(23, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 341);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // Indices_btn
            // 
            this.Indices_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Indices_btn.Enabled = false;
            this.Indices_btn.Location = new System.Drawing.Point(306, 440);
            this.Indices_btn.Name = "Indices_btn";
            this.Indices_btn.Size = new System.Drawing.Size(75, 41);
            this.Indices_btn.TabIndex = 47;
            this.Indices_btn.Text = "Save";
            this.Indices_btn.UseVisualStyleBackColor = true;
            this.Indices_btn.Click += new System.EventHandler(this.Indices_btn_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 428);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(827, 2);
            this.bunifuSeparator2.TabIndex = 46;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Available Files";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 35);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(827, 2);
            this.bunifuSeparator1.TabIndex = 46;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SelectedFileCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkAll);
            this.panel1.Location = new System.Drawing.Point(23, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 25);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(741, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(653, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Total Files:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(530, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Selected:";
            // 
            // SelectedFileCount
            // 
            this.SelectedFileCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SelectedFileCount.AutoSize = true;
            this.SelectedFileCount.BackColor = System.Drawing.Color.Transparent;
            this.SelectedFileCount.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.SelectedFileCount.ForeColor = System.Drawing.Color.White;
            this.SelectedFileCount.Location = new System.Drawing.Point(610, 2);
            this.SelectedFileCount.Name = "SelectedFileCount";
            this.SelectedFileCount.Size = new System.Drawing.Size(19, 21);
            this.SelectedFileCount.TabIndex = 45;
            this.SelectedFileCount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(638, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "|";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkAll.Location = new System.Drawing.Point(20, 0);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(102, 26);
            this.chkAll.TabIndex = 38;
            this.chkAll.TabStop = false;
            this.chkAll.Text = "Select All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_btn.BorderRadius = 7;
            this.Delete_btn.ButtonText = "Delete";
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.DisabledColor = System.Drawing.Color.Silver;
            this.Delete_btn.Enabled = false;
            this.Delete_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Delete_btn.Iconimage = global::QES_Connect.Properties.Resources.delete_icon;
            this.Delete_btn.Iconimage_right = null;
            this.Delete_btn.Iconimage_right_Selected = null;
            this.Delete_btn.Iconimage_Selected = null;
            this.Delete_btn.IconMarginLeft = 0;
            this.Delete_btn.IconMarginRight = 0;
            this.Delete_btn.IconRightVisible = true;
            this.Delete_btn.IconRightZoom = 0D;
            this.Delete_btn.IconVisible = true;
            this.Delete_btn.IconZoom = 55D;
            this.Delete_btn.IsTab = false;
            this.Delete_btn.Location = new System.Drawing.Point(172, 439);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.Delete_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Delete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Delete_btn.selected = false;
            this.Delete_btn.Size = new System.Drawing.Size(114, 42);
            this.Delete_btn.TabIndex = 35;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete_btn.Textcolor = System.Drawing.Color.White;
            this.Delete_btn.TextFont = new System.Drawing.Font("Century Gothic", 11.5F);
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_btn.BorderRadius = 7;
            this.Save_btn.ButtonText = "Save";
            this.Save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_btn.DisabledColor = System.Drawing.Color.Silver;
            this.Save_btn.Enabled = false;
            this.Save_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Save_btn.Iconimage = global::QES_Connect.Properties.Resources.Backup_btn;
            this.Save_btn.Iconimage_right = null;
            this.Save_btn.Iconimage_right_Selected = null;
            this.Save_btn.Iconimage_Selected = null;
            this.Save_btn.IconMarginLeft = 0;
            this.Save_btn.IconMarginRight = 0;
            this.Save_btn.IconRightVisible = true;
            this.Save_btn.IconRightZoom = 0D;
            this.Save_btn.IconVisible = true;
            this.Save_btn.IconZoom = 55D;
            this.Save_btn.IsTab = false;
            this.Save_btn.Location = new System.Drawing.Point(45, 439);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.Save_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Save_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Save_btn.selected = false;
            this.Save_btn.Size = new System.Drawing.Size(114, 42);
            this.Save_btn.TabIndex = 36;
            this.Save_btn.Text = "Save";
            this.Save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_btn.Textcolor = System.Drawing.Color.White;
            this.Save_btn.TextFont = new System.Drawing.Font("Century Gothic", 11.5F);
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Backup_textBox
            // 
            this.Backup_textBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Backup_textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Backup_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Backup_textBox.Location = new System.Drawing.Point(505, 582);
            this.Backup_textBox.Name = "Backup_textBox";
            this.Backup_textBox.ReadOnly = true;
            this.Backup_textBox.Size = new System.Drawing.Size(241, 13);
            this.Backup_textBox.TabIndex = 37;
            this.Backup_textBox.TabStop = false;
            this.Backup_textBox.TextChanged += new System.EventHandler(this.Backup_textBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // sender_txtbx
            // 
            this.sender_txtbx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sender_txtbx.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sender_txtbx.Location = new System.Drawing.Point(509, 604);
            this.sender_txtbx.Multiline = true;
            this.sender_txtbx.Name = "sender_txtbx";
            this.sender_txtbx.ReadOnly = true;
            this.sender_txtbx.Size = new System.Drawing.Size(237, 20);
            this.sender_txtbx.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Location = new System.Drawing.Point(255, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 62);
            this.panel2.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(302, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 48);
            this.button2.TabIndex = 43;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Backup_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.sender_txtbx);
            this.Controls.Add(this.Backup_textBox);
            this.DoubleBuffered = true;
            this.Name = "Backup_Control";
            this.Size = new System.Drawing.Size(1060, 645);
            this.Load += new System.EventHandler(this.Backup_Control_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading_picBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton Delete_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Save_btn;
        private System.Windows.Forms.TextBox Backup_textBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox sender_txtbx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectedFileCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAll;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Button Indices_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox loading_picBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}
