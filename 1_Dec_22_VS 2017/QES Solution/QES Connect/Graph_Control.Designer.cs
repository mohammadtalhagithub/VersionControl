namespace QES_Connect
{
    partial class Graph_Control
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
            this.Page_Title_Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Page_Title_Label
            // 
            this.Page_Title_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Page_Title_Label.AutoSize = true;
            this.Page_Title_Label.BackColor = System.Drawing.Color.White;
            this.Page_Title_Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page_Title_Label.ForeColor = System.Drawing.Color.LightSlateGray;
            this.Page_Title_Label.Location = new System.Drawing.Point(285, 190);
            this.Page_Title_Label.Name = "Page_Title_Label";
            this.Page_Title_Label.Size = new System.Drawing.Size(247, 28);
            this.Page_Title_Label.TabIndex = 18;
            this.Page_Title_Label.Text = "No data Available...";
            this.Page_Title_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkCyan;
            this.bunifuCards1.Controls.Add(this.Page_Title_Label);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(111, 63);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(816, 409);
            this.bunifuCards1.TabIndex = 20;
            // 
            // Graph_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Graph_Control";
            this.Size = new System.Drawing.Size(1038, 607);
            this.Load += new System.EventHandler(this.Graph_Control_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Page_Title_Label;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
    }
}
