namespace _07.ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            //Calculations
            for (int i = firstNumber; i <= secondNumber; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
