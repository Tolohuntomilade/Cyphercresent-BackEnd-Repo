using System;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = 300;
            int lowerLimit=1;
            while (lowerLimit < upperLimit)
            {
                lowerLimit++;
                if (((lowerLimit % 7 == 0) && !((lowerLimit%7==0)&&(lowerLimit%5==0))))
                
                    
                    Console.Write(lowerLimit + "\t");
                continue;
            }
            return;
           
        }
    }
}
