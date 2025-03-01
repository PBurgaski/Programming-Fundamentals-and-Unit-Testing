namespace _04.ConvertSecondsToHoursAndMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            int seconds = int.Parse(Console.ReadLine());
            int minutes = 0;
            int hours = 0;
            // Calculations
            minutes = (seconds / 60) % 60;
            hours = seconds / 3600;
            // Output
            Console.WriteLine($"{hours:D2}:{minutes:D2}");
        }
    }
}
