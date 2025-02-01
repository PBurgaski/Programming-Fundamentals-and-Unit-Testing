
namespace _05.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int number = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(number);
            //Output
            Console.WriteLine(Math.Abs(result));
        }
            //Methods
        private static int GetSumOfOddDigits(int number)
        {
            int sumOfOddDigits = 0;
            int tempNumber = number;
            while (true)
            {
                if (tempNumber == 0)
                {
                    break;
                }
                if (tempNumber % 2 != 0)
                {
                    sumOfOddDigits += tempNumber % 10;
                }
                tempNumber /= 10;
            }
            return sumOfOddDigits;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvenDigits = 0;
            int tempNumber = number;
            while (true)
            {
                if (tempNumber == 0)
                {
                    break;
                }
                if (tempNumber % 2 == 0)
                {
                    sumOfEvenDigits += tempNumber % 10;
                }
                tempNumber /= 10;
            }
            return sumOfEvenDigits;
        }

        private static int GetMultipleOfEvenAndOdds(int sumOfDigits)
        {
            int result = GetSumOfEvenDigits(sumOfDigits) * GetSumOfOddDigits(sumOfDigits);
            return result;
        }
    }
}
