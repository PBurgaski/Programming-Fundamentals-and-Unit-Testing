using System;

namespace _01.SumFactorialEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Input
            int input = int.Parse(Console.ReadLine());
            int result = 0;
            // Logic & Calculations
            while (input > 0)  
            {
                int lastDigit = input % 10;
                if (lastDigit % 2 == 0)
                {
                    result += CalculateFactorial(lastDigit);
                }
                input /= 10;
            }

            //Output
            Console.WriteLine(result);
        }
            //Methods

        public static int CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }

    }
}
