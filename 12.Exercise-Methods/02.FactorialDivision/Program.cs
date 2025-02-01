namespace _02.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int dividedFactorial = FirstCalculatedFractorial(firstNumber) / SecondCalculatedFractorial(secondNumber);
            //Output
            Console.WriteLine(dividedFactorial);
        }
            //Methods
        static int FirstCalculatedFractorial(int firstNumber)
        {
            int result = 1;
            for (int i = firstNumber; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
            //Methods
        static int SecondCalculatedFractorial(int secondNumber)
        {
            int result = 1;
            for (int i = secondNumber; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
