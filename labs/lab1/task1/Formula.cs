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
        
        public double GetAnsver()
        {
            double ans = 0;
            ans = 2 * Math.Cos(X - Math.PI/6)/(0.5 + Math.Pow(Math.Sin(Y), 2))*(1+(Z*Z/(3-Z*Z/5)));
            return ans;
        }
    }
}
