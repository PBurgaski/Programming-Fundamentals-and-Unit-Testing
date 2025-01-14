namespace _04.FoodOrDrink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string item = Console.ReadLine();
            //Output
            if (item == "curry" || item == "noodles" || item == "sushi" || item == "spaghetti" || item == "bread")
            {
                Console.WriteLine("food");
            }
            else if (item == "tea" || item == "water" || item == "coffee" || item == "juice")
            {
                Console.WriteLine("drink");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
