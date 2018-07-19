using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace is_GetType
{
    class A
    {
    }
    class B : A
    {
    }

    class Test
    {
        static void Main()
        {
            A myA = new A(), AA;
            B myB = new B();

            AA = myA;
            if (AA is A)
                Console.WriteLine("1");
            if (AA.GetType().Name == "A")
                Console.WriteLine("2");

            AA = myB;
            if (AA is A)
                Console.WriteLine("3");
            if (AA.GetType().Name == "A")
                Console.WriteLine("4");
            if (AA.GetType().Name == "B")
                Console.WriteLine("5");

            Console.ReadKey();
        }
    }
}
