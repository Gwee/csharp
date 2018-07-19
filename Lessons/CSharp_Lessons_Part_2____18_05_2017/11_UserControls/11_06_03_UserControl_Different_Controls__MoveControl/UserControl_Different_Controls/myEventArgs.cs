using System;
using System.Windows.Forms;

namespace UserControl_Different_Controls
{
	public class myEventArgs : EventArgs
	{
        public Control mControl;
        public UserControl1 mUserControl;
        public myEventArgs(Control tControl, UserControl1 mUC)
		{
            mControl = tControl ;
            mUserControl = mUC;
		}
	}
}
