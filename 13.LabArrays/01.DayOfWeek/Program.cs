namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int.TryParse(Console.ReadLine(), out int day);
            string[] daysOfWeek = new string[]
            {
            "Monday" ,
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
            };
            //Output
            if (day == 0)
            {
                Console.WriteLine(daysOfWeek[day]);
            }
            else if (day >= 1 && day <= 7) 
            {
            Console.WriteLine(daysOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
