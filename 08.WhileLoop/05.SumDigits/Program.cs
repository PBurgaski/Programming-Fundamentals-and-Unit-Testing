namespace _05.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int sum = 0;
            //Calculation
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            //Output
            Console.WriteLine($"{sum}");

        }
    }
}
