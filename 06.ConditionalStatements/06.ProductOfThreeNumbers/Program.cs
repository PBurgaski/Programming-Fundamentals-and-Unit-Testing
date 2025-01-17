namespace _06.ProductOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            string result = "";
            //Calculations
            if ((num1 > 0 && num2 > 0 && num3 < 0)
                || (num3 > 0 && num1 > 0 && num2 < 0)
                || (num2 > 0 && num3 > 0 && num1 < 0))
            {
                result = "negative";
            }
            if ((num1 < 0 && num2 < 0 && num3 > 0)
                || (num3 < 0 && num1 < 0 && num2 > 0)
                || (num2 < 0 && num3 < 0 && num1 > 0))
            {
                result = "positive";
            }
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                result = "zero";
            }
            //Output
            Console.WriteLine(result);
        }
    }
}
