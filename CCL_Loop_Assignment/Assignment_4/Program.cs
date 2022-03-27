using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int template, randomNumber;
            Console.Write("Enter upper limit for the range of integer: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (int i in arr)
            {
                randomNumber = rnd.Next(0, n);
                template = arr[i];
                arr[i] = arr[randomNumber];
                arr[randomNumber] = template;
            }

            foreach (int i in arr) Console.WriteLine(arr[i]);
        }
    }
}
