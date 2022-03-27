using System;

namespace AssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the x^2 coefficient of the quatratic equation: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write the x coefficient of the quatratic equation: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write the x^0 coefficient of the quatratic equation: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = (double)((b *b) - (4 * a * c));
            if (d < 0)
            {
                double x1 = (double)((-b + Math.Sqrt(d)) / (2 * a));
                double x2 = (double)((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("The equation have two complex and distinct roots of {0} and {1}", x1, x2);
            }
          
            else if (d == 0)
            {
                double x1 = (double)(-b / (2 * a));
                Console.WriteLine("The equation have two real and equal roots of {0}", x1);
            }
            else if (d>0)
            {
                double x1 = (double)((-b + Math.Sqrt(d)) / (2 * a));
                double x2 = (double)((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("The equation have two real and distinct roots of {0} and {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Unknown Roots");
            }
           
        }
    }
}
