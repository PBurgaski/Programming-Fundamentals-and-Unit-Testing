namespace _04.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int[] numbers = separatedInputForArrays();
            int oddNumbers = 0;
            int evenNumbers = 0;
            int result = 0;
            //Calculation
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers += numbers[i];
                }
                else
                {
                    oddNumbers += numbers[i];
                }
            }
            result = evenNumbers - oddNumbers;
            //Output
            Console.WriteLine(result);
        }

        public static int[] separatedInputForArrays()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
