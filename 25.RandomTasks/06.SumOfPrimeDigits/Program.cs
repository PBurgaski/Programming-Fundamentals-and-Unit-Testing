namespace _06.SumOfPrimeDigits
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            int n = int.Parse(Console.ReadLine());
            int lastDigit = 0;
            int sumOfPrimeNums = 0;

            // Logic & Calculations
            while (n > 0)
            {
                lastDigit = n % 10;
                if (lastDigit == 2 || lastDigit == 3 || lastDigit == 5 || lastDigit == 7)
                {
                    sumOfPrimeNums += lastDigit;
                }
                n /= 10;
            }
            if (sumOfPrimeNums == 0)
            {
                Console.WriteLine("No prime digits found");
            }
            else
            {
                Console.WriteLine(sumOfPrimeNums);
            }
        }
    }
}
