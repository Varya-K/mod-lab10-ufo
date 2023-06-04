using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    static public class Functiouns
    {
        static public double Arctg(double x, int n,bool dx_positive, bool dy_positive)
        {
            double res = 0;
            bool change = false;
            if (Math.Abs(x) > 1)
            {
                change = true;
                x = 1 / x;
            }
            double pow = x;
            double sign = 1;
            for (int i = 1; i <= n; i++)
            {
                res += sign * pow / (2 * i - 1);
                pow *= x * x;
                sign *= -1;
            }
            if (change)
            {
                if (dy_positive)
                    res = Math.PI / 2 - res;
                else
                    res = -Math.PI/2 - res;
            }
            else
            {
                if (!dx_positive && dy_positive)
                    res = res + Math.PI;
                if (!dx_positive && !dy_positive)
                    res = res - Math.PI;
            }
            return res;
        }


        static public double Sin(double x, int n)
        {
            double res = 0;
            double pow = x;
            double sign = 1;
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                res += sign * pow / factorial;
                pow *= x * x;
                sign *= -1;
                factorial *= 2 * i * (2 * i + 1);
            }
            return res;
        }


        static public double Cos(double x, int n)
        {
            double res = 0;
            double pow = 1;
            double sign = 1;
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                res += sign * pow / factorial;
                pow *= x * x;
                sign *= -1;
                factorial *= 2 * i * (2 * i - 1);
            }
            return res;
        }
    }
}
