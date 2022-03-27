using System;

namespace QUESTION_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, tempCounter = 1, mostFrequentNumber = 0;

            Console.Write("Enter the array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCounter++;
                else tempCounter = 1;
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    mostFrequentNumber = arr[i];
                }
            }

            Console.WriteLine("{0} was found {1} times.", mostFrequentNumber, counter);
        }
    }
}
