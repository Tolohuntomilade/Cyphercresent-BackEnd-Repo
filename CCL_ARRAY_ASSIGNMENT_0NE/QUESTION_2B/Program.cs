using System;

namespace QUESTION_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            int[,] matrixSubtraction = new int[3, 3];

            Console.Write("\n\nsubtraction of two Matrices :\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Input the size of the square matrix (less than 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Stored values into the array*/
            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe First matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", matrix1[i, j]);
            }

            Console.Write("\nThe Second matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", matrix2[i, j]);
            }
            /* calculate the subtraction of the matrix */
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    matrixSubtraction[i, j] = matrix1[i, j] - matrix2[i, j];
            Console.Write("\nThe subtraction of two matrix is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", matrixSubtraction[i, j]);
            }
            Console.Write("\n\n");


        }
    }
}
