namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            //Calculation
            for (char letter = first; letter <= last; letter++) 
            { 
                //Output
                Console.Write($" {letter}");
            }
        }
    }
}