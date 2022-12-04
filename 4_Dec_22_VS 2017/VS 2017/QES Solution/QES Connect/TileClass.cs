using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QES_Connect
{
    public partial class TileClass : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var tc = base.CreateParams;
                tc.ExStyle |= 0x02000000; // Turn ON WS_EX_COMPOSITED
                return tc;
            }
        }

        //public static TileClass instance;

        public TileClass()
        {
            InitializeComponent();

            //instance = this;
            //_imagelist1 = image_List1;
            //_ParamIcon = Param_Icon;

            //_Param_Label = Param_Label;
            //_Value_Label = Value_Label;
            //_Unit_Label = Unit_Label;
        }

        


        #region Public Properties of Controls

        /// <summary>
        /// This is Public Property of Param_Label private Object field of Label Class.
        /// </summary>
        public Label ParameterLabel
        {
            get { return Param_Label; }
            set { Param_Label = value; }
        }

        public Label ValueLabel
        {
            get { return Value_Label; }
            set { Value_Label = value; }
        }

        public Label UnitLabel
        {
            get { return Unit_Label; }
            set { Unit_Label = value; }
        }

        public PictureBox ParameterIcon
        {
            get { return Param_Icon; }
            set { Param_Icon = value; }
        }

        public ImageList ImageList1
        {
            get { return image_List1; }
            set { image_List1 = value; }
        }

        #endregion
        
        //[ComVisible(true)]
        //public enum TileResult
        //{
        //    //
        //    // Summary:
        //    //     Nothing is returned from the dialog box. This means that the modal dialog continues
        //    //     running.
        //    None = 0,
        //}




        //public Label _Param_Label;
        //public Label _Value_Label;
        //public Label _Unit_Label;
        //public PictureBox _ParamIcon;
        //public ImageList _imagelist1;






        //public System.Windows.Forms.DialogResult DialogResult { get; set; }

        //public TileClass ChangeParameters { get; set; }

        private void TileClass_Load(object sender, EventArgs e)
        {
            Param_Icon.BackColor = Color.Transparent;
        }
    }
}
