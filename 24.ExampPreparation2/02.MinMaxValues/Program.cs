namespace _02.MinMaxValues
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            // Logic & Calculations
            for (int i = 0; i < n; i++) 
            {
                if (arr[i] > maxNum) 
                {
                    maxNum = arr[i];
                }
                if (arr[i] < minNum)
                {
                    minNum = arr[i];
                }
            }
            // Output
            Console.WriteLine(maxNum);
            Console.WriteLine(minNum);
        }
    }
}