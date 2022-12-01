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
    public partial class Setup_Control : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var sc = base.CreateParams;
                sc.ExStyle |= 0x02000000; // Turn ON WS_EX_COMPOSITED
                return sc;
            }
        }

        public static BunifuMaterialTextbox _DateANDTime_Textbox;
        //public static PictureBox _Anim_PicBx;

        //public static Setup_Control instance;


        public Setup_Control()
        {
            InitializeComponent();

            //instance = this;

            _CurrentTime = CurrentTime;
            //_Anim_PicBx = Anim_PicBx;
            //_DateANDTime_Textbox = DateANDTime_Textbox;
        }

        private async void My_Method(string trigger, ComboBox combobx)
        { // To
            try
            {
                Form1._Main_Label.Text = "$501:" + trigger + ":" + combobx.Text.ToString();

                Connect_Control._SenderComboBox.Text = "$501:" + trigger + ":" + combobx.Text.ToString();

                await Task.Delay(10);
                Connect_Control._Sender_btn.PerformClick();

                await Task.Delay(10);
                Connect_Control._SenderComboBox.Text = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Form1._Main_Label.Text = ex.Message;
                Form1._Main_Label.ForeColor = Color.Red;
            }
        }

        private void Save_interval_btn_Click(object sender, EventArgs e)
        {
            My_Method("savet", Save_Interval_box);
        }

        private void Send_interval_btn_Click(object sender, EventArgs e)
        {
            My_Method("sendt", Send_Interval_box);
        }

        private void Setup_Control_Load(object sender, EventArgs e)
        {
            //Update_DnT_btn.BackColor = Color.DarkCyan;

            if (AM_PM_cbx.SelectedIndex == 0) // AM
            {
                hh = Convert.ToInt32(hh_UpDown.Text);
            }
            else if (AM_PM_cbx.SelectedIndex == 1) // PM
            {
                hh = Convert.ToInt32(hh_UpDown.Text) + 12;
            }

            //SysTime_Chkbx.Checked = false;

            Save_Interval_box.SelectedIndex = 0;
            Send_Interval_box.SelectedIndex = 0;
            APN_comboBox.SelectedIndex = 0;

            //AM_PM_cbx.SelectedIndex = 0;

            AM_PM_cbx.Text = DateTime.Now.ToString("tt", System.Globalization.CultureInfo.InvariantCulture);
        }

        private async void Set_Zero_btn_Click(object sender, EventArgs e)
        {
            Form1._Main_Label.Text = "$501:" + "zerocalib";

            await Task.Delay(10);
            Connect_Control._SenderComboBox.Text = Form1._Main_Label.Text.ToString();

            await Task.Delay(10);
            Connect_Control._Sender_btn.PerformClick();

            //Connect_Control._SenderComboBox.Text = null;
        }

        private void span_btn_Click(object sender, EventArgs e)
        {
            My_Method("spancalib", span_comboBox);
        }

        private async void APN_Method(string apn)
        {
            //Connect_Control._SenderComboBox.Text = null;
            await Task.Delay(10);
            Form1._Main_Label.Text = "$501:apn:" + apn;

            await Task.Delay(10);
            Connect_Control._SenderComboBox.Text = "$501:apn:" + apn;

            await Task.Delay(10);
            Connect_Control._Sender_btn.PerformClick();
        }

        private void UpdateAPN_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (APN_comboBox.Text == "Airtel")
                    APN_Method("airtelgprs.com");

                else if (APN_comboBox.Text == "Airtel IoT")
                    APN_Method("Airteliot.com");

                else if (APN_comboBox.Text == "VI")
                    APN_Method("portalnmms");

                else if (APN_comboBox.Text == "VI-M2M (QES)")
                    APN_Method("M2MISAFE");

                else
                    APN_Method(APN_comboBox.Text.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        string send_string;
        private async void UpDateTime_btn_Click(object sender, EventArgs e)
        {
            if (SysDT_Checkbox.Checked) //(SysDT_Checkbox.Checked == true && chk == true)
            {
                time_String = DateTime.Now.ToString("HH:mm");
                date_String = DateTime.Now.ToString("dd-MM-yyyy");
                //send_string = DatePicker.Value.ToShortDateString() + "#" + time_String;
                send_string = date_String + "#" + time_String;
                
            }
            else if (SysDT_Checkbox.Checked == false) //(SysDT_Checkbox.Checked == false && chk == false)
            {
                send_string = DatePicker.Value.ToShortDateString() + "#" + time_String;
            }

            send_label.Text = send_string;

            await Task.Delay(10);
            Connect_Control._SenderComboBox.Text = send_string;//.ToString();

            await Task.Delay(10);
            Connect_Control._Sender_btn.PerformClick();

            await Task.Delay(10);
            Connect_Control._SenderComboBox.Text = null;
        }

        string time_String;
        string date_String;

        private void SysTime_Chkbx_OnChange(object sender, EventArgs e)
        {
            //try
            //{
            //    if (SysTime_Chkbx.Checked)
            //    {
            //        CurrentTime.Start();
            //        hh_UpDown.Enabled = false;
            //        mm_UpDown.Enabled = false;
            //        AM_PM_cbx.Enabled = false;
            //        //DatePicker.Enabled = false;

            //        //time_String = DateTime.Now.ToShortTimeString();
            //        time_String = DateTime.Now.ToString("HH:mm");
            //        date_String = DateTime.Now.ToString("dd-MM-yyyy");
            //        //if you add "tt" ->> The Am/Pm designator.

            //        //Time_label.Text = time_String;

            //        chk = true;
            //    }
            //    else
            //    {
            //        CurrentTime.Stop();
            //        hh_UpDown.Enabled = true;
            //        mm_UpDown.Enabled = true;
            //        AM_PM_cbx.Enabled = true;
            //        // DatePicker.Enabled = true;

            //        time_String = hh_UpDown.Text.ToString() + ":" + mm_UpDown.Text.ToString();
            //        //Time_label.Text = time_String;

            //        if (AM_PM_cbx.SelectedIndex == 0) // AM
            //        {
            //            if (hh_UpDown.Text == 12.ToString())
            //            {
            //                mm = Convert.ToInt32(mm_UpDown.Text);

            //                time_String = "00" + ":" + mm.ToString();
            //            }
            //        }

            //        if (AM_PM_cbx.SelectedIndex == 1) // PM
            //        {
            //            if (hh_UpDown.Text != 12.ToString())
            //            {
            //                hh = Convert.ToInt32(hh_UpDown.Text) + 12;
            //                mm = Convert.ToInt32(mm_UpDown.Text);

            //                time_String = hh.ToString() + ":" + mm.ToString();
            //            }
            //        }
            //        chk = false;
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Error");
            //}
        }

        public static Timer _CurrentTime;

        private void CurrentTime_Tick(object sender, EventArgs e)
        {
            //Time_label.Text = DateTime.Now.ToLongTimeString();
            Time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //bool chk = false;

        private void label13_Click(object sender, EventArgs e)
        {
            //if (chk == false)
            //{
            //    CurrentTime.Start();

            //    SysTime_Chkbx.Checked = true;
            //    hh_UpDown.Enabled = false;
            //    mm_UpDown.Enabled = false;
            //    AM_PM_cbx.Enabled = false;
            //    //DatePicker.Enabled = false;

            //    //time_String = DateTime.Now.ToShortTimeString();
            //    time_String = DateTime.Now.ToString("HH:mm");
            //    date_String = DateTime.Now.ToString("dd-MM-yyyy");

            //    //Time_label.Text = time_String;

            //    chk = true;
            //}
            //else
            //{
            //    CurrentTime.Stop();

            //    SysTime_Chkbx.Checked = false;
            //    hh_UpDown.Enabled = true;
            //    mm_UpDown.Enabled = true;
            //    AM_PM_cbx.Enabled = true;
            //    //DatePicker.Enabled = true;

            //    time_String = hh_UpDown.Text.ToString() + ":" + mm_UpDown.Text.ToString();
            //    //Time_label.Text = time_String;

            //    if (AM_PM_cbx.SelectedIndex == 0) // AM
            //    {
            //        if (hh_UpDown.Text == 12.ToString())
            //        {
            //            mm = Convert.ToInt32(mm_UpDown.Text);

            //            time_String = "00" + ":" + mm.ToString();
            //        }
            //    }

            //    if (AM_PM_cbx.SelectedIndex == 1) // PM
            //    {
            //        if (hh_UpDown.Text != 12.ToString())
            //        {
            //            hh = Convert.ToInt32(hh_UpDown.Text) + 12;
            //            mm = Convert.ToInt32(mm_UpDown.Text);

            //            time_String = hh.ToString() + ":" + mm.ToString();
            //        }
            //    }

            //    chk = false;
            //}
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            //label13.ForeColor = Color.FromArgb(0, 139, 139);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            //label13.ForeColor = Color.Black;
        }

        private void SysTime_Chkbx_MouseEnter(object sender, EventArgs e)
        {
            //label13.ForeColor = Color.FromArgb(0, 139, 139);
        }

        private void SysTime_Chkbx_MouseLeave(object sender, EventArgs e)
        {
            //label13.ForeColor = Color.Black;
        }


        int hh;
        int mm;

        private void Format_Conversion()
        {
            try
            {
                if (AM_PM_cbx.SelectedIndex == 0) // AM
                {
                    if (hh_UpDown.Text == 12.ToString())
                    {
                        mm = Convert.ToInt32(mm_UpDown.Text);

                        time_String = "00" + ":" + mm.ToString();
                    }
                    else if (hh_UpDown.Text != 12.ToString())
                    {
                        hh = Convert.ToInt32(hh_UpDown.Text);
                        mm = Convert.ToInt32(mm_UpDown.Text);

                        time_String = hh.ToString() + ":" + mm.ToString();
                    }
                }

                else if (AM_PM_cbx.SelectedIndex == 1) // PM
                {
                    if (hh_UpDown.Text == 12.ToString())
                    {
                        hh = Convert.ToInt32(hh_UpDown.Text);// + 12;
                        mm = Convert.ToInt32(mm_UpDown.Text);

                        time_String = hh.ToString() + ":" + mm.ToString();

                    }
                    else if (hh_UpDown.Text != 12.ToString())
                    {
                        hh = Convert.ToInt32(hh_UpDown.Text) + 12;
                        mm = Convert.ToInt32(mm_UpDown.Text);

                        time_String = hh.ToString() + ":" + mm.ToString();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Calling Format_Conversion Method
        private void AM_PM_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Format_Conversion();
        }

        private void mm_UpDown_ValueChanged(object sender, EventArgs e)
        {
            Format_Conversion();
        }

        private void hh_UpDown_ValueChanged(object sender, EventArgs e)
        {
            Format_Conversion();
        }

        private void SysDT_Checkbox_Click(object sender, EventArgs e)
        {
            if (SysDT_Checkbox.Checked)//(chk == false)
            {
                CurrentTime.Start();

                hh_UpDown.Enabled = false;
                mm_UpDown.Enabled = false;
                AM_PM_cbx.Enabled = false;
                //DatePicker.Enabled = false;

                //time_String = DateTime.Now.ToShortTimeString();
                time_String = DateTime.Now.ToString("HH:mm");
                date_String = DateTime.Now.ToString("dd-MM-yyyy");

                //Time_label.Text = time_String;

                //chk = true;
            }
            else
            {
                CurrentTime.Stop();

                //SysTime_Chkbx.Checked = false;
                hh_UpDown.Enabled = true;
                mm_UpDown.Enabled = true;
                AM_PM_cbx.Enabled = true;
                //DatePicker.Enabled = true;

                time_String = hh_UpDown.Text.ToString() + ":" + mm_UpDown.Text.ToString();
                //Time_label.Text = time_String;

                if (AM_PM_cbx.SelectedIndex == 0) // AM
                {
                    if (hh_UpDown.Text == 12.ToString())
                    {
                        mm = Convert.ToInt32(mm_UpDown.Text);

                        time_String = "00" + ":" + mm.ToString();
                    }
                }

                if (AM_PM_cbx.SelectedIndex == 1) // PM
                {
                    if (hh_UpDown.Text != 12.ToString())
                    {
                        hh = Convert.ToInt32(hh_UpDown.Text) + 12;
                        mm = Convert.ToInt32(mm_UpDown.Text);

                        time_String = hh.ToString() + ":" + mm.ToString();
                    }
                }

                //chk = false;
            }
        }

        private async void Update_DnT_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SysDT_Checkbox.Checked) //(SysDT_Checkbox.Checked == true && chk == true)
                {
                    time_String = DateTime.Now.ToString("HH:mm");
                    date_String = DateTime.Now.ToString("dd-MM-yyyy");
                    //send_string = DatePicker.Value.ToShortDateString() + "#" + time_String;
                    send_string = date_String + "#" + time_String;

                }
                else if (SysDT_Checkbox.Checked == false) //(SysDT_Checkbox.Checked == false && chk == false)
                {
                    send_string = DatePicker.Value.ToShortDateString() + "#" + time_String;
                }

                send_label.Text = send_string;

                await Task.Delay(10);
                Connect_Control._SenderComboBox.Text = send_string;//.ToString();

                await Task.Delay(10);
                Connect_Control._Sender_btn.PerformClick();

                await Task.Delay(10);
                Connect_Control._SenderComboBox.Text = null;
            }
            catch// (Exception)
            {

                //throw;
            }
        }
    }
}
