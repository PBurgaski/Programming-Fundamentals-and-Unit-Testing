namespace _01.PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int result = 1;
            //Calculation
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            //Output
            Console.WriteLine(result);
        }
    }
}