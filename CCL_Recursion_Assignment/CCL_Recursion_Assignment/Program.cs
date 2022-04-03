using System;

namespace CCL_Recursion_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(4));
            LengthOfAStringAndUpperConversion("Adedamola");
            PrintPrimeNumberInARange(1, 10);
            
        }
        static decimal Sum(int num)
        {
            if (num <= 0)
            {
                return 0;
            }
            else
            {
                return num + Sum(num - 1);
            }
        }
        static void LengthOfAStringAndUpperConversion (string result)
        {
            if(result==" ")
            {
                Console.WriteLine(" "); 
            }
            else
            {
                int counter = 0;
                result = result.ToUpper();
                foreach (var character in result)
                {
                    counter++;
                }
                Console.WriteLine("The length of the string is {0} and the uppercase is {1}", counter, result); ;
               
            }
        }

        static bool IsPrime(int number)
        {
            if (number==0)
            {
                return false;
            }
            else
            {
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(number);
                bool prime = true;
                while (prime && (divider <= maxDivider))
                {
                    if (number % divider == 0)
                    {
                        prime = false;
                    }
                    divider++;
                }

                return prime ;

            }
            
        }
        static void PrintPrimeNumberInARange(int lowerlimit, int upperlimit)
        {
            if (lowerlimit>upperlimit)
            {
                PrintPrimeNumberInARange(lowerlimit, upperlimit);
            }
            else
            {
                if (lowerlimit==upperlimit)
                {
                    if (IsPrime(upperlimit))
                    {
                        Console.WriteLine(upperlimit);
                        return;
                    }
                }
                else
                {
                    if (IsPrime(lowerlimit))
                    {
                        Console.WriteLine(lowerlimit);
                    }
                    PrintPrimeNumberInARange(lowerlimit + 1, upperlimit);
                }
            }
        }

    }
}
