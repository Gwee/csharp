using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Drawing;
using System.Collections;

namespace Common
{
    [Serializable]
    public class TypeSizeColor
    {
        public string mType;
        public Size mSize;
        public Color mColor;
    }

    public interface ICommon
    {
        void add_Client(TypeSizeColor[] arrTypeSizeColor);
        TypeSizeColor[] getData(bool isSquare, int prevCounter);
    }
}
