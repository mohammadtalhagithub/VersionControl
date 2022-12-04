namespace QES_Connect
{
    partial class Splash
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.percentage = new System.Windows.Forms.Label();
            this.Animation_timer = new System.Windows.Forms.Timer(this.components);
            this.Anim_label = new System.Windows.Forms.Label();
            this.Anim_picBx = new System.Windows.Forms.PictureBox();
            this.Animation_timer_2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Anim_picBx)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // percentage
            // 
            this.percentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentage.AutoSize = true;
            this.percentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.percentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.ForeColor = System.Drawing.Color.White;
            this.percentage.Location = new System.Drawing.Point(49, 335);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(58, 15);
            this.percentage.TabIndex = 7;
            this.percentage.Text = "Starting...";
            // 
            // Animation_timer
            // 
            this.Animation_timer.Enabled = true;
            this.Animation_timer.Interval = 5;
            this.Animation_timer.Tick += new System.EventHandler(this.Animation_timer_Tick);
            // 
            // Anim_label
            // 
            this.Anim_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Anim_label.AutoSize = true;
            this.Anim_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Anim_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anim_label.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Anim_label.ForeColor = System.Drawing.Color.White;
            this.Anim_label.Location = new System.Drawing.Point(49, 57);
            this.Anim_label.Name = "Anim_label";
            this.Anim_label.Size = new System.Drawing.Size(58, 15);
            this.Anim_label.TabIndex = 7;
            this.Anim_label.Text = "Starting...";
            // 
            // Anim_picBx
            // 
            this.Anim_picBx.BackColor = System.Drawing.Color.DarkCyan;
            this.Anim_picBx.BackgroundImage = global::QES_Connect.Properties.Resources.QES_Connect_LOGO;
            this.Anim_picBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Anim_picBx.Location = new System.Drawing.Point(85, 262);
            this.Anim_picBx.Name = "Anim_picBx";
            this.Anim_picBx.Size = new System.Drawing.Size(40, 40);
            this.Anim_picBx.TabIndex = 11;
            this.Anim_picBx.TabStop = false;
            // 
            // Animation_timer_2
            // 
            this.Animation_timer_2.Interval = 1;
            this.Animation_timer_2.Tick += new System.EventHandler(this.Animation_timer_2_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.Anim_picBx);
            this.Controls.Add(this.Anim_label);
            this.Controls.Add(this.percentage);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QES Connect";
            this.TransparencyKey = System.Drawing.SystemColors.Desktop;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Anim_picBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Timer Animation_timer;
        private System.Windows.Forms.Label Anim_label;
        private System.Windows.Forms.PictureBox Anim_picBx;
        private System.Windows.Forms.Timer Animation_timer_2;
    }
}