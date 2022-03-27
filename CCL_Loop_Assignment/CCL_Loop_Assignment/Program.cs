using System;

namespace CCL_Loop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upper limit for the range of number");
            int upperLimit = Convert.ToInt32(Console.ReadLine());
            int lowerLimit;
            for (lowerLimit = 1; lowerLimit <= upperLimit; lowerLimit++)
            {
                if (((lowerLimit % 3 == 0) && !((lowerLimit % 3 == 0) && (lowerLimit % 7 == 0))))
                {
                    Console.Write("{0} ", lowerLimit);
                }
            }
            Console.ReadKey();
        }
    }
}
