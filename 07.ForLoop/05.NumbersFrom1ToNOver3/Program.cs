using System.Runtime.CompilerServices;

namespace _05.NumbersFrom1ToNOver3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            //Calculations
            for (int i = 1; i <= n; i += 3)
            {
                //Output
                Console.WriteLine(i);
            }
        }
    }
}
