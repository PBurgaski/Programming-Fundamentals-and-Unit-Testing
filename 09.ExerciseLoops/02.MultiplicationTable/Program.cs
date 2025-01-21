namespace _02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int number = int.Parse(Console.ReadLine());
            //Calculation
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                //Output
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}
