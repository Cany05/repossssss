using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibQuaternion
{
    public struct Quaternion
    {

        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        private readonly double _d;

        public Quaternion(double a, double b, double c, double d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }
        public double A => _a;
        public double B => _b;
        public double C => _c;
        public double D => _d;
        public double Abs => Math.Sqrt(_a * _a + _b * _b + _c * _c + _d * _d);

        public static Quaternion operator +(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(
                q1._a + q2._a,
                q1._b + q2._b,
                q1._c + q2._c,
                q1._d + q2._d
            );
        }

        public static Quaternion operator -(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(
                q1._a - q2._a,
                q1._b - q2._b,
                q1._c - q2._c,
                q1._d - q2._d
            );
        }

        public static Quaternion operator *(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(
                q1._a * q2._a - q1._b * q2._b - q1._c * q2._c - q1._d * q2._d,
                q1._a * q2._b + q1._b * q2._a + q1._c * q2._d - q1._d * q2._c,
                q1._a * q2._c + q1._c * q2._a + q1._d * q2._b - q1._b * q2._d,
                q1._a * q2._d + q1._d * q2._a + q1._b * q2._c - q1._c * q2._b
            );
        }
        public override string ToString()
        {
            string result = "";

            if (Math.Abs(_a) > 1e-13)
            {
                result += _a.ToString("0.##########");
            }

            if (Math.Abs(_b) > 1e-13)
            {
                result += (_b > 0 ? "+" : "") + _b.ToString("0.##########") + "i";
            }
            if (Math.Abs(_c) > 1e-13)
            {
                result += (_c > 0 ? "+" : "") + _c.ToString("0.##########") + "j";
            }
            if (Math.Abs(_d) > 1e-13)
            {
                result += (_d > 0 ? "+" : "") + _d.ToString("0.##########") + "k";
            }

            return result == "" ? "0" : result;
        }

        public override bool Equals(object obj)
        {
            if (obj is Quaternion other)
            {
                const double epsilon = 1e-13;
                return Math.Abs(_a - other._a) < epsilon &&
                       Math.Abs(_b - other._b) < epsilon &&
                       Math.Abs(_c - other._c) < epsilon &&
                       Math.Abs(_d - other._d) < epsilon;
            }
            return false;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + _a.GetHashCode();
                hash = hash * 23 + _b.GetHashCode();
                hash = hash * 23 + _c.GetHashCode();
                hash = hash * 23 + _d.GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(Quaternion q1, Quaternion q2)
        {
            const double epsilon = 1e-13;
            return Math.Abs(q1._a - q2._a) < epsilon &&
                   Math.Abs(q1._b - q2._b) < epsilon &&
                   Math.Abs(q1._c - q2._c) < epsilon &&
                   Math.Abs(q1._d - q2._d) < epsilon;
        }

        public static bool operator !=(Quaternion q1, Quaternion q2)
        {
            return !(q1 == q2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Quaternion q1 = new Quaternion(1, 2, 3, 4);
            Quaternion q2 = new Quaternion(5, 6, 7, 8);


            Console.WriteLine("q1 = " + q1);
            Console.WriteLine("q2 = " + q2);

            Quaternion sum = q1 + q2;
            Console.WriteLine("q1 + q2 = " + sum);

            Quaternion diff = q1 - q2;
            Console.WriteLine("q1 - q2 = " + diff);

            Quaternion product = q1 * q2;
            Console.WriteLine("q1 * q2 = " + product);

            Console.WriteLine("Abs(q1) = " + q1.Abs);

            Quaternion q3 = new Quaternion(1, 2, 3, 4);
            Console.WriteLine("q1 == q3: " + (q1 == q3));
        }
    }
}