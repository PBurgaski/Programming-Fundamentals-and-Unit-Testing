namespace _02.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int centurie = int.Parse(Console.ReadLine());
            //Calculation
            int years = centurie * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            //Output
            Console.WriteLine($"{centurie} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}