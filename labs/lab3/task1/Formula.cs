using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Formula
    {
        public Formula()
        {
            X1 = 0.1;
            X2 = 1;
            N = 12;
            H = 0.1;
        }
        public double X1 { set; get; } 
        public double X2 { set; get; }
        public double N { set; get; }
        public double H { set; get; }

        private double Fac(int t)
        {
            double res = 1;
            for(int i = 2; i <= t; i++)
            {
                res *= i;
            }
            return res;
        }
        public double GetAnsver(double x)
        {
            double ans = 0;
            for(int i = 0; i < N; i++)
            {
                ans += Math.Pow(-1, i) * Math.Pow(x, 2*i+1)/Fac(2*i+1);
            }
            return ans;
        }
       
    }
}
