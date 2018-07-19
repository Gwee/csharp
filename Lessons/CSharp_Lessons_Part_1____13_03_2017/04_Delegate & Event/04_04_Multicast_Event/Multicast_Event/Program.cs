using System;
using System.Collections.Generic;
using System.Text;

namespace Multicast_Event
{
    public delegate void ActionDelegate(double a, double b);

    public class Simple
    {
        public event ActionDelegate ActionEvent;
        public void onEvent(double a, double b)
        {
            if (ActionEvent == null)
                Console.WriteLine("Empty Event");
            else
                ActionEvent(a, b);
        }
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

        static public void Main()
        {
            Simple mySimple = new Simple();
            mySimple.onEvent(1, 2);				// Empty Event

            mySimple.ActionEvent += new ActionDelegate(mySimple.plus);
            mySimple.ActionEvent += new ActionDelegate(Simple.minus);
            mySimple.ActionEvent += new ActionDelegate(multiply);
            // operator +=, operator -=

            mySimple.onEvent(1, 2);
        }
    }
}
