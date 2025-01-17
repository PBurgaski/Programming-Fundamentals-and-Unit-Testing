namespace _010.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int temperature = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string shoes = "";
            string clothing = "";
            //Calculations
            if (temperature >= 10 && temperature <= 42)
            {
                if (timeOfDay == "Morning" && (temperature >= 10 && temperature <= 18))
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfDay == "Afternoon" && (temperature >= 10 && temperature <= 18))
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Evening" && (temperature >= 10 && temperature <= 18))
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Morning" && (temperature > 18 && temperature <= 24))
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Afternoon" && (temperature > 18 && temperature <= 24))
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Evening" && (temperature > 18 && temperature <= 24))
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Morning" && temperature >= 25)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon" && temperature >= 25)
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening" && temperature >= 25)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    Console.WriteLine("invalid temperature");
                }
                //Output
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
        }
    }
}
