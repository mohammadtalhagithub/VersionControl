using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace QES_Connect
{
    public partial class Preferences_Control : UserControl
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


        public Preferences_Control()
        {
            InitializeComponent();
        }

        private void Change_Color_btn_Click(object sender, EventArgs e)
        {
            //bunifuCards1.color = Color.FromArgb(Convert.ToInt16(R_tbx.Text),
               // Convert.ToInt16(G_tbx.Text), Convert.ToInt16(B_tbx.Text));

            //Settings1.Default.ColorR = Convert.ToInt16(R_tbx.Text);
            //Settings1.Default.ColorG = Convert.ToInt16(G_tbx.Text);
            //Settings1.Default.ColorB = Convert.ToInt16(B_tbx.Text);
            //Properties.Settings.Default.Save();
        }
        //public BunifuFlatButton BTN
        //{

        //    get { return Change_Color_btn; }
        //    set { Change_Color_btn = value; }
        //}


        private void Preferences_Control_Load(object sender, EventArgs e)
        {
            //bunifuCards1.color = Color.FromArgb(Settings1.Default.ColorR, Settings1.Default.ColorG,
            //    Settings1.Default.ColorB);

            //Check_Label.Location=new Point(Settings1.Default.XPosition, Settings1.Default.YPosition);

            //XPosTbx.Text = Settings1.Default.XPosition.ToString();
            //YPosTbx.Text = Settings1.Default.YPosition.ToString();
        }

        private void Change_Location_btn_Click(object sender, EventArgs e)
        {

            //Check_Label.Location = new Point(Convert.ToInt16(XPosTbx.Text),
            //    Convert.ToInt16(YPosTbx.Text));

            ////Settings1.Default.XPosition = Convert.ToInt16(XPosTbx.Text);
            ////Settings1.Default.YPosition = Convert.ToInt16(YPosTbx.Text);
            //Properties.Settings.Default.Save();
        }
    }
}
