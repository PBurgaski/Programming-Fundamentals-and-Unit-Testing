namespace _01.WaterConsumption
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            int n = int.Parse(Console.ReadLine());
            int dayIntake = 0;
            // Calculations & Output
            for (int i = 1; i <= n; i++)
            {
                int amountOfConsumptionInMil = int.Parse(Console.ReadLine());
                dayIntake += amountOfConsumptionInMil;
                Console.WriteLine(dayIntake);
            }
            // Output
            if (n <= 0)
            {
                Console.WriteLine(dayIntake);
            }
        }
    }
}
