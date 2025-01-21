namespace _03.BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int n = int.Parse(Console.ReadLine());
            int result = int.MinValue;
            //Calculation
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > result)
                {
                    result = num;
                }

            }
            //Output
            Console.WriteLine(result);
        }
    }
}
