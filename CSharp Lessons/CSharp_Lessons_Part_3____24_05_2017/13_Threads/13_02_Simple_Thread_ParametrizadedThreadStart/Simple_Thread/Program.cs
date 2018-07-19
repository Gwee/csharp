using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;

namespace Simple_Thread
{
    class Program
    {
        static void myFunction(object o)
        {
            int counterFunction = 0;
            while (counterFunction < 100)
            {
                counterFunction++;
                Console.Write(" " + o.ToString() + " " + counterFunction.ToString());
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(myFunction);
            Thread t2 = new Thread(myFunction);
            Thread t3 = new Thread(myFunction);

//            Thread t1 = new Thread(new ParameterizedThreadStart(myFunction));
//            Thread t2 = new Thread(new ParameterizedThreadStart(myFunction));
//            Thread t3 = new Thread(new ParameterizedThreadStart(myFunction));

            t1.Start("+");
            t2.Start("-");
            t3.Start("#");

            Console.Read();
		}
     }
}
