using System;

namespace CCL_ASSIGNMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, bottom, top;
            //Using the divide and conqure method
            //And also intialization the declared variables to 2
            double y;
            double l = 2;
            double f = 2;
            double n = 2;
            double s = 2;
            double w = 2;


            A = Math.Pow(f, n);
            B = (s * l) / f;
            C = Math.Pow((20 / f), w);
            bottom = Math.Pow(20, n);
            top = A * (B + C);
            y= l - top / bottom;
            Console.WriteLine(y);

            //Also, it can be written as a compound equation as shown below

            y = l - (Math.Pow(f, n) * ((s * l / f )+ Math.Pow((20 / f), w))/ Math.Pow(20, n));
            Console.WriteLine(y);

        }
    }
}
