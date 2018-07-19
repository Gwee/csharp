using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
	[Serializable]
	public class A
	{
		private char a ;
  
    // [NonSerialized]
    // string tempString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

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
		protected int b;
		protected A aField ;

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
		private string c ; 
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
		public static void Main(string[] args)
		{
			A myA = new A('a');
			B myB = new B('b', 1111);
			C myC = new C('c', 2222, "cccccc");

			Stream myStream_Write = File.OpenWrite("1.txt");
			BinaryFormatter myBinaryFormatter = new BinaryFormatter();
			myBinaryFormatter.Serialize( myStream_Write ,myA);
			myBinaryFormatter.Serialize( myStream_Write ,myB);
			myBinaryFormatter.Serialize( myStream_Write ,myC);
			myStream_Write.Close();

			A myA_1 ;
			B myB_1 ;
			C myC_1 ;

			Stream myStream_Read = File.OpenRead("1.txt");
			myA_1 = (A)myBinaryFormatter.Deserialize(myStream_Read);
			myB_1 = (B)myBinaryFormatter.Deserialize(myStream_Read);
			myC_1 = (C)myBinaryFormatter.Deserialize(myStream_Read);
			myStream_Read.Close();

			Console.WriteLine(myA_1);
			Console.WriteLine(myB_1);
			Console.WriteLine(myC_1);

			Console.Read();
		}
	}
}
