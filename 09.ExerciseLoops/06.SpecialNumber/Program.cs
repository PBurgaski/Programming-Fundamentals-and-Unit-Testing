using System;

namespace _06.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Input
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            bool isSpecial = true;


            // Calculation
            while (number > 0)
            {
                int digit = number % 10;

                if (digit == 0 || originalNumber % digit != 0)
                {
                    Console.WriteLine($"{originalNumber} is not special");
                    isSpecial = false;
                    break;
                }
                number /= 10;
            }
            // Output
            if (isSpecial)
            {
                Console.WriteLine($"{originalNumber} is special");
            }
        }
    }
}


