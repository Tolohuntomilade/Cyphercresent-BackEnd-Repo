using System;

namespace QUESTION_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrayEqual = true;
            char[] firstArray = new char[5] { 'f', 'g', 'h', 'i', 'j' };
            char[] secondArray = new char[5] { 'f', 'g', 'h', 'i', 'j' };

            if (firstArray.Length > secondArray.Length) Console.WriteLine("Second array is first lexicographicaly .");
            else if (firstArray.Length < secondArray.Length) Console.WriteLine("First array is first lexicographicaly.");
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("First array is first lexicographicaly.");
                        arrayEqual = false;
                        break;
                    }
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine("Second array is first lexicographicaly.");
                        arrayEqual = false;
                        break;
                    }
                }

                if (arrayEqual) Console.WriteLine("The two arrays are lexicographicaly equal.");
            }

        }
    }
}
