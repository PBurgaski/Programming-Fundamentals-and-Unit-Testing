namespace _05.BasketballEquipment
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Input

            int annualFee = int.Parse(Console.ReadLine());

            //Calculation 

            double sneakersPrice = annualFee - (annualFee * 0.40);
            double uniformPrice = sneakersPrice - (sneakersPrice * 0.20);
            double ballPrice = uniformPrice / 4;
            double accessoriesPrice = ballPrice / 5;
            double totalPrice = annualFee + sneakersPrice + uniformPrice + ballPrice + accessoriesPrice;

            //Output
            Console.WriteLine($"{totalPrice}");
        }
    }
}