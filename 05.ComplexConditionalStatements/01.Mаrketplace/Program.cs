﻿namespace _01.Marketplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input

            string product = Console.ReadLine();
            string day = Console.ReadLine();

            // Output
            if (product == "Banana")
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("2.50"); ;
                }
                else if (day == "Weekend")
                {
                    Console.WriteLine("2.70");
                }
            }
            else if (product == "Apple")
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("1.30");
                }

                else if (day == "Weekend")
                {
                    Console.WriteLine("1.60");
                }
            }
            else if (product == "Kiwi")
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("2.20");
                }

                else if (day == "Weekend")
                {
                    Console.WriteLine("3.00");
                }
            }
        }
    }
}
