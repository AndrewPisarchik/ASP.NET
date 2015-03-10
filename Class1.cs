using System;

namespace Andrey
{
public static class Radix
{
    public static double Newton(double x0, double eps, double dx)
    {
        double x1 = x0;
        double dif = Math.Round(F(x1) / F(x1 + dx), 5);
        double alpha = -1.0 / dif;
        do
        {
            x0 = x1;
            x1 += Math.Round(alpha * F(x0), 4);
        } while (Math.Abs(x1 - x0) > eps);
        return x1;
    }


    public static void Main()
    {
        const double eps = 0.01;
        const double dx = 0.00001;
        const double x0 = 1.0;
        Console.WriteLine(Newton(x0, eps, dx));
        Console.ReadKey();
    }
}
