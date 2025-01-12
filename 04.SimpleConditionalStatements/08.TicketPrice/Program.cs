namespace _08.TicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string person = Console.ReadLine();
         if (person == "student")
            {
                double price = 1.00;
                Console.WriteLine($"${price:F2}");
            }
         else if (person == "regular")
            {
                double price = 1.60;
                Console.WriteLine($"${price:F2}");
            }
         else
            {
                Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}
