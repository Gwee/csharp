using System;
using System.Collections.Generic;
using System.Text;

namespace Multicast_Delegate
{
    public delegate void Action(double a, double b);

    public class Simple
    {
        public Action myAction;
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
            Console.Write("{0} * {1} = {2}\t", a, b, a * b);
        }

        public static void Main()
        {
            Simple mySimple = new Simple();
            mySimple.myAction = new Action(mySimple.plus);
            mySimple.myAction += new Action(Simple.minus);
            mySimple.myAction += new Action(multiply);

            mySimple.myAction(1, 2);
            Console.Read();
        }
    }
}
