namespace _07.NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int number = int.Parse(Console.ReadLine());
            string sequence = Console.ReadLine();
            //Calculation
            while (!(sequence == "End"))
            {
                if (sequence == "Inc")
                {
                    number++;
                }
                else if (sequence == "Dec")
                {
                    number--;
                }
                //Output
                sequence = Console.ReadLine();
            }
            Console.WriteLine(number);
        }
    }
}
