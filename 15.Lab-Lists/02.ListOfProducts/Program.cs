namespace _02.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int number = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(number);
            int countNumber = 1;
            //Calculations
            for (int i = 0; i < number; i++)
            {
                products.Add(Console.ReadLine());
                products.Sort();
            }
            foreach (string product in products)
            {
                //Output
                Console.WriteLine($"{countNumber}.{product}");
                countNumber++;
            }
        }
    }
}
