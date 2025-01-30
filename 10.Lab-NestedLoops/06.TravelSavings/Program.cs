namespace _06.TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            string destination = Console.ReadLine();
            double neededMoney = double.Parse(Console.ReadLine());
            double savedMoney = 0;
            double currentMoney = 0;
            //Calculation
            while (destination != "End")
            {
                currentMoney = double.Parse(Console.ReadLine());
                savedMoney += currentMoney;
                //Output
                Console.WriteLine($"Collected: {savedMoney:F2}");
                if (savedMoney >= neededMoney)
                {
                    Console.WriteLine($"Going to {destination}!");
                    destination = Console.ReadLine();
                    if (destination == "End")
                    {
                        break;
                    }
                    neededMoney = double.Parse(Console.ReadLine());
                    savedMoney = 0;
                    currentMoney = 0;
                }
            }
        }
    }
}
