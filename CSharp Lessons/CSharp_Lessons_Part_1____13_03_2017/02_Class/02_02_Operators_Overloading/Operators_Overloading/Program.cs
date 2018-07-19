using System;
using System.Collections.Generic;
using System.Text;

namespace Operators_Overloading
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

        public int Numerator
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        public int Denominator
        {
            get
            {
                return denom;
            }
            set
            {
                denom = value;
            }
        }

        public int this[string str]
        {
            get
            {
                if (str.ToUpper() == "NUMERATOR")
                    return num;
                if (str.ToUpper() == "DENOMINATOR")
                    return denom;
                return 0;
            }
            set
            {
                if (str.ToUpper() == "NUMERATOR")
                    num = value;
                if (str.ToUpper() == "DENOMINATOR")
                    denom = value;
            }
        }

        public override string ToString()
        {
            string Temp = "(";
            Temp += num.ToString() + " / ";
            Temp += denom.ToString() + ")";
            return Temp;
        }	// Without ToString(): 
        // Fracion A = new Fraction( 1, 2 );  
        // Console.WriteLine(A.ToString()); 	-- Fraction 

        public static Fraction operator +(Fraction A, Fraction B)
        {
            Fraction Result = new Fraction();
            Result.Numerator = A.Numerator * B.Denominator + A.Denominator * B.Numerator;
            Result.Denominator = A.Denominator * B.Denominator;
            return Result;
        }

        public static Fraction operator +(int a, Fraction B)
        {
            return new Fraction(a, 1) + B;
        }

        public static Fraction operator *(Fraction A, Fraction B)
        {
            return new Fraction(A["Numerator"] * B["Numerator"], A["Denominator"] * B["Denominator"]);
        }
    }
    public class Test
    {
        static void Main()
        {
            Fraction A = new Fraction(1, 2);
            Fraction B = new Fraction(2, 3);
            //		Fraction C ;
            Fraction C = new Fraction();

            C = A * B;
            Console.WriteLine("{0} * {1} = {2}", A.ToString(), B.ToString(), C.ToString());
            // Output (1, 2) * (2, 3 ) = (2, 6)
            C = A + B;
            Console.WriteLine("{0} + {1} = {2}", A, B, C);
            // Output (1, 2) + (2, 3 ) = (7, 6)

            C += A;         // From operator+ ( don't operator+= 
            Console.WriteLine("{0}", C);
            // Output (20, 12)

            Console.ReadLine();
        }
    }
}
