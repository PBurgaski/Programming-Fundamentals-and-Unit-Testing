namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            //Calculation
            for (int i = 1; i <= n; i++)
            {
                sum += double.Parse(Console.ReadLine());

            }
            //Output
            Console.WriteLine(sum);
        }
    }
}
