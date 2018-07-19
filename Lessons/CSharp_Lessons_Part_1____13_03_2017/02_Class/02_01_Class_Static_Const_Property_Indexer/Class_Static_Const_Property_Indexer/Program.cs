using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Static_Const_Property_Indexer
{
    class SimpleClass
    {
        private int a;
        private int b = 10;
        private static int c;
        private const int d = 5;
        private readonly int e;
        private static readonly int f;

        public SimpleClass() { }   // public SimpleClass() : this(0, 0, 0){ }
        public SimpleClass(int aa, int bb, int ee)
        {
            a = aa; b = bb; e = ee;
        }
        public SimpleClass(int aa, int bb)
            : this(aa, bb, 0)
        {
        }
        public SimpleClass(SimpleClass mySC)
        {
            a = mySC.a; b = mySC.b; e = mySC.e;
        }


        public void Print()
        {
            Console.WriteLine("Print:   a= {0} b= {1}  c= {2}  d= {3} e= {4}", a, b, c, d, e);
        }

        static SimpleClass()
        {
            c = DateTime.Now.Second;
            f = 10;
        }
        static public void StaticPrint()
        {
            Console.WriteLine("Static Print:   c= {0} d= {1} f= {2}", c, d, f);
        }
        public int fieldA			// Property
        {
            get
            {
                return a;
            }
            private set
            {
                a = value;
            }
        }
        public static int fieldC		// Static Property
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public static int fieldF		// Static Get Property
        {
            get
            {
                return f;
            }
        }

        public int this[int index]		// Indexer
        {
            get
            {
                switch (index)
                {
                    case 0: return a;
                    case 1: return b;
                    case 2: return c;
                    case 3: return d;
                    case 4: return e;
                    default: return 0;
                }
            }
            set
            {
                switch (index)
                {
                    case 0: a = value; break;
                    case 1: b = value; break;
                    case 2: c = value; break;
                }
            }
        }

        public int this[string field]		// Indexer
        {
            get
            {
                switch (field)
                {
                    case "a": return a;
                    case "b": return b;
                    case "c": return c;
                    case "d": return d;
                    case "e": return e;
                    default: return 0;
                }
            }
         }


        static void Main()
        {
            StaticPrint();				// Static Print: c= 26 d= 5 f = 10
            SimpleClass.StaticPrint();	// Static Print: c= 26 d= 5 f = 10

            SimpleClass A;
            A = new SimpleClass();
            A.Print();					// Print: a= 0 b= 10 c= 32 d= 5 e= 0
            //		A.StaticPrint();			//Error:   SimpleClass.StaticPrint()' cannot be accessed with an instance reference

            SimpleClass B;
            B = new SimpleClass(1, 2, DateTime.Now.Second);
            B.Print();					// Print: a= 1 b= 2 c= 32 d= 5 e= 33

            B.fieldA = 1111;
            SimpleClass.fieldC = 2222;
            B.Print();					// Print: a= 1111 b= 2 c= 2222 d= 5 e= 33

            B[0] = B[1] = B[2] = 3333;
            Console.WriteLine("a= {0} b= {1}  c= {2}  d= {3} e= {4}", B[0], B[1], B[2], B[3], B[4]);
            // a= 3333 b= 3333 c= 3333 d= 5 e= 33
            Console.WriteLine("a= {0} b= {1}  c= {2}  d= {3} e= {4}", B["a"], B["b"], B["c"], B["d"], B["e"]);
            // a= 3333 b= 3333 c= 3333 d= 5 e= 33

            SimpleClass C = new SimpleClass(A);
            C.Print();					// // Print: a= 0 b= 10 c= 3333 d= 5 e= 0

            Console.ReadLine();
        }
    }
}