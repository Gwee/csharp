using System;
using System.Collections.Generic;
using System.Text;

namespace Declarations
{
    class Declarations
    {
        public int a_member;

        static void Main()
        {
            int a, b = 2;
            //		Console.WriteLine(a); - Compile Error: Use of unassigment local variable

            Declarations myD = new Declarations();
            Console.WriteLine(myD.a_member);  // 0 - a_member without initialization

            a = 5;		// int a = 5;
            Console.WriteLine(a);									   // 5
            Console.WriteLine("a =  " + a.ToString());				   // a = 5
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);		   // 5 + 2 = 7
            Console.WriteLine("{0:D} + {1:D} = {2:D}", a, b, a + b);   // 5 + 2 = 7
            Console.WriteLine("{0,4:D} + {1,4:D} = {2,4:D}", a, b, a + b);
            //     5 +    2 =    7 
            Console.WriteLine("{0,-4:D} + {1,-4:D} = {2,-4:D}", a, b, a + b);
            // 5    + 2    = 7 
  
            string c = "1111", d = "22";
            a = int.Parse(c) + int.Parse(d);		// String --> int
            Console.WriteLine(a);			// 1133
            Console.WriteLine(c + d);			// 111122
 
            object f;
            f = 123; Console.WriteLine(f);
            f = "abcdef"; Console.WriteLine(f);

            // Arrays
            int[] arr1;
            arr1 = new int[] { 10, 20, 30 };			// arr1 = {10, 20, 30} - Error
            Console.WriteLine(arr1);			// System.Int32[]
            Console.WriteLine("{0} {1} {2}", arr1[0], arr1[1], arr1[2]); //10 20 30

            int[] arr2 = new int[3];
            Console.WriteLine("{0} {1} {2}", arr2[0], arr2[1], arr2[2]);   // 0 0 0

            int[] arr3 = { 10, 20, 30 };
            Console.WriteLine("Array size = {0}", arr3.Length);
            Console.WriteLine("{0} {1} {2}", arr3[0], arr3[1], arr3[2]); //10 20 30

            int[] arr4;
            arr4 = new int[] { 30, 10, 40, 20 };
            Console.WriteLine("{0} {1} {2} {3}", arr4[0], arr4[1], arr4[2], arr4[3]);
            // 30 10 40 20
            Array.Sort(arr4);
            Console.WriteLine("{0} {1} {2} {3}", arr4[0], arr4[1], arr4[2], arr4[3]);
            // 10 20 30 40

            // Multidimensional Arrays
            int[,] matr1 = new int[3, 4];
            int[,] matr2 = { { 10, 20 }, { 30, 40 } };
            // int[,] matr2 = {{10, 20 }, {30}} - Error
            Console.WriteLine("{0} {1} \n{2} {3}",
                    matr2[0, 0], matr2[0, 1], matr2[1, 0], matr2[1, 1]);
            int[,] matr3;
            matr3 = new int[,] { { 10, 20 }, { 30, 40 } };
            // matr3 = {{10, 20 }, {30, 40 }};  - Error

            // Jagged Arrays ( array whose elements are arrays )
            int[][] matr4 = new int[2][];		// ... = new int [3][2] - Error
            matr4[0] = new int[2];				// matr4[0] = { 10, 20 } - Error
            matr4[0][0] = 10; matr4[0][1] = 20;
            matr4[1] = new int[3] { 30, 40, 50 };

            Console.ReadLine();
        }
    }
}
