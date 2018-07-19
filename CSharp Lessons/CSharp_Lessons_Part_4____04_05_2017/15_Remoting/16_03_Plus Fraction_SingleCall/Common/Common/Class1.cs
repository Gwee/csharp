using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    [Serializable]
    public class Fraction
    {
        private int num, denom;
        public Fraction() { num = 0; denom = 1; }
        public Fraction(int n, int d) { num = n; denom = d; }
        public int fieldNum
        {
            get
            {
                return num;
            }
        }
        public int fieldDenom
        {
            get
            {
                return denom;
            }
        }
        public void Show()
        {
            Console.WriteLine("{0} / {1}", num.ToString(), denom.ToString());
        }
    }
    public interface IFraction
    {
        Fraction Plus(Fraction A, Fraction B);
    }
}
