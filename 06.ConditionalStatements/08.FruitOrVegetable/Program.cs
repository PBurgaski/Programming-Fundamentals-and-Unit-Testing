namespace _08.FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            string element = Console.ReadLine();
            string result = "";

          // Calculations
            switch (element)
            {
                case "banana" or "apple" or "kiwi" or "cherry" or "lemon":
                    result = "fruit";
                    break;
                case "cucumber" or "pepper" or "carrot":
                    result = "vegetable";
                    break;
                default:
                    result = "unknown";
                    break;
            }
            // Output
            Console.WriteLine(result);
        }
    }
}
