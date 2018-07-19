using System;
using System.IO;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;  
				
namespace Serialization
{
	[Serializable]
	public class A
	{
        private char a;

        public char getSet_A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

		public A (char aa)
		{
			a = aa;
		}
		public A() {}
		public override string ToString()
		{	
			return a.ToString();
		}
	}

	[Serializable]
	public class B
	{
        public int b;
        public A aField;

		public B(char aa, int bb) 
		{	aField = new A(aa);
			b = bb;
		}
		public B() {}

		public override string ToString()
		{	
			return aField.ToString() + "  " + b.ToString();
		}
	}

	[Serializable]
	public class C : B
	{
        public string c; 
		public C (char aa, int bb, string cc): base(aa, bb)
		{
			c = cc;
		}
		public C() {}
		public override string ToString()
		{	
			return aField.ToString()+ " " + b.ToString() + " " + c;
		}
	}

	class Class1
	{
        //public static void Main(string[] args)
        //{
        //    C myC = new C('c', 11111, "cccccc");

        //    Stream myStream_Write = File.OpenWrite("1.xml");
        //    XmlSerializer myXmlSerializer = new XmlSerializer(typeof(C));
        //    myXmlSerializer.Serialize(myStream_Write, myC);
        //    myStream_Write.Close();

        //    C myC_1;
        //    Stream myStream_Read = File.OpenRead("1.xml");
        //    myC_1 = (C)myXmlSerializer.Deserialize(myStream_Read);
        //    myStream_Read.Close();

        //    Console.WriteLine(myC_1);
        //    Console.Read();
        //}


       public static void Main(string[] args)
        {
            ArrayList myArray = new ArrayList();
            myArray.Add(new A('a'));
            myArray.Add(new B('b', 222));
            myArray.Add(new C('c', 3333, "cccc"));

            Stream myStream_Write = File.Create("1.xml");
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(A) , typeof(B), typeof(C) });
            myXmlSerializer.Serialize(myStream_Write, myArray);
            myStream_Write.Close();

            ArrayList myArray_1;  
            Stream myStream_Read = File.OpenRead("1.xml");
            myArray_1 = (ArrayList)myXmlSerializer.Deserialize(myStream_Read);
            myStream_Read.Close();
            foreach(object o in myArray_1)
                Console.WriteLine(o);
            Console.Read();
        }
	}
}
