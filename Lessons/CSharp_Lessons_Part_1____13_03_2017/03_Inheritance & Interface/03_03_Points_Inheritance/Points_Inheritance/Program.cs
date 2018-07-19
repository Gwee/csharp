using System;
using System.Collections.Generic;
using System.Text;

namespace Points_Inheritance
{
    public abstract class Point
    {
        public abstract double fieldX					// Abstract Property
        {
            get;
        }
        public abstract double fieldY
        {
            get;
        }
        public abstract double fieldZ
        {
            get;
        }
        public abstract double this[int index]			// Abstract Indexer
        {
            get;
        }

        public abstract double distance();				// Abstract Function
        public double distance(Point P)
        {
            /* 	if ( P.GetType() != this.GetType() )
                {
                    Console.WriteLine("Diffrent type of arguments");
                    return 0;
                }
            */
            double dx = fieldX - P.fieldX;
            double dy = this[1] - P.fieldY;
            double dz = this[2] - P[2];

            return Math.Pow(dx * dx + dy * dy + dz * dz, 0.5);
        }
    }
    public class Point2d : Point
    {
        private double x, y;
        public Point2d(double xx, double yy)
        {
            x = xx; y = yy;
        }

        public override double fieldX
        {
            get
            {
                return x;
            }
        }
        public override double fieldY
        {
            get
            {
                return y;
            }
        }
        public override double fieldZ
        {
            get
            {
                return 0;
            }
        }

        public override double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: return 0;
                }
            }
        }

        public override double distance()
        {
            return Math.Pow(x * x + y * y, 0.5);
        }

        public override string ToString()
        {
            string Temp = "(";
            Temp += x.ToString() + ", ";
            Temp += y.ToString() + ")";
            return Temp;
        }
    }

    public class Point3d : Point
    {
        private double x, y, z;
        public Point3d(double xx, double yy, double zz)
        {
            x = xx; y = yy; z = zz;
        }
        public override double fieldX
        {
            get
            {
                return x;
            }
        }
        public override double fieldY
        {
            get
            {
                return y;
            }
        }
        public override double fieldZ
        {
            get
            {
                return z;
            }
        }

        public override double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    default: return 0;
                }
            }
        }

        public override double distance()
        {
            return Math.Pow(x * x + y * y + z * z, 0.5);
        }
        public override string ToString()
        {
            string Temp = "(";
            Temp += x.ToString() + ", ";
            Temp += y.ToString() + ", ";
            Temp += z.ToString() + ")";
            return Temp;
        }
    }

    public class Test
    {
        static void Main()
        {
            Point A_2d = new Point2d(3, 4),
                B_2d = new Point2d(9, 12),
                C_2d = new Point2d(4, 1),
                D_3d = new Point3d(12, 15, 16),
                E_3d = new Point3d(15, 15, 20),
                F_3d = new Point3d(1, 1, 4);

            Console.WriteLine("Distance {0} - (O, 0) = {1}", A_2d.ToString(), A_2d.distance());
            // Distance (3, 4) - (0, 0) = 5
            Console.WriteLine("Distance {0} - {1} = {2}", A_2d.ToString(), B_2d.ToString(), A_2d.distance(B_2d));
            // Distance (3, 4) - (9, 12) = 10

            Console.WriteLine("Distance {0} - (O, 0, 0) = {1}", D_3d.ToString(), D_3d.distance());
            // Distance (12, 15, 16) - (0, 0, 0) = 25
            Console.WriteLine("Distance {0} - {1} = {2}", D_3d.ToString(), E_3d.ToString(), D_3d.distance(E_3d));
            // Distance (12, 15, 16) - (15, 15, 20) = 5

            Console.WriteLine("Distance {0} - {1} = {2}", F_3d.ToString(), C_2d.ToString(), F_3d.distance(C_2d));
            // Distance (1, 1, 4) - (4, 1) = 5
            Console.WriteLine("Distance {0} - {1} = {2}", C_2d.ToString(), F_3d.ToString(), C_2d.distance(F_3d));
            // Distance (4, 1) - (1, 1, 4) = 5

        }
    }

}
