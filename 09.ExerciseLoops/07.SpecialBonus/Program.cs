namespace _07.SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int stopNumber = int.Parse(Console.ReadLine());
            int number = 0;
            double memory = 0;
            //Calculation
            while (true)
            {
                if (stopNumber == number)
                {

                    break;
                }
                memory = number;
                memory *= 1.2;
                number = int.Parse(Console.ReadLine());
            }
            //Output
            Console.WriteLine(memory);
        }
    }
}
