namespace _03.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input 

            int amountOfNylon = int.Parse(Console.ReadLine());
            int amountOfPaint = int.Parse(Console.ReadLine());
            int quantityOfThinner = int.Parse(Console.ReadLine());
            int neededHours = int.Parse(Console.ReadLine());
            double protectiveNylon = 1.50;
            double paintPerLiter = 14.50;
            double paintThinner = 5.00;
            double priceForBags = 0.40;

            //Calculation

            double totalNylonNeeded = (amountOfNylon + 2) * protectiveNylon;
            double totalPaintNeeded = (amountOfPaint * 1.10) * paintPerLiter;
            double totalTinnerNeeded = quantityOfThinner * paintThinner;
            double totalPriceForMaterials = totalNylonNeeded + totalPaintNeeded + totalTinnerNeeded + priceForBags;
            double workPrice = totalPriceForMaterials * 0.30;
            double totalWorkCost = workPrice * neededHours;
            double totalPrice = totalPriceForMaterials + totalWorkCost;

            //Output

            Console.WriteLine($"{totalPrice}");

        }
    }
}