using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public delegate int sumDelegate(int a, int b);

namespace Simple_AnonymousDelegate
{
    class Program
	{
		static void Main(string[ ] args)
		{
			int a = 1, b = 2, c;
 
            sumDelegate sd = delegate( int aa, int bb) { return aa + bb; } ;
            
            c = sd(a, b);
			Console.WriteLine("{0} + {1} = {2}",a, b, c);
		}
	}
}

