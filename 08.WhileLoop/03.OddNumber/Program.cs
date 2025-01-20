namespace _03.OddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int number = int.Parse(Console.ReadLine());
            //Calculations
            while (number % 2 == 0)
            {
                number = int.Parse(Console.ReadLine());
            }
            //Output
            Console.WriteLine(number);
        }
    }
}
