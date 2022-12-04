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
    /// <summary>
    /// Graph_Control class inherits the properties of a UserControl class,
    /// hence inheritance (:) is used.
    /// </summary>
    public partial class Graph_Control : UserControl
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


        /// <summary>
        /// create this object in either Form1 Class, Program Class, or here only (as done below), and make a static variable
        /// of this object to access it from other User_Controls
        /// </summary>
        //ScalingClass sclass = new ScalingClass();
        //public static ScalingClass _sclass;        

        public Graph_Control()
        {
            InitializeComponent();

            //_sclass = sclass;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sclass.ScalingMethod().ToString());
        }

        private void Graph_Control_Load(object sender, EventArgs e)
        {
           
        }
    }
}
