using System;
using System.Drawing;

namespace UserControl_Different_Controls
{
	public class myEventArgs : EventArgs
	{
		public string mText;
        public Type mType;
        public Color mBackColor;
        public Font mFont;
        public Size mSize;

        public myEventArgs(string tText, Type tType, Color tBackColor, Font tFont, Size tSize)
		{
            mText = tText;
            mType = tType;
            mBackColor = tBackColor;
            mFont = tFont;
            mSize = tSize;
		}
	}
}
