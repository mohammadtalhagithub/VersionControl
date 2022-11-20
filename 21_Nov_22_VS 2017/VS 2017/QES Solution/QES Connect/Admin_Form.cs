using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;//
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QES_Connect
{
    public partial class Admin_Form : Form
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

        public Admin_Form()
        {
            InitializeComponent();
            Current_PW_tbx.PasswordChar = '●';
            New_PW_tbx.PasswordChar = '●';
            Confirm_PW_tbx.PasswordChar = '●';
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            try
            {
                bunifuSeparator3.LineColor = Color.Gray;
                bunifuSeparator4.LineColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void current_PW_tbx_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Current_PW_tbx.Text == Properties.Settings.Default.CPW) //Properties.Settings.Default.CuPW
        //        {
        //            new_PW_tbx.Enabled = true;
        //            bunifuSeparator3.LineColor = Color.FromArgb(0, 128, 128);
        //        }

        //        else
        //        {
        //            new_PW_tbx.Enabled = false;
        //            bunifuSeparator3.LineColor = Color.Gray;
        //            //new_PW_tbx.Cursor = Cursors.No;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void new_PW_tbx_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (new_PW_tbx.Text != null)
            //    {
            //        confirm_PW_tbx.Enabled = true;
            //        bunifuSeparator4.LineColor = Color.FromArgb(0, 128, 128);
            //    }
            //    else
            //    {
            //        confirm_PW_tbx.Enabled = false;
            //        Save_pw_btn.Enabled = false;
            //        bunifuSeparator4.LineColor = Color.Gray;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void confirm_PW_tbx_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (confirm_PW_tbx.Text == new_PW_tbx.Text && Current_PW_tbx.Text == Properties.Settings.Default.CPW)
            //    {
            //        //Save_Psswrd_btn.Enabled = true;
            //        Save_pw_btn.Enabled = true;
            //    }

            //    else if (confirm_PW_tbx.Text != new_PW_tbx.Text)
            //    {
            //        // Save_Psswrd_btn.Enabled = false;
            //        Save_pw_btn.Enabled = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Save_pw_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Confirm_PW_tbx.Text == New_PW_tbx.Text)
                {
                    Properties.Settings.Default.CPW = New_PW_tbx.Text;

                    Properties.Settings.Default.Save();

                    MessageBox.Show("Password Changed Successfully...", "Status...",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    MessageBox.Show("Passwords do not match...", "Error...",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      

        private void Current_PW_tbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Current_PW_tbx.Text == Properties.Settings.Default.CPW) //Properties.Settings.Default.CuPW
                {
                    New_PW_tbx.Enabled = true;
                    bunifuSeparator3.LineColor = Color.FromArgb(0, 128, 128);
                }

                else
                {
                    New_PW_tbx.Enabled = false;
                    bunifuSeparator3.LineColor = Color.Gray;
                    //new_PW_tbx.Cursor = Cursors.No;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void New_PW_tbx_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (New_PW_tbx.Text != null)
                {
                    Confirm_PW_tbx.Enabled = true;
                    bunifuSeparator4.LineColor = Color.FromArgb(0, 128, 128);
                }
                else
                {
                    Confirm_PW_tbx.Enabled = false;
                    Save_pw_btn.Enabled = false;
                    bunifuSeparator4.LineColor = Color.Gray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Confirm_PW_tbx_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Confirm_PW_tbx.Text == New_PW_tbx.Text && Current_PW_tbx.Text == Properties.Settings.Default.CPW)
                {
                    //Save_Psswrd_btn.Enabled = true;
                    Save_pw_btn.Enabled = true;
                }

                else if (Confirm_PW_tbx.Text != New_PW_tbx.Text)
                {
                    // Save_Psswrd_btn.Enabled = false;
                    Save_pw_btn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
