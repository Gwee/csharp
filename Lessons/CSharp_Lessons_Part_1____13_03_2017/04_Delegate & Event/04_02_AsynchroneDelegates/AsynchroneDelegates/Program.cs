using System;
using System.Collections.Generic;
using System.Text;

namespace AsynchroneDelegates
{
    public delegate void simpleDelegate(int bound);

    class Program
    {
        public static void function1(int bound)
        {
            for (int i = 0; i < bound; i++)
                Console.Write("+");
        }
        public static void function2(int bound)
        {
            for (int i = 0; i < bound; i++)
                Console.Write("#");
        }

        static void Main(string[] args)
        {
 //         function1(500);
 //         function2(500);

            simpleDelegate mysimpleDelegate_1 = new simpleDelegate(function1);
            simpleDelegate mysimpleDelegate_2 = new simpleDelegate(function2);

//          mysimpleDelegate_1(500);
//          mysimpleDelegate_2(500);

//          mysimpleDelegate_1.Invoke(500);
//          mysimpleDelegate_2.Invoke(500);

            mysimpleDelegate_1.BeginInvoke(500, null, null);
            mysimpleDelegate_2.BeginInvoke(500, null, null);

            Console.Read();
       }
    }
}
