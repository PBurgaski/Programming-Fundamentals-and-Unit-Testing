

namespace _01.MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            int n = int.Parse(Console.ReadLine());
            List<int> magicNumbers = new List<int>();
            // Logic & Calculations
            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i) && IsDivisibleByTwo(i))
                {
                    magicNumbers.Add(i);
                }
            }
            // Output
            if (magicNumbers.Any())
            {
                Console.WriteLine(string.Join(" ", magicNumbers));
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        // Methods
        static bool IsPrime(int num)
        {
            string numStr = num.ToString();
            return numStr.All(digit => digit == '2' || digit == '3' || digit == '5' || digit == '7');

        }
        static bool IsDivisibleByTwo(int num)
        {
            int digitSum = 0;
            while (num > 0)
            {
                digitSum += num % 10; 
                num /= 10;            
            }
            return digitSum % 2 == 0;
        }
    }
}
