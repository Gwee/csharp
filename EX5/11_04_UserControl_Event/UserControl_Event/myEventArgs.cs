using System;

namespace UserControl_Event
{
	public class myEventArgs : EventArgs
	{
		private string str;
		public myEventArgs(string S)
		{
			str = S;
		}
		public string myString
		{
			get
			{
				return str;
			}
		}
	}
}
