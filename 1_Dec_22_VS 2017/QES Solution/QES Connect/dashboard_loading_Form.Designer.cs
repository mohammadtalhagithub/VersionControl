namespace QES_Connect
{
    partial class dashboard_loading_Form
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
            this.loading_picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loading_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loading_picBox
            // 
            this.loading_picBox.Enabled = false;
            this.loading_picBox.Image = global::QES_Connect.Properties.Resources.blueCircle;
            this.loading_picBox.Location = new System.Drawing.Point(162, 52);
            this.loading_picBox.Name = "loading_picBox";
            this.loading_picBox.Size = new System.Drawing.Size(109, 91);
            this.loading_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading_picBox.TabIndex = 51;
            this.loading_picBox.TabStop = false;
            this.loading_picBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Fetching Data...";
            // 
            // dashboard_loading_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loading_picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard_loading_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard_loading_Form";
            this.Load += new System.EventHandler(this.dashboard_loading_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loading_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loading_picBox;
        private System.Windows.Forms.Label label1;
    }
}