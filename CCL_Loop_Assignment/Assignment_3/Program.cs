using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter positive interger number( N < 20): ");
            int N = int.Parse(Console.ReadLine());
            int row;
            int column;
            for (row = 1; row <= N; row++)
            {
                for (column = row; column <= row + N - 1;)
                {
                    Console.Write(column + " ");
                    column++;
                }
                Console.WriteLine(row);
            }
            Console.WriteLine();
        
        }
    }
}
