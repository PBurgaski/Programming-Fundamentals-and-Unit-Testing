namespace _02.ATM
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());
            string result = "null";
            //Calculations
            if (limit < withdraw)
            {
                result = "The limit was exceeded.";
            }
            else if (withdraw > balance)
            {
                result = "Insufficient availability.";
            }
            else if (limit > withdraw && withdraw < balance)
            {
                result = "The withdraw was successful.";
            }
            // Output
            Console.WriteLine($"{result}");
        }
    }
}
