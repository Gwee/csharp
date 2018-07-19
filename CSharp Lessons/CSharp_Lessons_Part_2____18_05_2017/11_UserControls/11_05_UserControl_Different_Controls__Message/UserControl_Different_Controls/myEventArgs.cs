using System;

namespace UserControl_Different_Controls
{
	public class myEventArgs : EventArgs
	{
		private string strText;
        private string strType;

        public myEventArgs(string sText, string sType)
		{
            strText = sText;
            strType = sType;
		}
        public string myStrText
        {
            get
            {
                return strText;
            }
        }
        public string myStrType
        {
            get
            {
                return strType;
            }
        }
	}
}
