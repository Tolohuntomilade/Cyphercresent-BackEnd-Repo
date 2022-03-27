using System;

namespace QUESTION_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter searched number: ");
            int number = Int32.Parse(Console.ReadLine());

            int index = Array.BinarySearch(array, number);

            if (index >= 0) Console.Write("The number is on {0} index.", index);
            else Console.Write("The number was not found.");
        }
    }
}
