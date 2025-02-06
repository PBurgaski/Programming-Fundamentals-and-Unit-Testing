namespace _06.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            string product = Console.ReadLine();
            //Calculations
            if (product == "coffee")
            {
                CoffeeProduct();
            }
            else if (product == "water")
            {
                WaterProduct();
            }
            else if (product == "coke")
            {
                CokeProduct();
            }
            else if (product == "snacks")
            {
                SnacksProduct();
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
        //Methods
        private static void SnacksProduct()
        {
            int quantity = int.Parse(Console.ReadLine());
            double priceOfProduct = 2.00;
            double result = priceOfProduct * quantity;
            Console.WriteLine($"{result:F2}");
        }

        private static void CokeProduct()
        {
            int quantity = int.Parse(Console.ReadLine());
            double priceOfProduct = 1.40;
            double result = priceOfProduct * quantity;
            Console.WriteLine($"{result:F2}");
        }

        private static void WaterProduct()
        {
            int quantity = int.Parse(Console.ReadLine());
            double priceOfProduct = 1.00;
            double result = priceOfProduct * quantity;
            Console.WriteLine($"{result:F2}");
        }

        private static void CoffeeProduct()
        {
            int quantity = int.Parse(Console.ReadLine());
            double priceOfProduct = 1.50;
            double result = priceOfProduct * quantity;
            Console.WriteLine($"{result:F2}");
        }
    }
}
