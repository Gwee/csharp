using System;
using System.Collections.Generic;
using System.Text;

namespace Points_Interface
{
    public interface IPoint
    {
        double fieldX
        {
            get;
        }

        double fieldY
        {
            get;
        }
        double fieldZ
        {
            get;
        }

        double distance();
        string ToString();
    }
    public class Point2d : IPoint
    {
        private double x, y;
        public Point2d() { }
        public Point2d(double xx, double yy)
        {
            x = xx; y = yy;
        }

        public double fieldX
        {
            get
            {
                return x;
            }
        }
        public double fieldY
        {
            get
            {
                return y;
            }
        }
        public double fieldZ
        {
            get
            {
                return 0;
            }
        }

        public double distance()
        {
            return Math.Pow(x * x + y * y, 0.5);
        }
        new public string ToString()
        {
            string Temp = "(";
            Temp += x.ToString() + ", ";
            Temp += y.ToString() + ")";
            return Temp;
        }
    }

    public class Point3d : IPoint
    {
        private double x, y, z;
        public Point3d() { }
        public Point3d(double xx, double yy, double zz)
        {
            x = xx; y = yy; z = zz;
        }
        public double fieldX
        {
            get
            {
                return x;
            }
        }
        public double fieldY
        {
            get
            {
                return y;
            }
        }
        public double fieldZ
        {
            get
            {
                return z;
            }
        }

        public double distance()
        {
            return Math.Pow(x * x + y * y + z * z, 0.5);
        }
        new public string ToString()
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
        static public double distance(IPoint First, IPoint Second)
        {
            //		if ( First.GetType() != Second.GetType())
            //		{
            //				Console.WriteLine("Diffrent type of arguments");
            //				return 0;
            //		}
            double dx = First.fieldX - Second.fieldX;
            double dy = First.fieldY - Second.fieldY;
            double dz = First.fieldZ - Second.fieldZ;
            return Math.Pow(dx * dx + dy * dy + dz * dz, 0.5);
        }

        static void Main()
        {
            IPoint A_2d = new Point2d(3, 4),
                B_2d = new Point2d(9, 12),
                C_2d = new Point2d(4, 1),
                D_3d = new Point3d(12, 15, 16),
                E_3d = new Point3d(15, 15, 20),
                F_3d = new Point3d(1, 1, 4);

            Console.WriteLine("Distance {0} - (O, 0) = {1}", A_2d.ToString(), A_2d.distance());
            // Distance (3, 4) - (0, 0) = 5
            Console.WriteLine("Distance {0} - {1} = {2}", A_2d.ToString(), B_2d.ToString(), distance(A_2d, B_2d));
            // Distance (3, 4) - (9, 12) = 10

            Console.WriteLine("Distance {0} - (O, 0, 0) = {1}", D_3d.ToString(), D_3d.distance());
            // Distance (12, 15, 16) - (0, 0, 0) = 25
            Console.WriteLine("Distance {0} - {1} = {2}", D_3d.ToString(), E_3d.ToString(), distance(D_3d, E_3d));
            // Distance (12, 15, 16) - (15, 15, 20) = 5

            Console.WriteLine("Distance {0} - {1} = {2}", F_3d.ToString(), C_2d.ToString(), distance(F_3d, C_2d));
            // Distance (1, 1, 4) - (4, 1) = 5
            Console.WriteLine("Distance {0} - {1} = {2}", C_2d.ToString(), F_3d.ToString(), distance(C_2d, F_3d));
            // Distance (4, 1) - (1, 1, 4) = 5
        }
    }

}
