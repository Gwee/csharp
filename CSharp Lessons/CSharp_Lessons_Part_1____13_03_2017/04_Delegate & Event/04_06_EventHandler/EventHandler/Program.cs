using System;
using System.Collections.Generic;
using System.Text;

namespace _EventHandler_
{
    public class Simple
    {
        public event EventHandler ActionEvent;
        public void onEvent()
        {
            if (ActionEvent == null)
                Console.WriteLine("Empty Event");
            else
                ActionEvent(this, EventArgs.Empty);
        }
        public void function_1(object sender, EventArgs e)
        {
            Console.Write("Function_1 works\n");
        }
        static public void function_2(object sender, EventArgs e)
        {
            Console.Write("Function_2 works\n");
        }
    }

    public class Test
    {
        static public void function_3(object sender, EventArgs e)
        {
            Console.Write("Function_3 works\n");
        }

        static public void Main()
        {
            Simple mySimple = new Simple();
            mySimple.onEvent();				// Empty Event

            mySimple.ActionEvent += new EventHandler(mySimple.function_1);
            mySimple.ActionEvent += new EventHandler(Simple.function_2);
            mySimple.ActionEvent += new EventHandler(function_3);

            mySimple.onEvent();
        }
    }
}
