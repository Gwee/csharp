using System;
using System.Collections.Generic;
using System.Text;

namespace Multicast_Delegate
{
    public delegate void Action(double a, double b);

    public class Simple
    {
        public void plus(double a, double b)
        {
            Console.Write("{0} + {1} = {2}\n", a, b, a + b);
        }
        static public void minus(double a, double b)
        {
            Console.Write("{0} - {1} = {2}\n", a, b, a - b);
        }
    }
    public class Test
    {
        static public void multiply(double a, double b)
        {
            Console.Write("{0} * {1} = {2}\n", a, b, a * b);
        }
        public static void Main()
        {
            Action myAction;
            Simple mySimple = new Simple();
            myAction = new Action(mySimple.plus);
            myAction += new Action(Simple.minus);
            myAction += new Action(multiply);
            // operator =, operator+, operator +=, operator-, operator -=

            myAction(1, 2);
            Console.Read();
        }
    }
}
