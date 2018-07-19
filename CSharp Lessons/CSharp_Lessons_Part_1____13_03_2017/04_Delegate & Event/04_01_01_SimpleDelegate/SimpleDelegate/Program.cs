using System;
using System.Collections.Generic;
using System.Text;

public delegate int sumDelegate(int a, int b);

namespace SimpleDelegate
{
    public class Test
    {
        static public int sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int a = 1, b = 2, c;
            c = sum(a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, c);

            sumDelegate mySumDelegate;
            mySumDelegate = new sumDelegate(sum);
            c = mySumDelegate(a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
        }
    }
}

