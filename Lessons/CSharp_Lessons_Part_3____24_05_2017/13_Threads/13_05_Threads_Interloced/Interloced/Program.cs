using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Interloced
{
    class Program
    {
        private const long counter = 10000000L, halfCounter = counter / 2;
        private long commonSum = 0;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            Thread t1 = new Thread(myProgram.myFunction1);
            //// Thread t1 = new Thread(new ThreadStart(myProgram.myFunction1));
            t1.Start();
            Thread t2 = new Thread(myProgram.myFunction2); 
            //// Thread t2 = new Thread(new ThreadStart(myProgram.myFunction2));
            t2.Start();

            while (t1.ThreadState == ThreadState.Running ||
                t2.ThreadState == ThreadState.Running)
                ;
            Console.WriteLine(myProgram.commonSum);
            Console.Read();
        }
        public void myFunction1()
        {
            for (long i = 1; i < halfCounter; i++)
    //            commonSum += i;
                Interlocked.Add(ref commonSum, i);
        }
        public void myFunction2()
        {
            for (long i = halfCounter; i <= counter; i++)
    //         commonSum += i;
                Interlocked.Add(ref commonSum, i);
        }
    }
}