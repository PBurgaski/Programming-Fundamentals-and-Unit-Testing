namespace _09.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Input
            int firstRow = int.Parse(Console.ReadLine());
            int secondRow = int.Parse(Console.ReadLine());
            int thirdRow = int.Parse(Console.ReadLine());
            //Calculations
            int minutes = (firstRow + secondRow + thirdRow) / 60;
            int seconds = (firstRow + secondRow + thirdRow) % 60;
            //Output
            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}
