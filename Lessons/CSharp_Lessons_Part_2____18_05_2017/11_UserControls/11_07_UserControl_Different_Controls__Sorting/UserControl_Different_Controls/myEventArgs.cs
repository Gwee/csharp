using System;
using System.Windows.Forms;

namespace UserControl_Different_Controls
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
