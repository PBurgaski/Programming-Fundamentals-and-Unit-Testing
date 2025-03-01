namespace _03.Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            double moneyNeeded = double.Parse(Console.ReadLine());
            if (moneyNeeded < 1 && moneyNeeded > 25000)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            double savedMoney = double.Parse(Console.ReadLine());
            double money = 0.0;
            if (savedMoney < 1 && savedMoney > 25000)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int spendingsDays = 0;
            int daysCounter = 0;
            // Logic & Calculations
            while (!(money >= moneyNeeded || savedMoney >= moneyNeeded))
            {
                daysCounter++;
                string action = Console.ReadLine();
                if (action == "spend")
                {
                    money = double.Parse(Console.ReadLine());
                    if (money < 0.01 && money > 25000)
                    {
                        Console.WriteLine("Invalid input");
                        return;
                    }
                    savedMoney -= money;
                    if (money > savedMoney)
                    {
                        savedMoney = 0;
                    }
                    spendingsDays++;
                }
                if (action == "save")
                {
                    money = double.Parse(Console.ReadLine());
                    if (money < 0.01 && money > 25000)
                    {
                        Console.WriteLine("Invalid input");
                        return;
                    }
                    savedMoney += money;
                }
                if (spendingsDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCounter}");
                    return;
                }
            }
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
        }
    }
}