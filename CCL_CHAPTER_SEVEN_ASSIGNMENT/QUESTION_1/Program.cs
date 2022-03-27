using System;

namespace QUESTION_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstTwentyIntegers = new int[20];

            for (int i = 0; i < firstTwentyIntegers.Length; i++)
            {
                firstTwentyIntegers[i] = i * 5;
                Console.WriteLine(firstTwentyIntegers[i]);

            }
        }
    }
}
