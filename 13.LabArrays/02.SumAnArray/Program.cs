namespace _02.SumAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                int sumOfNumbers = 0;
            //Calculations
            for (int i = 0; i < number.Length; i++)
            {
                sumOfNumbers += number[i];
            }
            //Output
            Console.WriteLine(sumOfNumbers);
        }
    }
}
