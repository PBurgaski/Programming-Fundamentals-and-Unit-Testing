namespace _03.TriangleOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int n = int.Parse(Console.ReadLine());
            //Calculation
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    //Output
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
