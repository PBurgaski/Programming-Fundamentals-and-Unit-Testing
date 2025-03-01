namespace _02.MiddleElements
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            int[] input = IntForArrays();
            int firstMidElement = 0;
            int secondMidElement = 0;
            double result = 0.0;
            // Calculations
           firstMidElement = input[(input.Length / 2) - 1];
            secondMidElement = input[input.Length / 2];
            result = ((double)firstMidElement + (double)secondMidElement) / 2;
            //Output
            Console.WriteLine($"{result:F2}");
        }
        public static int[] IntForArrays()
        {
            return Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
        }
    }
}
