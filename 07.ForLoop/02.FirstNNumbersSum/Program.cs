namespace _02.FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            //Calculations
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                sum += i;

                if (i < n)
                    Console.Write("+");
            }
            //Output
            Console.WriteLine("=" + sum);

        }
    }
}
