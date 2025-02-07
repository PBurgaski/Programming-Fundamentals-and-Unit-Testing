namespace _06.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int[] numbers = IntForArrays();
            int countOfRotations = int.Parse(Console.ReadLine());
            int[] newNumbers = new int[numbers.Length];
            int tempNum = 0;
            //Calculation

            for (int i = 0; i < countOfRotations; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (j == 0)
                    {
                        tempNum = numbers[0];
                    }
                    newNumbers[j] = numbers[j + 1];
                }
                newNumbers[numbers.Length - 1] = tempNum;
                numbers = newNumbers;
            }
            //Output
            Console.WriteLine(string.Join(" ", numbers));
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
