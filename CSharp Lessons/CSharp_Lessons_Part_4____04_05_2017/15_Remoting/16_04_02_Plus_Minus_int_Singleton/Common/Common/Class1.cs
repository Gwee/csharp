using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Drawing;
using System.Collections;

namespace Common
{
    public interface ICommon 
    {
        int Plus(int a, int b);
        int Minus(int a, int b);
        int CommonSum();
        void Reset();
    }
}
