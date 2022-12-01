namespace QES_Connect
{
    partial class TileClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileClass));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Param_Icon = new System.Windows.Forms.PictureBox();
            this.Unit_Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Value_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Param_Label = new System.Windows.Forms.Label();
            this.image_List1 = new System.Windows.Forms.ImageList(this.components);
            this.MainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Param_Icon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = global::QES_Connect.Properties.Resources.TileImage;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(197, 124);
            this.MainPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Param_Icon);
            this.panel3.Controls.Add(this.Unit_Label);
            this.panel3.Location = new System.Drawing.Point(20, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 38);
            this.panel3.TabIndex = 2;
            // 
            // Param_Icon
            // 
            this.Param_Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.Param_Icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.Param_Icon.Location = new System.Drawing.Point(0, 0);
            this.Param_Icon.Name = "Param_Icon";
            this.Param_Icon.Size = new System.Drawing.Size(35, 38);
            this.Param_Icon.TabIndex = 2;
            this.Param_Icon.TabStop = false;
            // 
            // Unit_Label
            // 
            this.Unit_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Unit_Label.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.Unit_Label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Unit_Label.Location = new System.Drawing.Point(0, 0);
            this.Unit_Label.Name = "Unit_Label";
            this.Unit_Label.Size = new System.Drawing.Size(157, 38);
            this.Unit_Label.TabIndex = 0;
            this.Unit_Label.Text = "℃";
            this.Unit_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Value_Label);
            this.panel2.Location = new System.Drawing.Point(19, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 39);
            this.panel2.TabIndex = 1;
            // 
            // Value_Label
            // 
            this.Value_Label.BackColor = System.Drawing.Color.Transparent;
            this.Value_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Value_Label.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold);
            this.Value_Label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Value_Label.Location = new System.Drawing.Point(0, 0);
            this.Value_Label.Name = "Value_Label";
            this.Value_Label.Size = new System.Drawing.Size(158, 39);
            this.Value_Label.TabIndex = 0;
            this.Value_Label.Text = "1000";
            this.Value_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Param_Label);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 22);
            this.panel1.TabIndex = 0;
            // 
            // Param_Label
            // 
            this.Param_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Param_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Param_Label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Param_Label.Location = new System.Drawing.Point(0, 0);
            this.Param_Label.Name = "Param_Label";
            this.Param_Label.Size = new System.Drawing.Size(188, 22);
            this.Param_Label.TabIndex = 0;
            this.Param_Label.Text = "Parameter Name";
            this.Param_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // image_List1
            // 
            this.image_List1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List1.ImageStream")));
            this.image_List1.TransparentColor = System.Drawing.Color.Transparent;
            this.image_List1.Images.SetKeyName(0, "Temperature_icon.png");
            this.image_List1.Images.SetKeyName(1, "Humidity_icon.png");
            this.image_List1.Images.SetKeyName(2, "WindVel_icon.png");
            this.image_List1.Images.SetKeyName(3, "WaterLevel_icon.png");
            this.image_List1.Images.SetKeyName(4, "CO2_icon.png");
            this.image_List1.Images.SetKeyName(5, "SolarRad_icon.png");
            this.image_List1.Images.SetKeyName(6, "WindDirection_icon.png");
            this.image_List1.Images.SetKeyName(7, "SoilMoisture_icon.png");
            this.image_List1.Images.SetKeyName(8, "Rainfall_icon.png");
            // 
            // TileClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Name = "TileClass";
            this.Size = new System.Drawing.Size(197, 124);
            this.Load += new System.EventHandler(this.TileClass_Load);
            this.MainPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Param_Icon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Value_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Param_Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Unit_Label;
        private System.Windows.Forms.PictureBox Param_Icon;
        private System.Windows.Forms.ImageList image_List1;
    }
}
