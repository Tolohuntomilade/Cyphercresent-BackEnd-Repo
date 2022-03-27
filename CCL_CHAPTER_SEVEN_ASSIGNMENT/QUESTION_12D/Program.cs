using System;

namespace QUESTION_12D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int length = Int32.Parse(Console.ReadLine());

            int[,] array = new int[length, length];
            int numConcentricSquares = (int)Math.Ceiling((length) / 2.0);
            int sideLen = length;
            int currNum = 0;

            for (int i = 0; i < numConcentricSquares; i++)
            {

                for (int j = 0; j < sideLen; j++) array[i + j, i] = ++currNum;

                for (int j = 1; j < sideLen - 1; j++) array[length - 1 - i, i + j] = ++currNum;

                for (int j = sideLen - 1; j > 0; j--) array[i + j, length - 1 - i] = ++currNum;

                for (int j = sideLen - 1; j > 0; j--) array[i, i + j] = ++currNum;

                sideLen -= 2;
            }


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) Console.Write("{0, 4}", array[i, j]);
                Console.WriteLine();
            }
        }
    }
}
