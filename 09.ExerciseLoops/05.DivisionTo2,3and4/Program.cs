namespace _05.DivisionTo2_3and4
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int divBy2 = 0;
            int divBy3 = 0;
            int divBy4 = 0;
            //Calculation
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse((Console.ReadLine()));
                if (num % 2 == 0)
                {
                    divBy2++;
                }
                if (num % 3 == 0)
                {
                    divBy3++;
                }
                if (num % 4 == 0)
                {
                    divBy4++;
                }
            }
            double percentageDivBy2 = (divBy2 / (double)n) * 100;
            double percentageDivBy3 = (divBy3 / (double)n) * 100;
            double percentageDivBy4 = (divBy4 / (double)n) * 100;
            //Output
            Console.WriteLine($"{percentageDivBy2:F2}%");
            Console.WriteLine($"{percentageDivBy3:F2}%");
            Console.WriteLine($"{percentageDivBy4:F2}%");
        }
    }
}
