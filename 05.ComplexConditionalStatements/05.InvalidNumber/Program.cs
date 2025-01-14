namespace _05.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int num = int.Parse(Console.ReadLine());
            //Output
            if (num == 0 || num >= 100 && num <= 200)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
