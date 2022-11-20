using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QES_Connect
{
    public partial class Dashboard_Control : UserControl
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

        //private string b;
        //public void ab(string a)
        //{
        //    b = a.ToString();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(b.ToString());
        //}       

        public Dashboard_Control()
        {
            InitializeComponent();
            DoubleBuffered = true;

            _Dashboard_Timer = timer1;
            _Dashboard_textBox = Dashboard_textBox;
            _tableLayoutPanel1 = tableLayoutPanel1;

            //_tileClass1 = tileClass1;
            //_tileClass2 = tileClass2;
            //_tileClass3 = tileClass3;
        }

        public static Timer _Dashboard_Timer;
        public static TextBox _Dashboard_textBox;
        public static TableLayoutPanel _tableLayoutPanel1;

        //public static TileClass _tileClass1;
        //public static TileClass _tileClass2;
        //public static TileClass _tileClass3;
        //public static TileClass _tileClass4;
        //public static TileClass _tileClass5;
        //public static TileClass _tileClass6;
        //public static TileClass _tileClass7;
        //public static TileClass _tileClass8;

        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter>6)
            {
                
                timer1.Stop();
                
                //tileClass1._Param_Label.Text = "Temperature";
               
            }
        }
        private void Dashboard_Control_Load(object sender, EventArgs e)
        {
            //tileClass1.Visible = false;
            //tileClass2.Visible = false;
            //tileClass3.Visible = false;
            //tableLayoutPanel1.Visible = false;
            DoubleBuffered = true;
            foreach (var ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl is TileClass)
                {
                    TileClass tileClass = (TileClass)ctrl;

                    tileClass.Visible = false;


                    //chbx.CheckedChanged += new EventHandler(check_changed);
                    //chbx.CheckStateChanged += new EventHandler(_checkedStateChanged);
                }
            }
        }

        string Parameter_Name;
        string Param_Value;
        string Param_Unit;
        string data;
        private async void Dashboard_textBox_TextChanged (object sender, EventArgs e)
        {
            #region commented
            /*
            string count = null;
            
            if (data.IndexOf("count") > -1)
            {
                count = data.Substring(data.IndexOf(':') + 1);  //@503:count:5
                 MessageBox.Show(count);
            }
            
            int _count = int.Parse(count);

            int NamingNumber = 1;

            foreach (var ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl is TileClass)
                {
                    TileClass tileClass = (TileClass)ctrl;

                    for (int i = 1; i == _count; i++)
                    {
                        if (_order == i)
                        {
                            tileClass.Name = tileClass.Text.ToString() + NamingNumber++;
                            tileClass.Visible = true;

                            //tile.Visible = true;
                        }
                        //tile.Name = tile.Text.ToString() + NamingNumber++;

                    }


                    //chbx.CheckedChanged += new EventHandler(check_changed);
                    //chbx.CheckStateChanged += new EventHandler(_checkedStateChanged);
                }
            }
            for (int i = 1; i < _count; i++)
            {
                tileClass1.Visible = true;
            }
            int currentNamingNumber = 1;

            int i, j;

            private void xx()
            {
                Button My_btn = new Button();


                My_btn.BackColor = Color.Gray;
                //btnAdd.Text = textBox1.Text.ToString() + currentNamingNumber++;
                My_btn.Text = textBox1.Text.ToString();// + currentNamingNumber++;

                My_btn.Name = textBox1.Text.ToString() + currentNamingNumber++;

                My_btn.Location = new System.Drawing.Point(i, j);
                My_btn.Size = new System.Drawing.Size(50, 25);
                this.Controls.Add(My_btn);
                i = i + 0;
                j = j + 40;
            } 

    */
            #endregion
            
            //string data = Dashboard_textBox.Text; // 5:Rel. Hum.:60,000:%
            data = Dashboard_textBox.Text; // 5:Rel. Hum.:60,000:%
            string main_data = data;
            string order = data.Substring(0, data.IndexOf(':'));
            //int _order = int.Parse(order);

            data = data.Remove(0, data.IndexOf(':') + 1); // Relative Humidity:60,000:%
            
            try
            {
                void TileChange_Method (TileClass tileObject) // by default a private method
                {
                    //string Parameter_Name;
                    Parameter_Name = data.Remove(data.IndexOf(':')); // Relative Humidity
                    tileObject.ParameterLabel.Text = Parameter_Name;

                    //string Param_Value;
                    data = data.Remove(0, data.IndexOf(':') + 1); // 60,000:%
                    Param_Value = data.Remove(data.IndexOf(':')); // 60,000
                    tileObject.ValueLabel.Text = Param_Value;

                    //string Param_Unit;
                    data = data.Remove(0, data.IndexOf(':') + 1); // %
                    Param_Unit = data;
                    tileObject.UnitLabel.Text = data;

                    if (Parameter_Name == "Temperature" || Parameter_Name == "Temp" || Parameter_Name == "Temp.")
                    {
                        tileObject.UnitLabel.Text = "℃";
                        tileObject.ParameterIcon.Image = tileObject.ImageList1.Images[0];
                    }
                    else if (Parameter_Name == "Relative Humidity" || Parameter_Name == "Humidity")
                    {
                        tileObject.ParameterIcon.Image = tileObject.ImageList1.Images[1];
                    }
                    else if (Parameter_Name == "Wind Speed" || Parameter_Name == "Speed" || Parameter_Name == "Wind Velocity")
                    {
                        tileObject.ParameterIcon.Image = tileObject.ImageList1.Images[2];
                    }
                    else if (Parameter_Name == "Water Level" || Parameter_Name == "Water")
                    {
                        tileObject.ParameterIcon.Image = tileObject.ImageList1.Images[3];
                    }
                    else if (Parameter_Name == "CO2 Level" || Parameter_Name == "CO2")
                    {
                        tileObject.ParameterIcon.Image = tileObject.ImageList1.Images[4];
                        tileObject.UnitLabel.Font = new Font("Century Gothic", 15F);
                    }
                    else if (Parameter_Name == "Solar Radiation" || Parameter_Name == "Radiation")
                    {
                        tileObject.ParameterIcon.Image = tileObject.ImageList1.Images[5];
                        tileObject.UnitLabel.Font = new Font("Century Gothic", 15F);
                    }
                    else if (Parameter_Name == "Wind Direction" || Parameter_Name == "WindDirection")
                    {
                        tileObject.ParameterIcon.Image = tileObject.ImageList1.Images[6];
                        tileObject.UnitLabel.Font = new Font("Century Gothic", 17F);
                    }
                    else if (Parameter_Name == "Soil Moisture" || Parameter_Name == "SoilMoisture")
                    {
                        tileObject.ParameterIcon.Image = tileObject.ImageList1.Images[7];
                        tileObject.UnitLabel.Font = new Font("Century Gothic", 17F);
                    }
                    else if (Parameter_Name == "Rain Fall" || Parameter_Name == "Rainfall")
                    {
                        tileObject.ParameterIcon.Image = tileObject.ImageList1.Images[8];
                        tileObject.UnitLabel.Font = new Font("Century Gothic", 17F);
                    }

                    tileObject.Visible = true;
                    //ResumeLayout();
                }

                //this.SuspendLayout();

                if (order == "1")
                {
                    TileChange_Method(tileClass1);
                }
                else if (order == "2")
                {
                    TileChange_Method(tileClass2);
                }
                else if (order == "3")
                {
                    TileChange_Method(tileClass3);
                }
                else if (order == "4")
                {
                    TileChange_Method(tileClass4);
                }
                else if (order == "5")
                {
                    TileChange_Method(tileClass5);
                }
                else if (order == "6")
                {
                    TileChange_Method(tileClass6);
                }
                else if (order == "7")
                {
                    TileChange_Method(tileClass7);
                }
                else if (order == "8")
                {
                    TileChange_Method(tileClass8);
                }
                else if (order == "9")
                {
                    TileChange_Method(tileClass9);
                }
                else if (order == "10")
                {
                    TileChange_Method(tileClass10);
                }
                else if (order == "11")
                {
                    TileChange_Method(tileClass11);
                }
                else if (order == "12")
                {
                    TileChange_Method(tileClass12);
                }
                else if (order == "13")
                {
                    TileChange_Method(tileClass13);
                }
                else if (order == "14")
                {
                    TileChange_Method(tileClass14);
                }
                else if (order == "15")
                {
                    TileChange_Method(tileClass15);
                }
                else if (order == "16")
                {
                    TileChange_Method(tileClass16);
                }
                else if (order == "17")
                {
                    TileChange_Method(tileClass17);
                }
                else if (order == "18")
                {
                    TileChange_Method(tileClass18);
                }
                else if (order == "19")
                {
                    TileChange_Method(tileClass19);
                }
                else if (order == "20")
                {
                    TileChange_Method(tileClass20);
                }
                
                await Task.Delay(700);

                Form1._dashboard_Loading_Form.Hide();
                tableLayoutPanel1.Visible = true;


            }
            catch (Exception)
            {


            }
            
        }

        
    }
}
