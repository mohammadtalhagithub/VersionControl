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
    public partial class frmMessageOK : Form
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

        //private int borderSize = 1;

        public static Label _lblMessage;

        public frmMessageOK()
        {
            InitializeComponent();

            _lblMessage = lblMessage;
            _Width = Width;
            _Height = Height;
            PictureBox = pictureBox;
            //Padding = new Padding(borderSize);
        }

        //private int customWidth;// = _Width;
        public static int _Width;
        public static int _Height;

        public static PictureBox PictureBox;

        // Properties //
        [Category("Category 1")]
        public int CustomWidth
        {
            get { return this.Width; }
            set { this.Width = value; }
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

        

        

        //public int _Width
        //{
        //    get { return Width; }
        //    set { Width = value; }
        //}

        //public int _Height
        //{
        //    get { return Height; }
        //    set { Height = value; }
        //}

        //[Category("CustomSize")]
        //[Description("Sets the width of dialogue"), Category("CustomSize")]


    }
}
