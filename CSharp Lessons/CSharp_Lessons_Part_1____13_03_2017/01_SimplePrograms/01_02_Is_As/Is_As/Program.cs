using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Is_As
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = 123456;
            Console.WriteLine(o.GetType());		// System.Int32
            bool result = o is int;				// operator "is"
            Console.WriteLine(result);			// True

            o = "abcdef";
            //			string str = o;			// Error
            string str = o as string;			// operator "as"
            if (str == null)
                Console.WriteLine("o is not a string");
            else
                Console.WriteLine("o is a string {0}", str);

            o = 123;
            str = o as string;
            Console.WriteLine(str);				// Empty

        }
    }
}
