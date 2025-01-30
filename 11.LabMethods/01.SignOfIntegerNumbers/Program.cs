namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int number = int.Parse(Console.ReadLine());
            CheckNumber(number);

        }

        //Methods
        static void CheckNumber(int number)
        {
            //Calculation
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive."); //Output
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative."); //Output
            }
            else
            {
                Console.WriteLine($"The number {number} is zero."); //Output
            }

        }
    }
}
