using System;

namespace QUESTION_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximalSum = 0;

            Console.Write("Enter integer N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter  integer K (K < N): ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) maximalSum += arr[i];

            Console.WriteLine("\nMaximal sum is {0}", maximalSum);
        }
    }
}
