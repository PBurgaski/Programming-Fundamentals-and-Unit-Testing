namespace _03.RemoveNegativesАndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            bool isNegative = true;
            //Calculations
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                }
                for (int n = 0; n < numbers.Count; n++)
                {
                    if (numbers[n] > 0)
                    {
                        isNegative = false;
                    }
                }
            }
            if (isNegative)
            {
            //Output
                Console.WriteLine("empty");
            }
            Console.WriteLine(string.Join(" ", numbers.AsEnumerable().Reverse()));
        }
    }
}
