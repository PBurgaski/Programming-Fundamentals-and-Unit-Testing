namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> bombAndPower = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int bombNumber = bombAndPower[0];
            int power = bombAndPower[1];
            //Logic
            while (numbers.Contains(bombNumber))
            {
                int bombIndex = numbers.IndexOf(bombNumber);
                int startIndex = bombIndex - power;
                int endIndex = bombIndex + power;
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex >= numbers.Count)
                {
                    endIndex = numbers.Count - 1;
                }
                int countToRemove = endIndex - startIndex + 1;
                numbers.RemoveRange(startIndex, countToRemove);
            }
            //Output
            Console.WriteLine(numbers.Sum());
        }
    }
}