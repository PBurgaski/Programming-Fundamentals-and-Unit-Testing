namespace _04.NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double result = 0;
            //Calculation
            if (@operator == "+")
            {
                result = num1 + num2;
            }
            if (@operator == "-")
            {
                result = num1 - num2;
            }
            if (@operator == "*")
            {
                result = num1 * num2;
            }
            if (@operator == "/")
            {
                result = num1 / num2;
            }
            //Output
            Console.WriteLine($"{num1} {@operator} {num2} = {result:F2}");
        }
    }
}
