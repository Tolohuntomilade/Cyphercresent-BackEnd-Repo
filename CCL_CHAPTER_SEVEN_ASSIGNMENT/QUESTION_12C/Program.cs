using System;

namespace QUESTION_12C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            int length = Int32.Parse(Console.ReadLine());

            int[,] array = new int[length, length];
            array[length - 1, 0] = 1;
            int counter = 1;
            for (int row = length - 2; row >= 0; row--)
            {
                array[row, 0] = array[row + 1, 0] + counter;
                int newRow = row;
                for (int diagonal = 1; diagonal <= counter; diagonal++)
                {
                    array[newRow + 1, diagonal] = array[newRow, diagonal - 1] + 1;
                    newRow++;
                }
                counter++;
            }

            array[0, length - 1] = length * length;
            int diagonalLength = 2;
            int posX = 1;
            int posY = length - 1;
            int prevX = 0;
            int prevY = length - 1;

            for (int i = 1; i < counter - 1; i++)
            {
                for (int j = 1; j <= diagonalLength; j++)
                {
                    array[posX, posY] = array[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY;
                    posX--;
                    posY--;
                }
                diagonalLength++;
                posX = i + 1;
                posY = length - 1;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) Console.Write("{0, 4}", array[i, j]);
                Console.WriteLine();
            }
        }
    }
}
