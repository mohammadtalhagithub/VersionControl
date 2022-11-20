using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace QES_Connect
{
    class ResponsiveClass
    {
        /// <summary>
        /// This is (Screen Area - TaskBar Area) in pixels.
        /// </summary>
        public static Rectangle area;

        public static int working_width;

        public static int working_height;

        //public static int Xfactor;
        //public static int Yfactor;

        //public static int SizeX;
        //public static int SizeY;

        //public static int dx;
        //public static int dy;



    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application ( Its name must be Main only, not anything else ).
        /// </summary>
        [STAThread]
        static void Main ()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(true);

                Form myForm = new Form();
                Screen myScreen = Screen.FromControl(myForm);
                ResponsiveClass.area = myScreen.WorkingArea; //(Screen Area - TaskBar Area)

                ResponsiveClass.working_width = ResponsiveClass.area.Width; // Developed at 1366
                ResponsiveClass.working_height = ResponsiveClass.area.Height; // Developed at 738 //(Screen Height - TaskBar Height)

                //ResponsiveClass.Xfactor = 20; // ~ 1366/30 = 45.53333 = Xfactor
                //ResponsiveClass.Yfactor = 25; // ~ 738/30 = 24.6 = Yfactor

                //ResponsiveClass.SizeX = ResponsiveClass.working_width - ResponsiveClass.working_width / ResponsiveClass.Xfactor;
                //ResponsiveClass.SizeY = ResponsiveClass.working_height - ResponsiveClass.working_height / ResponsiveClass.Yfactor;


                if (ResponsiveClass.working_width > 1366)// And working height = 1032 of 1080
                {
                    if (ResponsiveClass.working_height >= 1000 && ResponsiveClass.working_height <= 1032)
                    {
                        //Page_Title_Label.ForeColor = Color.Red;


                    }
                }

                //Application.Run(new Splash());

                //Application.Run(new SplashScreen());

                Application.Run(new Form1());
                
            }
            catch// (Exception)
            {

                //throw;
            }
        }

        
    }
}
