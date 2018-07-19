using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Simple_Thread_ParametrizadedThreadStart
{
    class myClass
    {
        public string str;
        public int counter;
        public myClass(string s, int c) { str = s; counter = c; }
    };

    class Program
    {
        static public void myFunction(object obj)
        {
            myClass tempMyClass = (myClass)obj;
            for (int i = 0; i < tempMyClass.counter; i++)
                Console.Write(" " + tempMyClass.str);
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(myFunction);
            Thread t2 = new Thread(myFunction);

//            Thread t1 = new Thread(new ParameterizedThreadStart(myFunction));
//            Thread t2 = new Thread(new ParameterizedThreadStart(myFunction));          
            
            t1.Start(new myClass("+", 500));
            t2.Start(new myClass("#", 100));
            Console.Read();
        }
    }
}
