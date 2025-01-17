namespace _05.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string season = Console.ReadLine();
            string accommodation = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double discount = 0;
            double price = 0;
            //Calculation
            if (accommodation == "Hotel")
            {
                if (season == "Spring")
                {
                    discount = 0.8;
                    price = 30;
                }
                else if (season == "Summer")
                {
                    discount = 1;
                    price = 50;
                }
                else if (season == "Autumn")
                {
                    discount = 0.7;
                    price = 20;
                }
                else if (season == "Winter")
                {
                    discount = 0.9;
                    price = 40;
                }
            }
            else if (accommodation == "Camping")
            {
                if (season == "Spring")
                {
                    discount = 0.8;
                    price = 10;
                }
                else if (season == "Summer")
                {
                    discount = 1;
                    price = 30;
                }
                else if (season == "Autumn")
                {
                    discount = 0.7;
                    price = 15;
                }
                else if (season == "Winter")
                {
                    discount = 0.9;
                    price = 10;
                }
            }
            double total = (days * price) * discount;
            //Output
            Console.WriteLine($"{total:F2}");
        }
    }
}
