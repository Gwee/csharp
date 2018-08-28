using System;
using System.Windows.Forms;

namespace Event_RGBi_Square_Rectangle_Manager
{
    public class myEventArgs : EventArgs
    {
        public Control[] arrControls;
        public myEventArgs(Control[] tControls)
        {
            arrControls = tControls;
        }
    }
}
