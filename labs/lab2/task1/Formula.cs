using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Formula
    {
        public double X { set; get; }
        public double Y { set; get; }
        public double Z { set; get; }

        public delegate double Function(double x);
        public static event Function U;
        public double GetAnsver()
        {
            double ans = 0;
            var u = U?.Invoke(X);
            ans = Math.Pow((double)(u + Y), 2);
            if(u*Y < 0)
            {
                ans += Math.Sqrt((double)(-1*u * Y)); 
            }
            else if (u*Y > 0)
            {
                ans += Math.Sqrt((double)Math.Abs((double)(u * Y)));
            }
            else
            {
                ans += 1;
            }
            return ans;
        }
        public double GetMax()
        {
            return Math.Max(Math.Max(X, Y), Z);
        }
        public double GetMaxAbs()
        {
            return Math.Max(Math.Max(Math.Abs(X), Math.Abs(Y)), Math.Abs(Z));
        }
    }
}
