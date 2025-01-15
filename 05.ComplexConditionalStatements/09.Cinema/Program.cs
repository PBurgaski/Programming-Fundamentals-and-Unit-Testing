namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int seat = int.Parse(Console.ReadLine());
            //Calculations
            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;
            double count = row * seat;
            //Output
            if (type == "Premiere")
            {
                double total = count * premiere;
                Console.WriteLine($"{total:F2}");
            }
            else if (type == "Normal")
            {
                double total = count * normal;
                Console.WriteLine($"{total:F2}");
            }
            else if (type == "Discount")
            {
                double total = count * discount;
                Console.WriteLine($"{total:F2}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
