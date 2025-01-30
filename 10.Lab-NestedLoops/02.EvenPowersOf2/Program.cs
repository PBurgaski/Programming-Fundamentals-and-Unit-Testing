namespace _02.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int baseNumber = 2;
            int maxPower = int.Parse(Console.ReadLine());
            int result = 1;
            //Calculation
            for (int power = 0; power <= maxPower; power += 2)
            {
                //Output
                Console.WriteLine(result);
                result = result * baseNumber * baseNumber;
            }
        }
    }
}
