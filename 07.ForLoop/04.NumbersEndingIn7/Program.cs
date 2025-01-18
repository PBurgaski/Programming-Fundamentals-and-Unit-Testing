namespace _04.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            //Calculation
            for (int i = 7; i <= n; i++)
            {
                if (i % 10 == 7)
                {
                    //Output
                    Console.WriteLine(i);
                }
            }
        }
    }
}
