using System;

namespace AssignmentFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //If a = 10, b = 20, c = 30.
            //Programmatically determine if a equal to b and c is greater than a + b - c and c-b is equal to a.
            int a = 10;
            int b = 20;
            int c = 30;
            bool result = (a == b) && (c > (a + b - c) ) && ((c - b) == a);
            
            Console.WriteLine("The result is {0}",result);
            
        }
    }
}
