﻿namespace _01.FreezingWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            if (temp <= 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }
    }
}
