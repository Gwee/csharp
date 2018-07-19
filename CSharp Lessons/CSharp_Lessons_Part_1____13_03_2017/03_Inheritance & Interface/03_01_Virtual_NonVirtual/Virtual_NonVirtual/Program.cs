using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_NonVirtual
{
    public class A
    {
        protected int a;
        public A(int aa)
        {
            a = aa;
        }
        public void funct_1()
        {
            Console.WriteLine("Funct_1 from A  a = {0}", a);
        }
        virtual public void funct_2()
        {
            Console.WriteLine("Funct_2 from A  a = {0}", a);
        }
        virtual public void funct_3()
        {
            Console.WriteLine("Funct_3 from A  a = {0}", a);
        }
    }
    public class B : A
    {
        private int b;
        public B(int aa, int bb)
            : base(aa)
        {
            b = bb;
        }
        new public void funct_1()
        {
            Console.WriteLine("Funct_1 from B  a = {0} b= {1}", a, b);
        }
        override public void funct_2()
        {
            Console.WriteLine("Funct_2 from B  a = {0} b= {1}", a, b);
        }
        new public void funct_3()
        {
            Console.WriteLine("Funct_3 from B  a = {0} b= {1}", a, b);
        }
    }

    public class Test
    {
        static void Main()
        {
            A myA = new A(1), AA;
            B myB = new B(2, 3);

            myA.funct_1();   // Funct_1 from A  a = 1
            myA.funct_2();   // Funct_2 from A  a = 1
            myA.funct_3();   // Funct_3 from A  a = 1
            myB.funct_1();   // Funct_1 from B  a = 2  b = 3
            myB.funct_2();   // Funct_2 from B  a = 2  b = 3
            myB.funct_3();   // Funct_3 from B  a = 2  b = 3

            AA = myA;
            AA.funct_1();   // Funct_1 from A  a = 1
            AA.funct_2();   // Funct_2 from A  a = 1
            AA.funct_3();   // Funct_3 from A  a = 1

            AA = myB;
            AA.funct_1();   // Funct_1 from A  a = 2
            AA.funct_2();   // Funct_2 from B  a = 2  b = 3
            AA.funct_3();   // Funct_3 from A  a = 2

 //           Console.WriteLine(AA is B);
 //           Console.WriteLine(AA is A);
 ////           if (AA.GetType() == myB.GetType())
 //           if (AA.GetType().Name == "B")
 //               ((B)AA).funct_3();
        }
    }
}
