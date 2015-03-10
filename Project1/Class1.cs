using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public static class Radix
    {
        public static double Newton(double A, int  n, double eps)
        {
            double x = 1;
            while(true)
            {
                double nx = ((n - 1) * x + A /Math.Pow(x, n - 1)) / n;
               if (Math.Abs(x - nx) < eps)  break; 
                x = nx;
                
            }
            return (x);
        }


        public static void Main()
        {
            const double eps = 0.0001;
            const double x = 625;
            const int  n = 2;
            Console.WriteLine(Newton(x, n, eps));
            Console.WriteLine(Math.Pow(x,(double)1/n));
            Console.ReadKey();
        }
    }
}