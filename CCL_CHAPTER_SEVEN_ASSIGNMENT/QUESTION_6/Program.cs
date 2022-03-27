using System;

namespace QUESTION_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, tempIndex, tempCounter;

            Console.Write("Enter the array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] array = new int[length];
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                int[] tempResult = new int[length];
                tempIndex = tempCounter = 1;
                tempResult[0] = array[i];

                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = array [j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && array[j] > tempResult[tempIndex - 2] && array[j] < tempResult[tempIndex - 1]) tempResult[tempIndex - 1] = array[j];
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++) Console.Write("{0},", result[i]);
        }
    }
}
