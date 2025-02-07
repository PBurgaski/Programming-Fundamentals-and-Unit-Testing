namespace _01.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int[] firstRowOfNumbers = separatedInputForArrays();
            int[] secondRowOfNumbers = separatedInputForArrays();
            bool isEqual = true;
            //Calculations
            while (isEqual)
            {
                for (int i = 0; i < firstRowOfNumbers.Length; i++)
                {
                    if (firstRowOfNumbers[i] != secondRowOfNumbers[i])
                    {
                        //Output
                        Console.WriteLine("Arrays are not identical.");
                        isEqual = false;
                        break;
                    }
                }
                if (isEqual)
                {
                    //Output
                    Console.WriteLine("Arrays are identical.");
                    break;
                }
            }
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
