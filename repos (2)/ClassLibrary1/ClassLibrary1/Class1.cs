using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public static class Functions
    {
        public static bool checkOnChar(string str)
        {
            bool flag = false;
            if (str.Length == 0)
            {
                return true;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.')
                {
                    if (flag)
                    {
                        return true;
                    }
                    flag = true;
                    continue;
                }
                if (str[i] < '0' || str[i] > '9')
                {
                    return true;
                }
            }

            return false;
        }

        public static List<KeyValuePair<double, double>> calcResult (double X1, double X2, double H, double N, int funcType)
        {
            int n = Convert.ToInt32(Math.Round((X2 - X1) / H));
            List<KeyValuePair<double, double>> result = new List<KeyValuePair<double, double>>();

            if (funcType == 0)
            {
                for (double y = X1; y < X2; y += H)
                {
                    double res = 0;
                    for (int i = 0; i < N; i++)
                    {
                        double preres = Math.Pow(y, 2 * i + 1) * Math.Pow(-1, i);
                        double fac = 2 * i + 1;
                        preres /= fac;
                        res += preres;
                    }
                    result.Add(new KeyValuePair<double, double>(y, res));
                }
            }
            else
            {

                for (double y = X1; y < X2; y += H)
                {
                    double res = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        double preres = Math.Pow(y, (2 * i)) * Math.Pow(-1, i + 1);
                        double fac = 2 * i * (2 * i - 1);
                        preres /= fac;
                        res += preres;
                    }
                    result.Add(new KeyValuePair<double, double>(y, res));
                }
            }
            return result;
        }
    }
}
