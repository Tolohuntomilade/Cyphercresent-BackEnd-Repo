using System;

namespace QUESTION_4
{
    class Program
    {
        static void Main(string[] args)
        {
			int count = 1, tempCount = 1, number = 0;

			Console.Write("Enter the array length: ");
			int lengthOfTheArray = Int32.Parse(Console.ReadLine());
			int[] array = new int[lengthOfTheArray];

			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("Enter {0} element: ", i);
				array[i] = Int32.Parse(Console.ReadLine());
			}

			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i] == array[i + 1]) tempCount++;
				else tempCount = 1;

				if (tempCount > count)
				{
					count = tempCount;
					number = array[i];
				}
			}

			for (int i = 0; i < count; i++) Console.Write("{0}, ", number);

		}
	}
}
