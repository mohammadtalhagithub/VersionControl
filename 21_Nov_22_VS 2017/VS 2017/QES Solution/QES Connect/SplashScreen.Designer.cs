namespace QES_Connect
{
    partial class SplashScreen
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
            this.Animation_timer = new System.Windows.Forms.Timer(this.components);
            this.Animation_timer_2 = new System.Windows.Forms.Timer(this.components);
            this.Anim_label = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Anim_Pic_2 = new System.Windows.Forms.PictureBox();
            this.Anim_picBx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Anim_Pic_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anim_picBx)).BeginInit();
            this.SuspendLayout();
            // 
            // Animation_timer
            // 
            this.Animation_timer.Interval = 1;
            this.Animation_timer.Tick += new System.EventHandler(this.Animation_timer_Tick);
            // 
            // Animation_timer_2
            // 
            this.Animation_timer_2.Enabled = true;
            this.Animation_timer_2.Interval = 1;
            this.Animation_timer_2.Tick += new System.EventHandler(this.Animation_timer2_Tick);
            // 
            // Anim_label
            // 
            this.Anim_label.AutoSize = true;
            this.Anim_label.BackColor = System.Drawing.Color.DarkCyan;
            this.Anim_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anim_label.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Anim_label.ForeColor = System.Drawing.Color.White;
            this.Anim_label.Location = new System.Drawing.Point(-8, -1);
            this.Anim_label.Name = "Anim_label";
            this.Anim_label.Size = new System.Drawing.Size(58, 15);
            this.Anim_label.TabIndex = 8;
            this.Anim_label.Text = "Starting...";
            // 
            // percentage
            // 
            this.percentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentage.AutoSize = true;
            this.percentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.percentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.ForeColor = System.Drawing.Color.White;
            this.percentage.Location = new System.Drawing.Point(53, 311);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(58, 15);
            this.percentage.TabIndex = 10;
            this.percentage.Text = "Starting...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Anim_Pic_2
            // 
            this.Anim_Pic_2.BackColor = System.Drawing.Color.DarkCyan;
            this.Anim_Pic_2.BackgroundImage = global::QES_Connect.Properties.Resources.QES_Connect_Title_05;
            this.Anim_Pic_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Anim_Pic_2.Location = new System.Drawing.Point(255, 126);
            this.Anim_Pic_2.Name = "Anim_Pic_2";
            this.Anim_Pic_2.Size = new System.Drawing.Size(176, 47);
            this.Anim_Pic_2.TabIndex = 9;
            this.Anim_Pic_2.TabStop = false;
            // 
            // Anim_picBx
            // 
            this.Anim_picBx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Anim_picBx.BackColor = System.Drawing.Color.DarkCyan;
            this.Anim_picBx.BackgroundImage = global::QES_Connect.Properties.Resources.QES_Connect_LOGO_05;
            this.Anim_picBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Anim_picBx.Location = new System.Drawing.Point(138, 214);
            this.Anim_picBx.Name = "Anim_picBx";
            this.Anim_picBx.Size = new System.Drawing.Size(40, 40);
            this.Anim_picBx.TabIndex = 0;
            this.Anim_picBx.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.BackgroundImage = global::QES_Connect.Properties.Resources.QES_Splash_PNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 371);
            this.Controls.Add(this.Anim_Pic_2);
            this.Controls.Add(this.Anim_picBx);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.Anim_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.Anim_Pic_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anim_picBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Anim_picBx;
        private System.Windows.Forms.Timer Animation_timer;
        private System.Windows.Forms.Timer Animation_timer_2;
        private System.Windows.Forms.Label Anim_label;
        private System.Windows.Forms.PictureBox Anim_Pic_2;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Timer timer1;
    }
}