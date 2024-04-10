using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal static class Okr
    {
        public static double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        public static double GetSquare(double r)
        {
            return Math.PI * Math.Pow(r,2);
        }
        public static bool Point(double x, double y, double r)
        {
            if (Math.Abs(x) <= r && Math.Abs(y) <= r)
                return true;
            else
                return false;
        }
    }   
}
