﻿namespace _02.DecreasingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int number = int.Parse(Console.ReadLine());
            //Calculation
            while (number >= 1)
            {
                Console.WriteLine(number); //Output
                number--;
            }
        }
    }
}
