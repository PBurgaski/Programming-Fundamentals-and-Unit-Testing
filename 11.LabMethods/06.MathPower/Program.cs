namespace _06.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int baseNumber = int.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());
            MathPow(baseNumber, powerNumber);
        }
        // Methods
        static void MathPow(int baseNumber, int powerNumber)
        {
            int result = 1;
            //Calculation
            for (int i = 1; i <= powerNumber; i++)
            {
                result *= baseNumber;
            }
            //Output
            Console.WriteLine(result);
        }
    }
}
