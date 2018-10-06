using System;
using System.Windows.Forms;

namespace Event_RGBi_Square_Rectangle_Manager
{
    public class myEventArgs : EventArgs
    {
        public Control[] arrControls;
        public UserControl1 uc;
        public Form form;
        public myEventArgs(Control[] tControls)
        {
            arrControls = tControls;
        }
        public myEventArgs(UserControl1 uc, Form form)
        {
            this.uc = uc;
            this.form = form;
        }
    }
}
