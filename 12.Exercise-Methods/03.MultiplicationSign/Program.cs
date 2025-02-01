namespace _03.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            MultiplicationSignCalculator(num1, num2, num3);
        }
        static void MultiplicationSignCalculator(int num1, int num2, int num3)
        {   //Input
            string result = "";
            //Calculations
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                result = "zero";
            }
            else if ((num1 < 0 && num2 < 0 && num3 > 0)
                || (num3 < 0 && num1 < 0 && num2 > 0)
                || (num2 < 0 && num3 < 0 && num1 > 0)
                || (num1 > 0 && num2 > 0 && num3 > 0)
                || (num1 < 0 && num2 < 0 && num3 > 0))
            {
                result = "positive";
            }
            else
            {
                result = "negative";
            }
            //Output
            Console.WriteLine(result);
        }
    }
}
