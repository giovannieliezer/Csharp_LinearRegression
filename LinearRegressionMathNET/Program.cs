using MathNet.Numerics;
using System;

namespace LinearRegressionMathNET
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] xdata = new double[] { 5, 15, 25, 35, 45, 55 };
            double[] ydata = new double[] { 5, 20, 14, 32, 22, 38 };

            Tuple<double, double> p = Fit.Line(xdata, ydata);
            double a = p.Item1; // 
            double b = p.Item2; //

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
