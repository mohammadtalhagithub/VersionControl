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
    public partial class Splash : Form
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

        //protected override void WndProc ( ref Message m )
        //{
        //    const int WM_NCCALCSIZE = 0x0083;
        //    if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) // 1 means true || 0 means false
        //    {
        //        return;
        //    }

        //    base.WndProc(ref m);
        //}

        public Splash ()
        {
            InitializeComponent();
        }


        //Form1 MainForm = new Form1();
        int count;
        private void timer1_Tick ( object sender, EventArgs e )
        {
            count = count + 2;


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

        private void Splash_Load(object sender, EventArgs e)
        {
            //zeroitProgressBarRect1.Value = 0;
            //if (zeroitProgressBarRect1.Value == 100)
            //{
            //    zeroitProgressBarRect1.Enabled = false;
            //    zeroitProgressBarRect1.Visible = false;
            //}
        }

        int Anim_count;
        private void Animation_timer_Tick(object sender, EventArgs e)
        {
            Anim_count++;
            if (Anim_count == 10)
            {
                Animation_timer.Stop();
                Animation_timer_2.Start();
            }
           
            Anim_picBx.Left += 2;
            Anim_picBx.Top -= 4;

            Anim_picBx.Width += 5;
            Anim_picBx.Height += 4;
        }

        int Anim_count_2;
        private void Animation_timer_2_Tick(object sender, EventArgs e)
        {
            Anim_count_2++;
            if (Anim_count_2 == 10)
            {
                Animation_timer_2.Stop();
            }
            Anim_label.Left += 2;
        }
    }
}
