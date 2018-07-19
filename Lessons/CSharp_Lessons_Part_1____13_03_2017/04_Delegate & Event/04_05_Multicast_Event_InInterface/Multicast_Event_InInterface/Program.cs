using System;
using System.Collections.Generic;
using System.Text;

namespace Multicast_Event_InInterface
{
    public delegate void ActionDelegate(double a, double b);

    public interface SimpleInterface
    {
        event ActionDelegate ActionEvent;
        void onEvent(double a, double b);
    }

    public class SimpleClass : SimpleInterface
    {
        public event ActionDelegate ActionEvent;
        public void onEvent(double a, double b)
        {
            if (ActionEvent == null)
                Console.WriteLine("Empty Event");
            else
                ActionEvent(a, b);
        }
    }

    public class Test
    {
        static public void plus(double a, double b)
        {
            Console.Write("{0} + {1} = {2}\t", a, b, a + b);
        }
        static public void minus(double a, double b)
        {
            Console.Write("{0} - {1} = {2}\t", a, b, a - b);
        }
        static public void multiply(double a, double b)
        {
            Console.Write("{0} * {1} = {2}\t", a, b, a * b);
        }
        static public void divide(double a, double b)
        {
            Console.Write("{0} / {1} = {2}\t", a, b, a / b);
        }

        static public void Main()
        {
            SimpleInterface myInterf = new SimpleClass();
            myInterf.onEvent(1, 2);				// Empty Event

            myInterf.ActionEvent += new ActionDelegate(plus);
            myInterf.ActionEvent += new ActionDelegate(minus);
            myInterf.ActionEvent += new ActionDelegate(multiply);
            myInterf.ActionEvent += new ActionDelegate(divide);
            myInterf.onEvent(1, 2);
        }
    }
}
