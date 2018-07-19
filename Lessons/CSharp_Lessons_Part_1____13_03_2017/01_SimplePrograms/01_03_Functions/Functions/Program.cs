using System;
using System.Collections.Generic;
using System.Text;

namespace Functions
{
    class Program
    {
        static public void Fun_ByValue(int a)
        {
            a += 10;
        }
        static public void Fun_ByReference(ref int a)
        {
            a += 10;
        }
        static public void Fun_ByOut(out int a)
        {
            // a += 10; Error: Use of unassigned local variable
            a = 1000;
        }

        static public void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0} ", arr[i]);
        }

        static public void Print_Ellipses(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0} ", arr[i]);
        }

        static public void Print_Ellipses_Objects(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0} ", arr[i].ToString());
            Console.WriteLine();
        }

        static public void Main()
        {
            int a = 5;
            Program.Fun_ByValue(a);
            Console.WriteLine(a);				// 5
            Fun_ByReference(ref a);
            Console.WriteLine(a);				// 15
            Fun_ByOut(out a);
            Console.WriteLine(a);				// 1000

            int b;
            //	Fun_ByValue ( b );			Error: Use of unassigned local variable
            //	Fun_ByReference ( ref b );  Error: Use of unassigned local variable
            Fun_ByOut(out b);
            Console.WriteLine(b);				        // 1000

            int[] arr1 = {0, 10, 20, 30, 40};
            PrintArr(arr1);
            Console.WriteLine();						        // 0 10 20 30 40
 
            Print_Ellipses(100, 200, 300, 400);			// 100 200 300 400
            Console.WriteLine();
            Print_Ellipses_Objects(1, 22.2222, "abcdef");	// 1  22.2222  abcdef 

            Console.ReadLine();
        }
    }
}
