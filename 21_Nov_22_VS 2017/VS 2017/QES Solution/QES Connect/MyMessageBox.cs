using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QES_Connect
{
    /// <summary>
    /// This is a custom Class
    /// </summary>
    public static class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            //frmMessageOK._lblMessage.Left = left;
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (frmMessageOK msgOK = new frmMessageOK())
                    {
                        msgOK.Text = caption;
                        msgOK.Message = message;
                        
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgOK.MessageIcon = Properties.Resources.Information_PNG;
                                break;

                            case System.Windows.Forms.MessageBoxIcon.Error:
                                {
                                    msgOK.MessageIcon = Properties.Resources.Cross_PNG;
                                    if (frmMessageOK._lblMessage.Text == "Device is  not connected...!")
                                    {
                                        frmMessageOK._lblMessage.Left = 123;
                                        frmMessageOK._lblMessage.Top = 38;
                                        
                                        frmMessageOK._Width = 323;
                                    }
                                    else if (frmMessageOK._lblMessage.Text == "No Device Detected...!\n\nMake sure that USB is connected.")
                                    {
                                        frmMessageOK._lblMessage.Left = 115;
                                        frmMessageOK._lblMessage.Top = 22;
                                        frmMessageOK.PictureBox.Left = 25;
                                    }
                                    break;
                                }
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgOK.MessageIcon = Properties.Resources.Question_PNG;
                                break;
                        }
                        dlgResult = msgOK.ShowDialog();
                    }
                    break;

                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (frmMessageYesNo msgYesNo = new frmMessageYesNo())
                    {
                        msgYesNo.Text = caption;
                        msgYesNo.Message = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgYesNo.MessageIcon = Properties.Resources.Information_PNG;
                                break;

                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgYesNo.MessageIcon = Properties.Resources.Cross_PNG;
                                break;

                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgYesNo.MessageIcon = Properties.Resources.Question_PNG;
                                break;
                        }
                        dlgResult = msgYesNo.ShowDialog();
                    }
                    break;

            }
            return dlgResult;
        }
    }
}
