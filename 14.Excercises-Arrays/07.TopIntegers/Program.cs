namespace _07.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int[] numbers = IntForArrays();
            string result = "";
            // Calculations
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    result += numbers[i] + " ";
                }
            }

            // Output
            Console.WriteLine(result.Trim());
        }
        //Methods
        public static int[] IntForArrays()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
