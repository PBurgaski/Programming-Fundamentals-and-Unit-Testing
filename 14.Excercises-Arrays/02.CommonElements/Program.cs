namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int[] firstRow = IntForArrays();
            int[] secondRow = IntForArrays();
            int savedNumber = 0;
            //Calculations
            while (true)
            {
                foreach (int row in firstRow)
                {
                    for (int i = 0; i < secondRow.Length; i++)
                    {
                        if (row == secondRow[i])
                        {
                            //Output
                            Console.Write($"{secondRow[i]} ");
                        }
                    }
                }
                break;
            }
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

