namespace _03.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int[] numbers = IntForArrays();
            //Calculations
            while (numbers.Length > 1)
            {
                int[] newArray = new int[numbers.Length - 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = numbers[i] + numbers[i + 1];
                }
                numbers = newArray;
            }
            //Output
            Console.WriteLine(string.Join(", ", numbers));
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
