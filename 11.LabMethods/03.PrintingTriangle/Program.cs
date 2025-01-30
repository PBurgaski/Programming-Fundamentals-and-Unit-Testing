namespace _03.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
            //Methods
            static void PrintTriangle(int n)
            {
                //Calculation
                for (int i = 1; i <= n; i++)
                {
                    PrintRow(i);
                }
                //Calculation
                for (int i = n - 1; i >= 1; i--)
                {
                    PrintRow(i);
                }
            }
            //Methods
            static void PrintRow(int num)
            {
                //Calculation
                for (int j = 1; j <= num; j++)
                {
                    //Output
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

