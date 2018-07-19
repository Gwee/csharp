using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;

namespace Simple_Thread
{
    class Program
    {
        static void myFunction_1()
        {
            int counterFunction_1 = 0;
            while (counterFunction_1 < 100)
            {
                counterFunction_1++;
                Console.Write(" - " + counterFunction_1.ToString());
            }
        }
        void myFunction_2()
        {
            int counterFunction_2 = 0;
            while (counterFunction_2 < 100)
            {
                counterFunction_2++;
                Console.Write(" + " + counterFunction_2.ToString());
            }
        }

        void myFunction_3()
        {
            int counterFunction_3 = 0;
            while (counterFunction_3 < 100)
            {
                counterFunction_3++;
                Console.Write(" # " + counterFunction_3.ToString());
            }
        }
        static void Main(string[] args)
        {
   		Thread t1 = new Thread(myFunction_1);
		// Thread t1 = new Thread(new ThreadStart( myFunction_1));
		t1.Start();

            Program myProgram = new Program();
            Thread t2 = new Thread(myProgram.myFunction_2);
            //Thread t2 = new Thread(new ThreadStart(myProgram.myFunction_2));
            t2.Start();

            myProgram.myFunction_3();

            Console.Read();
		}
     }
}
