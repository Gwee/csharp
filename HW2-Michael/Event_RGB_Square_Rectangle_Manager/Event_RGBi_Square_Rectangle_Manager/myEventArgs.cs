using System;
using System.Windows.Forms;

namespace Event_RGBi_Square_Rectangle_Manager
{
    public class myEventArgs : EventArgs
    {
        public UserControl1 userControl;
        public Form form;

        public myEventArgs(Form form, UserControl1 userControl)
        {
            this.form = form;
            this.userControl = userControl;
        }
    }
}
