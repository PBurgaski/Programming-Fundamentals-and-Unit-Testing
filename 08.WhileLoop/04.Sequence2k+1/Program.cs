namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int start = int.Parse(Console.ReadLine());
            int number = 1;

            //Calculations
            while (start >= number)
            {
                Console.WriteLine(number); //Output
                number = (number * 2) +1;
            }
        }
    }
}
