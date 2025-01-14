namespace _03.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input

            int num = int.Parse(Console.ReadLine());

            //Output

            if (num >= 0 ||  num <= 3)
            {
                num += 5;
                Console.WriteLine(num);
            }
            else if (num >= 4 || num <= 6)
            {
                num += 15;
                Console.WriteLine(num);
            }
            else if (num >= 7 || num <= 9)
            {
                num += 20;
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
