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
    public partial class frmMessageYesNo : Form
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

        public frmMessageYesNo()
        {
            InitializeComponent();

            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public Image MessageIcon
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        private void frmMessageYesNo_Load(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Yes;
        }
    }
}
