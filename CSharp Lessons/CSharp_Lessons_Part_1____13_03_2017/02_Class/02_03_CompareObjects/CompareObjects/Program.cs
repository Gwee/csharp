using System;
using System.Collections.Generic;
using System.Text;

namespace CompareObjects
{
    public class Fraction
    {
        private int num, denom;
        public Fraction()
        {
            num = 0; denom = 1;
        }
        public Fraction(int n, int d)
        {
            num = n; denom = d;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (GetType() != obj.GetType()))
                return false;
            Fraction myFraction = (Fraction)obj;
            return num == myFraction.num && denom == myFraction.denom;
        }

        //		public override int GetHashCode () 
        //		{
        //			return num.GetHashCode() ^ denom.GetHashCode();
        //		}

        public static bool operator ==(Fraction A, Fraction B)
        {
            return A.num * B.denom == A.denom * B.num;
        }
        public static bool operator !=(Fraction A, Fraction B)
        {
            return !(A == B);
        }
    }

    class Class1
    {
        static void Main()
        {
            Fraction A = new Fraction(1, 2), B = new Fraction(1, 2), C;
            C = A;

            Console.WriteLine(ReferenceEquals(A, B));				        // False
            Console.WriteLine(ReferenceEquals(A, C));				    // True

            Console.WriteLine(A.Equals(B));
                                                                                    // Without my Equals()		False
                                                                                    // With my Equals()			True
            Console.WriteLine(Equals(A, C));				                        // True

            Console.WriteLine(A == B);
                                                                                    // Without my operator ==		False
                                                                                    // With my operator ==			True
            Console.WriteLine(A == C);				                                // True

            Console.ReadLine();
        }
    }
}
