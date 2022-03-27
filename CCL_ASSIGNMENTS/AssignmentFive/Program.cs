using System;

namespace AssignmentFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 1;
            b = 6;
            c = 5;
            double deter = (double)(Math.Pow(b, 2) - (4 * a * c));

            if (deter > 0)
            {
                Console.WriteLine("The quatratic equation have real roots");
            }
            else if (deter < 0)
            {
                Console.WriteLine("The quatratic equation have complex roots");
            }
            else if (deter == 0)
            {
                Console.WriteLine("The quatratic equation have equal roots");
            }
            else
            {
                Console.WriteLine("Unknown Roots");
            }
        }
    }
}
