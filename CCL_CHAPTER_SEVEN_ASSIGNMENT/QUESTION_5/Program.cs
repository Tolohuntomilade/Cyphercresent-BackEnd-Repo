using System;

namespace QUESTION_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] array = new int[length];
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 1 == array[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                    }
                }
                else sames = 1;
            }

            for (int i = bestStart; i < bestSames + bestStart; i++) Console.Write("{0}, ", array[i]);

        }
    }
}
