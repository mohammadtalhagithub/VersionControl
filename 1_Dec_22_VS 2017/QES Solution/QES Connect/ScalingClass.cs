using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QES_Connect
{
    public class ScalingClass
    {
        int working_width;
        int working_height;

        public int ScalingMethod()
        {
            Form myForm = new Form();
            Screen myScreen = Screen.FromControl(myForm);
            Rectangle area = myScreen.WorkingArea;

            working_width = area.Width; // Developed at 1366
            working_height = area.Height; // Developed at 738

            int Xfactor = 20; // ~ 1366/30 = 45.53333 = Xfactor
            int Yfactor = 25; // ~ 738/30 = 24.6 = Yfactor

            int SizeX = working_width - working_width / Xfactor;
            int SizeY = working_height - working_height / Yfactor;

            return working_width + working_height;
           
        }
        
        /// <summary>
        /// Constructor of ScalingClass, which is used to initialize the objects when they are created.
        /// </summary>
        /// <param name="msg">string variable "msg" passed as a parameter of the ScalingClass Constructor. Here
        /// no parameter is passed.
        /// </param>
        public ScalingClass()
        {
            //ScalingMethod();
            //MessageBox.Show("The WorkingArea is: " + working_width + ", " + working_height);
            
        }
    }
}
