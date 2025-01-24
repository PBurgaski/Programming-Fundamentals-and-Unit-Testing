namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            double balance = 0;
            //Calculation
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine($"Balance: {balance:F2}");
                    break;
                }
                double money = double.Parse(input);

                if (money < 0)
                {
                    money = money - money - money;
                    balance -= money;
                    Console.WriteLine($"Decrease: {money:F2}");
                }
                else if (money > 0)
                {
                    balance += money;
                    Console.WriteLine($"Increase: {money:F2}");
                }
            }
        }
    }
}
