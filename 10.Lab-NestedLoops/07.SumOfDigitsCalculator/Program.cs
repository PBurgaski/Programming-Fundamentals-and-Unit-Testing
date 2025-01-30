namespace _07.SumOfDigitsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            string input = Console.ReadLine();
            //Calculation
            while (input != "End")
            {
                int number = int.Parse(input);
                int sum = 0;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number /= 10;
                }
                //Output
                Console.WriteLine($"Sum of digits = {sum}");
                input = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
        }
    }
}
