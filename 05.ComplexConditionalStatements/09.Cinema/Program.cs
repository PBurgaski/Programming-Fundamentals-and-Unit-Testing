namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;
            //Input
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int seat = int.Parse(Console.ReadLine());
            //Output
            if (type == "Premiere")
            {
                double count = row * seat;
                double total = count * premiere;
                Console.WriteLine($"{total:F2}");
            }
            else if (type == "Normal")
            {
                double count = row * seat;
                double total = count * normal;
                Console.WriteLine($"{total:F2}");
            }
            else if (type == "Discount")
            {
                double count = row * seat;
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
