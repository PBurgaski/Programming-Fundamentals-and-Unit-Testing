namespace _06.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int number;
            //Calculation
            while (true)
            {
                number = int.Parse(Console.ReadLine());
                if (number >= 1 && number <= 100)
                {
                    Console.WriteLine(number); //Output
                    break;
                }
                else
                {
                    number = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
