using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace First_Second_Third_AutoResetEvent
{
    class Program
    {
        private AutoResetEvent AutoResetEvent_1 = new AutoResetEvent(false);
        private AutoResetEvent AutoResetEvent_2 = new AutoResetEvent(false);
        private AutoResetEvent AutoResetEvent_3 = new AutoResetEvent(false);

        public Program()
		{
			Thread  thread_1 = new Thread( ThreadFunc_1);
			thread_1.Name = "First";
			thread_1.Start();

			Thread  thread_2 = new Thread( ThreadFunc_2);
			thread_2.Name = "Second";
			thread_2.Start();

            Thread thread_3 = new Thread(ThreadFunc_3);
            thread_3.Name = "Third";
            thread_3.Start();
		}
		public void ThreadFunc_1 ()
		{
			for (int i=1; i<=100; i+=3) 
			{
				Console.Write (i.ToString() + " ");  
				AutoResetEvent_2.Set ();            
				AutoResetEvent_1.WaitOne ();        
			}
		}
		public void ThreadFunc_2 ()
		{
			for (int i=2; i<=100; i+=3) 
			{
				AutoResetEvent_2.WaitOne ();        
				Console.Write (i.ToString() + " ");  
				AutoResetEvent_3.Set ();            
			}
		}
        public void ThreadFunc_3()
        {
            for (int i = 3; i <= 100; i += 3)
            {
                AutoResetEvent_3.WaitOne();        
                Console.Write(i.ToString() + " ");
                AutoResetEvent_1.Set();            
            }
        }
        
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            Console.Read();
        }
    }
}
