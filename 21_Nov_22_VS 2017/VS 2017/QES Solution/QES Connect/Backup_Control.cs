using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QES_Connect
{
    public partial class Backup_Control : UserControl
    {

        protected override CreateParams CreateParams
        {
            get
            {
                var bc = base.CreateParams;
                bc.ExStyle |= 0x02000000; // Turn ON WS_EX_COMPOSITED
                return bc;
            }
        }

        public static PictureBox _loading_picBox;

        public Backup_Control()
        {
            InitializeComponent();


            try
            {

            }
            catch (Exception ex)
            {


            }

            _Backup_textBox = Backup_textBox;
            _checkedListBox1 = checkedListBox1;
            _loading_picBox = loading_picBox;
            _Save_btn = Save_btn;
            _Delete_btn = Delete_btn;
            _indices_btn_bool = indices_btn_bool;
            //_progressPanel1 = progressPanel1; // DevExpress.XtraWaifForm.ProgressPanel

        }

        private void AnyCheckboxEnabled()
        {
            //if (File_1_chbx.Checked == true || File_2_chbx.Checked == true ||
            //    File_3_chbx.Checked == true || File_4_chbx.Checked == true ||
            //    File_5_chbx.Checked == true || File_6_chbx.Checked == true ||
            //    File_7_chbx.Checked == true || File_8_chbx.Checked == true)
            //{
            //    Save_btn.Enabled = true;
            //    Save_btn.Cursor = Cursors.Hand;

            //    Delete_btn.Enabled = true;
            //    Delete_btn.Cursor = Cursors.Hand;
            //}
            //else
            //{
            //    Save_btn.Enabled = false;
            //    Save_btn.Cursor = Cursors.No;

            //    Delete_btn.Enabled = false;
            //    Delete_btn.Cursor = Cursors.No;
            //}

        }


        public static Bunifu.Framework.UI.BunifuFlatButton _Save_btn;
        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Connect_Control._fileName_label.Text = null;

                sender_txtbx.Clear();
                Connect_Control._SenderComboBox.Items.Clear();
                Connect_Control._SenderComboBox.Text = null;

                string fileNos = null;
                string Data = "$502:savefile:" + "0" + fileNos;

                for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
                {
                    //listbox2.Items.Add(checkedListBox1.CheckedIndices[i]);
                    //uint unsigned;
                    //byte
                    //fileNos = "$502:" + "savefile:" + j + Environment.NewLine;//;  File_1_chbx.Text.ToString();
                    //$502:savefile:3:0,1,4;
                    //MessageBox.Show(checkedListBox1.CheckedIndices.ToString());
                    //Backup_textBox.Clear();

                    int j = checkedListBox1.CheckedIndices[i];
                    fileNos += "," + j.ToString();
                }

                Data = "$502:savefile:" + checkedListBox1.CheckedIndices.Count + ":" + fileNos;
                sender_txtbx.Text = Data;
                //SelectedFileCount.Text = checkedListBox1.CheckedIndices.Count.ToString() + " files selected";

                Connect_Control._SenderComboBox.Text = sender_txtbx.Text;
                Connect_Control._Sender_btn.PerformClick();
                //sender_txtbx.Clear();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message); ;
            }
        }

        public static Bunifu.Framework.UI.BunifuFlatButton _Delete_btn;

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                //checkedListBox1.Items.Clear();
                sender_txtbx.Clear();
                Connect_Control._SenderComboBox.Items.Clear();
                Connect_Control._SenderComboBox.Text = null;

                string fileNos = null;
                string Data = "$502:deletefile:" + "0" + fileNos;

                for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
                {
                    //Connect_Control._fileName_label.Text = null;
                    //listbox2.Items.Add(checkedListBox1.CheckedIndices[i]);
                    //uint unsigned;
                    //byte
                    //fileNos = "$502:" + "savefile:" + j + Environment.NewLine;//;  File_1_chbx.Text.ToString();
                    //$502:savefile:3:0,1,4;
                    //MessageBox.Show(checkedListBox1.CheckedIndices.ToString());
                    //Backup_textBox.Clear();

                    //string file = "$502:" + "del:";//  + File_1_chbx.Text.ToString();
                    //Connect_Control._SenderComboBox.Text = file;
                    //Connect_Control._Sender_btn.PerformClick();
                    //Backup_textBox.Clear();

                    int j = checkedListBox1.CheckedIndices[i];
                    fileNos += "," + j.ToString();
                }

                Data = "$502:deletefile:" + checkedListBox1.CheckedIndices.Count + ":" + fileNos;
                sender_txtbx.Text = Data;
                //SelectedFileCount.Text = checkedListBox1.CheckedIndices.Count.ToString() + " files selected";

                Connect_Control._SenderComboBox.Text = sender_txtbx.Text;
                Connect_Control._Sender_btn.PerformClick();
                //sender_txtbx.Clear();
                Form1._backup_btn_2.PerformClick();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message); ;
            }

        }

        public static TextBox _Backup_textBox;
        public static CheckedListBox _checkedListBox1;

        string fileName;

        private void Backup_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loading_picBox.Visible = false;
                loading_picBox.Enabled = false;
                //loading_picBox.Image = null;
                //loading_picBox.SizeMode = PictureBoxSizeMode.Normal;

                //progressPanel1.Visible = false;
                //progressPanel1.Enabled = false;

                string data = _Backup_textBox.Text; // 4:Data_05.csv

                string index = data.Substring(0, data.IndexOf(':'));

                //label1.Text = "Total Files: " + index + ".";

                label1.Text = index;

                fileName = data.Remove(0, data.IndexOf(':') + 1); // Data_05.csv
                                                                  //string file = fileName;
                                                                  //checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add(fileName);

                fileName = null;

                #region commented if else
                //MessageBox.Show(fileName);

                //if (index=="1")
                //{
                //    //File_1_chbx.Text = fileName;
                //    //File_1_chbx.Visible = true;
                //    checkedListBox1.Items.Add(fileName);
                //}
                //else if (index == "2")
                //{
                //    //File_2_chbx.Text = fileName;
                //    //File_2_chbx.Visible = true;
                //    checkedListBox1.Items.Add(fileName);
                //}
                //else if (index == "3")
                //{
                //    //File_3_chbx.Text = fileName;
                //    //File_3_chbx.Visible = true;
                //    checkedListBox1.Items.Add(fileName);
                //}
                //else if (index == "4")
                //{
                //    //File_4_chbx.Text = fileName;
                //    //File_4_chbx.Visible = true;
                //    checkedListBox1.Items.Add(fileName);
                //}
                //else if (index == "5")
                //{
                //    //File_5_chbx.Text = fileName;
                //    //File_5_chbx.Visible = true;
                //    checkedListBox1.Items.Add(fileName);
                //}
                //else if (index == "6")
                //{
                //    //File_6_chbx.Text = fileName;
                //    //File_6_chbx.Visible = true;
                //}
                //else if (index == "7")
                //{
                //    //File_7_chbx.Text = fileName;
                //    //File_7_chbx.Visible = true;
                //    checkedListBox1.Items.Add(fileName);
                //}
                //else if (index == "8")
                //{
                //    //File_8_chbx.Text = fileName;
                //    //File_8_chbx.Visible = true;
                //    checkedListBox1.Items.Add(fileName);
                //} 
                #endregion
            }
            catch (Exception)
            {

            }
        }

        private void Backup_Control_Load(object sender, EventArgs e)
        {
            try
            {
                if (ResponsiveClass.working_width >= 1920)
                {
                    bunifuCards1.Width = 1000;
                    bunifuCards1.Height = this.Height - 50;

                    bunifuCards1.Left = (this.Width - bunifuCards1.Width) / 2;

                }

                loading_picBox.SizeMode = PictureBoxSizeMode.Zoom;

                Save_btn.Cursor = Cursors.No;
                Delete_btn.Cursor = Cursors.No;

                #region Commented

                // Form1.FillPanel_Width / 2;//800; // 1582/800 = 1.97 => 800 = 1582/~2
                //bunifuCards2.Width = Form1.FillPanel_Width / 2;//800;
                //bunifuCards1.Left - Form1.FillPanel_Width / 20;//78; // 1582/78 = 20.28 => 78 = 1582/~20
                //bunifuCards2.Left = bunifuCards2.Left - Form1.FillPanel_Width / 20;//78;
                //bunifuCards1.Location = new Point(panel2.Width / 2 - bunifuCards1.Width / 2, panel2.Height / 2 - bunifuCards1.Height / 2
                //if (Width >= 1580 && Height >= 940)
                //{
                //    //MessageBox.Show(Width.ToString() + ", " + Height.ToString());
                //    label3.Text = "1580";

                //}

                //label3.Text = "1580";


                //AnyCheckboxEnabled();
                //CheckedListBox checkedListBox2 = new System.Windows.Forms.CheckedListBox();

                //checkedListBox2.BackColor = System.Drawing.Color.White;
                //checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                //checkedListBox2.CheckOnClick = true;
                //checkedListBox2.Font = new System.Drawing.Font("Century Gothic", 11F);
                //checkedListBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
                //checkedListBox2.FormattingEnabled = true;
                //checkedListBox2.Location = new System.Drawing.Point(20, 42);
                //checkedListBox2.Name = "checkedListBox2";
                //checkedListBox2.Size = new System.Drawing.Size(100, 100);
                //checkedListBox2.TabIndex = 38;
                //checkedListBox2.TabStop = false;
                //checkedListBox2.ThreeDCheckBoxes = true;
                ////checkedListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(checkedListBox2_ItemCheck);
                //checkedListBox2.Show(); 
                #endregion
            }
            catch (Exception)
            {

            }
        }
        int filesSelected;
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (checkedListBox1.CheckedItems.Count == 1)
                {
                    if (e.NewValue == CheckState.Unchecked)
                    {
                        Save_btn.Enabled = false; Save_btn.Cursor = Cursors.No;
                        Delete_btn.Enabled = false; Delete_btn.Cursor = Cursors.No;
                        Indices_btn.Enabled = false; Indices_btn.Cursor = Cursors.No;
                    }
                }
                else
                {
                    Save_btn.Enabled = true; Save_btn.Cursor = Cursors.Hand;
                    Delete_btn.Enabled = true; Delete_btn.Cursor = Cursors.Hand;
                    Indices_btn.Enabled = true; Indices_btn.Cursor = Cursors.Hand;


                }
            }
            catch (Exception)
            {

            }
        }


        #region Commented
        /*
        
            foreach (var ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chbx = (CheckBox)ctrl;

                    chbx.CheckedChanged += new EventHandler(check_changed);
                    //chbx.CheckStateChanged += new EventHandler(_checkedStateChanged);
                }
            }

            private void check_changed(object sender, EventArgs e)
        {
            CheckBox chbx = sender as CheckBox;

            //if (chbx.Checked == true)
            //{
            //    Save_btn.Enabled = true;
            //    Save_btn.Cursor = Cursors.Hand;

            //    Delete_btn.Enabled = true;
            //    Delete_btn.Cursor = Cursors.Hand;
            //}

            //else if (chbx.Checked == false)
            //{
            //    Save_btn.Enabled = false;
            //    Save_btn.Cursor = Cursors.No;

            //    Delete_btn.Enabled = false;
            //    Delete_btn.Cursor = Cursors.No;
            //}

        }

        private void _checkedStateChanged(object sender, EventArgs e)
        {
            CheckBox chbx = sender as CheckBox;

        }

        private void Checkd(object sender, EventArgs e)
        {
            CheckBox chbx = sender as CheckBox;
        }
        
        private void Excel_file_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveToTxtFile_button.Enabled = Excel_file_checkBox.Checked;
        }


        private void Txt_file_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveToTxtFile_button.Enabled = Txt_file_checkBox.Checked;
        }
        private void chkAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkFruits.Items.Count; i++)
            {
                chkFruits.SetItemChecked(i, chkAll.Checked);
            }
        }

        private void bunifuCheckbox1_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, bunifuCheckbox1.Checked);
                }
            }

            else if (bunifuCheckbox1.Checked == false)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, bunifuCheckbox1.Checked == false);
                }
            }
        }

        List<string> checkedItems = new List<string>();
        foreach (var item in checkedListBox1.CheckedItems)
            checkedItems.Add(item.ToString());

        if (e.NewValue == CheckState.Checked)
            checkedItems.Add(checkedListBox1.Items[e.Index].ToString());
        else
            checkedItems.Remove(checkedListBox1.Items[e.Index].ToString());

        foreach (string item in checkedItems)
        {

        }


        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count >= 1)
            {
                foreach (var ctrl in tableLayoutPanel1.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox chbx = (CheckBox)ctrl;

                        chbx.Visible = true;
                    }
                }
                timer1.Stop();
                count = 0;
            }
        }

        if (chbx.Checked == true)
            {
                Save_btn.Enabled = true;
                Save_btn.Cursor = Cursors.Hand;

                Delete_btn.Enabled = true;
                Delete_btn.Cursor = Cursors.Hand;
            }

        private void btn_Enable()
        {
            foreach (var ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chbx = (CheckBox)ctrl;
                    chbx.BackColor = Color.Red;
                }
            }
        }

        */
        #endregion

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, chkAll.Checked);
                    // filesSelected + " Selected";
                }

                if (chkAll.Checked)
                {
                    //SelectedFileCount.Text = "Selected: All";
                    SelectedFileCount.Text = "All";
                    //chkAll.CheckState = CheckState.Checked;
                }
                else
                {
                    //SelectedFileCount.Text = "Selected: 0";
                    SelectedFileCount.Text = "0";
                    chkAll.CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception)
            {

            }
        }


        private void To_listbox_btn_Click(object sender, EventArgs e)
        {
            //sender_txtbx.Clear();

            //foreach (string s in checkedListBox1.CheckedItems)
            //{
            //    //listbox2.Items.Add(s);

            //    //sender_txtbx.Text += index.ToString() + ":" + s + ":";
            //    //index++;

            //    sender_txtbx.Text += "$502:SendData_" + s + "_" + Environment.NewLine;

            //    //MessageBox.Show(s);
            //}
        }

        //ListBox listbox3 = new ListBox();

        //private void Indices_btn_Click(object sender, EventArgs e)
        //{
        //    ////listbox3.Items.Clear();
        //    //sender_txtbx.Clear();

        //    //for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
        //    //{
        //    //    //listbox2.Items.Add(checkedListBox1.CheckedIndices[i]);

        //    //    int j = checkedListBox1.CheckedIndices[i] + 1;
        //    //    sender_txtbx.Text += "$502:fileNo_" + j + Environment.NewLine;

        //    //    Connect_Control._SenderComboBox.Text = sender_txtbx.Text;
        //    //    Connect_Control._Sender_btn.PerformClick();

        //    //}
        //}

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                filesSelected = checkedListBox1.CheckedItems.Count;
                //SelectedFileCount.Text = " Selected: " + filesSelected;
                SelectedFileCount.Text = filesSelected.ToString();
                //chkAll.CheckState = CheckState.Indeterminate;
            }
            catch (Exception)
            {

            }
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {

        }

        public static bool _indices_btn_bool;
        private bool indices_btn_bool = false;

        private void Indices_btn_Click(object sender, EventArgs e)
        {
            try
            {
                indices_btn_bool = true;

                sender_txtbx.Clear();

                for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
                {
                    //listbox2.Items.Add(checkedListBox1.CheckedIndices[i]);

                    int j = checkedListBox1.CheckedIndices[i] + 1;
                    sender_txtbx.Text += "$502:savefileNo_" + j + Environment.NewLine;

                    Connect_Control._SenderComboBox.Text = sender_txtbx.Text;
                    Connect_Control._Sender_btn.PerformClick();

                }
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Form1._cc.FileWrite.ToString());
            //Form1._cc.Rescan_btn_Function();
            //MyClass mc = new MyClass();
            //Form1.Scaling();


        }
    }
}
