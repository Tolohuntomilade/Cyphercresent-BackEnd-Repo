using System;

namespace QUESTION_12B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the matrix size: ");
            int matrixSize = Int32.Parse(Console.ReadLine());

            int[,] array = new int[matrixSize, matrixSize];
            array[0, 0] = 1;

            for (int i = 1; i < array.GetLength(0); i++)
                if (i % 2 == 1) array[0, i] = array[0, i - 1] + matrixSize * 2 - 1;
                else array[0, i] = array[0, i - 1] + 1;

            for (int i = 1; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (j % 2 == 1) array[i, j] = array[i - 1, j] - 1;
                    else array[i, j] = array[i - 1, j] + 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) Console.Write("{0, 4}", array[i, j]);
                Console.WriteLine();
            }
        }
    }
}
