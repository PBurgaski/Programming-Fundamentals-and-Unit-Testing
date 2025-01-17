namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string result = "";
            // Calculation
            bool workingHours = hour >= 10 && hour <= 18;
            if (day == "Sunday")
            {
                result = "closed";
            }
            else if (day == "Saturday" || day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
            {
                if (workingHours)
                {
                    result = "open";
                }
                else if (!workingHours)
                {
                    result = "closed";
                }
            }
            //Output
            Console.WriteLine(result);
        }
    }
}
