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
        void Plus (int a);
        void Minus(int a);
        int Sum();
        void Reset();
    }
    public interface ICommonFactory
    {
        ICommon getNewInstance();
    }
}
