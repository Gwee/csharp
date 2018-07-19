using System;
using System.Windows.Forms;

namespace UserControl_Different_Controls
{
	public class myEventArgs : EventArgs
	{
        public Control mControl;
        public myEventArgs(Control tControl)
		{
            mControl = tControl ;
		}
	}
}
