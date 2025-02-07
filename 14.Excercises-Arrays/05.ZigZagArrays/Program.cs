namespace _05.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int count = int.Parse(Console.ReadLine());
            int[] zigZagArr = new int[2];
            int[] firstArr = new int[count];
            int[] secondArr = new int[count];
            //Calculations
            for (int i = 0; i < count; i++)
            {
                zigZagArr = IntForArrays();
                    if (i % 2 == 0)
                    {
                        firstArr[i] = zigZagArr[0];
                        secondArr[i] = zigZagArr[1];
                    }
                    else if (i % 2 != 0)
                    {
                        firstArr[i] = zigZagArr[1];
                        secondArr[i] = zigZagArr[0];
                    }
                
            }
            //Output
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
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
