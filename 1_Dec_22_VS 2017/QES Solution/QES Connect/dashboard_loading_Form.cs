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
    public partial class dashboard_loading_Form : Form
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


        public static PictureBox _loading_picBox;

        public static Label _label1;

        public dashboard_loading_Form()
        {
            InitializeComponent();

            _loading_picBox = loading_picBox;
            _label1 = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dashboard_loading_Form_Load(object sender, EventArgs e)
        {
            loading_picBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
