using System;

namespace QUESTION_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, minInteger, template;

            Console.Write("Enter the array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for (j = 0; j < length - 1; j++)
            {
                minInteger = j;

                for (i = j + 1; i < length; i++) if (array[i] < array[minInteger]) minInteger = i;

                if (minInteger != j)
                {
                    template = array[j];
                    array[j] = array[minInteger];
                    array[minInteger] = template;
                }
            }

            for (i = 0; i < length; i++) Console.Write("{0} ", array[i]);
        }
    }
}
