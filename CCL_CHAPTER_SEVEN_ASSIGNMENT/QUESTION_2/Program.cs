using System;

namespace QUESTION_2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool arraysEqual = true;

            Console.Write("Enter lenght of the first array: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] firstArray = new int[length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                firstArray[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter lenght of the second array: ");

            if (length != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
            else
            {
                int[] secondArray = new int[length];

                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    secondArray[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("\nThe arrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("\nThe arrays are the same.");
            }

        }
    }
}
