namespace _04.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int[] numbers = IntForArrays();
            int controlNumber = int.Parse(Console.ReadLine());
            //Calculations
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == controlNumber)
                        //Output
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                }
            }
        }
        //Method
        public static int[] IntForArrays()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
