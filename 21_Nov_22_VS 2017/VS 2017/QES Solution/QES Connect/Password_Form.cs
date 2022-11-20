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
    public partial class Password_Form : Form
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

        public Password_Form()
        {
            InitializeComponent();
            key_tbx.PasswordChar = '●';
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            OK_function();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void Password_Form_Load(object sender, EventArgs e)
        {
            // this.key_tbx.KeyPress += new KeyPressEventHandler(CheckEnter);
            //showPW_btn.Image = imageList1.Images[0];
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
               // OK_2_btn.PerformClick();
            }
        }

        private async void OK_function()
        {
            try
            {
                if (key_tbx.Text == QES_Connect.Properties.Settings.Default.CPW)//(key_tbx.Text == Settings1.Default.CuPW)

                // user.config is saved in >> C:\Users\Talha\AppData\Local\Quick_Engineering_Solutio\QES_Connect.exe_Url_w2ldwvx3fqrndnshap1bqjqvyou1iihw\1.0.0.0  << folder
                {
                    await Task.Delay(2000);

                    bool isOpen = false;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == "Admin_Form")
                        {
                            isOpen = true;
                            f.BringToFront();
                            break;
                        }
                    }

                    if (isOpen == false)
                    {
                        Admin_Form af = new Admin_Form();
                        af.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password...", "Access Denied...",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void key_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    OK_function();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showPW_btn_Click(object sender, EventArgs e)
        {
            //showPW_btn.Image = imageList1.Images[1];
            //key_tbx.PasswordChar = '@';

        }

        
        private void showPW_chkbx_CheckedChanged(object sender, EventArgs e)
        {

            //if (showPW_chkbx.Checked)
            //{
            //    key_tbx.PasswordChar = '\0';
            //}
            ////key_tbx.PasswordChar = showPW_chkbx.Checked ? '\0' : '*';
            //else
            //{
            //    key_tbx.PasswordChar = '*';
            //}
        }

        //private void toggleSwitch1_Toggled(object sender, EventArgs e)
        //{
        //    if (toggleSwitch1.che)
        //    {
        //        string a = textBox2.Text;
        //        textBox2.PasswordChar = '\0';
        //    }
        //    else
        //    {
        //        textBox2.PasswordChar = '*';
        //    }
        //}

    }
}
