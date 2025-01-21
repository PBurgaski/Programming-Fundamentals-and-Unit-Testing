namespace _01.NumberType
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int num = int.Parse(Console.ReadLine());
            string result = "null";
            // Calculation
            if (num == 0)
            {
                result = "zero";
            }
            else if (num > 0)
            {
                result = "positive";
            }
            else if (num < 0)
            {
                result = "negative";
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            //Output
            Console.WriteLine($"{result}");
        }
    }
}
