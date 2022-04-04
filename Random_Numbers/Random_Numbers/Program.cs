using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Number
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Input the lowerlimit for the range: ");
            int lowerlimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the upperlimit for the range: ");
            int upperlimit = Convert.ToInt32(Console.ReadLine());
            GettingRandomNumber(lowerlimit, upperlimit);
        }
        static void GettingRandomNumber(int lowerlimit, int upperlimit)
        {
            Random randomNumber = new Random();
            List<int> rndNumber = new List<int>();
            int result = randomNumber.Next(lowerlimit, upperlimit);
            int counter = 1;
            while (!rndNumber.Contains(result) && counter > 0)
            {
                Console.WriteLine(result);
                rndNumber.Add(result);
                result = randomNumber.Next(lowerlimit, upperlimit);
                counter++;

            }
            Console.WriteLine("{0} have been repeated again. ", result);
            Console.WriteLine("It took {0} iterations to repeat {1}", counter, result);

        }





    }
}
