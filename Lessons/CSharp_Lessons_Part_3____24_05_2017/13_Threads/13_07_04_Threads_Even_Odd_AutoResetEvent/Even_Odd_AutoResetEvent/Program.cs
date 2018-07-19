using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Even_Odd_AutoResetEvent
{
    class Program
    {
		private AutoResetEvent AutoResetEvent_1 = new AutoResetEvent (true);
		private AutoResetEvent AutoResetEvent_2 = new AutoResetEvent (false);

		public Program()
		{
			Thread  thread_1 = new Thread(ThreadFunc_1);
			thread_1.Name = "First";
			thread_1.Start();

			Thread  thread_2 = new Thread(ThreadFunc_2);
			thread_2.Name = "Second";
			thread_2.Start();
		}
		public void ThreadFunc_1 ()
		{
			for (int i=1; i<=100; i+=2) 
			{
                AutoResetEvent_1.WaitOne();        
				Console.Write (i.ToString() + " ");  
				AutoResetEvent_2.Set ();            
			}
		}
		public void ThreadFunc_2 ()
		{
			for (int i=2; i<=100; i+=2) 
			{
				AutoResetEvent_2.WaitOne ();        
				Console.Write (i.ToString() + " ");  
				AutoResetEvent_1.Set ();            
			}
		}
		static void Main(string[] args)
		{
			Program myProgram = new Program();
			Console.Read();
		}
	}   
}
