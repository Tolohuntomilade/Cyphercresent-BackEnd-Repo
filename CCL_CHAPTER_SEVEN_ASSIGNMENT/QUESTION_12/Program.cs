using System;

namespace QUESTION_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of the square matrix: ");
            int height = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the width of the square matrix: ");
            int width = Int32.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= height; i++)
            {
                Console.Write("{0} ", i);

                counter += i;

                for (int j = 1; j < width; j++)
                {
                    counter += height;
                    Console.Write("{0} ", counter);
                }

                counter = 0;
                Console.WriteLine();
            }
        }
    }
}
