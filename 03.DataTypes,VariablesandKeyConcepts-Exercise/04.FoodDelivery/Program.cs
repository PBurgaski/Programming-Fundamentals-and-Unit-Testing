namespace _04.FoodDelivery
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Input

            int chickenOrder = int.Parse(Console.ReadLine());
            int fishOrder = int.Parse(Console.ReadLine());
            int vegieOrder = int.Parse(Console.ReadLine());
            // Calculation

            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegieMenu = 8.15;
            double desertPrice = 20 / 100.0;
            double delivery = 2.50;
            double chickenTakeaway = chickenOrder * chickenMenu;
            double fishTakeaway = fishOrder * fishMenu;
            double vegieTakeaway = vegieOrder * vegieMenu;
            double totalTakeaway = chickenTakeaway + fishTakeaway + vegieTakeaway;
            double totalWithDessert = totalTakeaway * desertPrice;
            double orderPrice = totalTakeaway + totalWithDessert + delivery;

            // Output
            Console.WriteLine($"{orderPrice}");
        }
    }
}