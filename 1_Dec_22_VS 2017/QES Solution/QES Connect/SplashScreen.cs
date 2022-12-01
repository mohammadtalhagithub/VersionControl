using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QES_Connect
{
    /// <summary>
    /// This Splash Screen is new one, i.e., having transparent Background.
    /// </summary>
    public partial class SplashScreen : Form
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

        public SplashScreen()
        {
            InitializeComponent();

            TransparencyKey = BackColor;
        }


        int Anim_count;
        private void Animation_timer_Tick(object sender, EventArgs e)
        {
            Anim_count++;
            if (Anim_count == 10)
            {
                Animation_timer.Stop();
                //Animation_timer_2.Start();
            }

            Anim_picBx.Left += 5;
            Anim_picBx.Top -= 8;

            Anim_picBx.Width += 8;
            Anim_picBx.Height += 7;

            
        }

        int Anim_count_2;
        private void Animation_timer2_Tick(object sender, EventArgs e)
        {
            Anim_count_2++;
            if (Anim_count_2 == 10)
            {
                Animation_timer_2.Stop();
                Animation_timer.Start();
            }
            Anim_label.Left += 2;
            Anim_Pic_2.Left += 4;

        }

        int count;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count + 1;


            //percentage.Text = count.ToString();
            if (count == 50)
            {
                percentage.Text = "Loading Registry...";
            }

            else if (count == 100)
            {
                percentage.Text = "Loading UI Components...";

            }
            else if (count == 200)
            {
                timer1.Stop();
                this.Close();
                //MainForm.Show();


                //this.Hide();
            }
        }
    }
}
