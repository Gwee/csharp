using System;
using System.Collections.Generic;
using System.Threading;

namespace Even_Odd_Waite_Pulse
{
    class Program
    {
        public Program()
		{
			Thread  thread_1 = new Thread(ThreadFunc_1);
			thread_1.Name = "First";
			thread_1.Start();

			Thread  thread_2 = new Thread( ThreadFunc_2);
			thread_2.Name = "Second";
			thread_2.Start();
		}

		public void ThreadFunc_1 ()
		{
			for (int i=1; i<=100; i+=2) 
			{
				lock (this)
				{
                    Thread.Sleep(1);
					Console.Write (i.ToString() + " ");  
				}			
			}
		}
		public void ThreadFunc_2 ()
		{
			for (int i=2; i<=100; i+=2) 
			{
				lock (this)
				{
                    Thread.Sleep(1);
					Console.Write (i.ToString() + " ");  
				}
			}
		}


        static void Main(string[] args)
        {
            Program myClass1 = new Program();
            Console.Read();
        }
    }
}
