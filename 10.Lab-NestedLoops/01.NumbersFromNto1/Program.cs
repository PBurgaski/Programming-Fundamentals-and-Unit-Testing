namespace _01.NumbersFromNto1
{
    internal class Program
    {
        static void Main(string[] args)
        {       //Input
            int n = int.Parse(Console.ReadLine());
            //Calculation
            for (int i = n; i >= 1; i--)
            {
                //Output
                Console.WriteLine(i);
            }
        }
    }
}
