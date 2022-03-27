using System;

namespace QUESTION_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            int det = 0;
            int det2 = 0;


            Console.Write("\n\nCalculate the determinant of a 3 x 3 matrix :\n");
            Console.Write("-------------------------------------------------\n");

            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    Console.Write("{0}  ", matrix1[i, j]);
                Console.Write("\n");
            }

            for (i = 0; i < 3; i++)
                det = det + (matrix1[0, i] * (matrix1[1, (i + 1) % 3] * matrix1[2, (i + 2) % 3] - matrix1[1, (i + 2) % 3] * matrix1[2, (i + 1) % 3]));
            Console.WriteLine("The determinat of the first matrix is {0}", det);

            Console.Write("\n\nCalculate the determinant of the second  3 x 3 matrix :\n");
            Console.Write("-------------------------------------------------\n");

            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    Console.Write("{0}  ", matrix2[i, j]);
                Console.Write("\n");
            }

            for (i = 0; i < 3; i++)
                det2 = det2 + (matrix2[0, i] * (matrix2[1, (i + 1) % 3] * matrix2[2, (i + 2) % 3] - matrix2[1, (i + 2) % 3] * matrix2[2, (i + 1) % 3]));

            Console.WriteLine("The determinat of the second matrix is {0}", det2);

            Console.WriteLine(det > det2 ? "The determinat of the first matrix is bigger than the second matrix" : "The determinat of the second matrix is bigger than the first matrix");


        }
    }
}
