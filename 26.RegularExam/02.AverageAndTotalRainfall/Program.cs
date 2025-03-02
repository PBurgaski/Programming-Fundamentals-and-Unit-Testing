using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace _02.AverageAndTotalRainfall
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            int[] dailyRainfallAmount = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int startDay = int.Parse(Console.ReadLine());
            int endDay = int.Parse(Console.ReadLine());
            double avarageRainfallAmount = 0.0;
            double totalRainfallAmount = 0.0;
            List<int> rainfallAmount = new List<int> { };
            // Logic & Calculations
            for (int i = startDay; i <= endDay; i++)
            {
                rainfallAmount.Add(dailyRainfallAmount[i]);
            }
            foreach (int amountPerDay in rainfallAmount)
            {
                totalRainfallAmount += amountPerDay;
            }
            avarageRainfallAmount = rainfallAmount.Average();
            // Output
            Console.WriteLine(totalRainfallAmount);
            Console.WriteLine($"{avarageRainfallAmount:F2}");
        }
    }
}