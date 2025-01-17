namespace _03.BiggestOfFiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());
         int c = int.Parse(Console.ReadLine());
         int d = int.Parse(Console.ReadLine());
         int e = int.Parse(Console.ReadLine());
            int number = int.MinValue;
            //Calculation
            if (a > number)
            {
                number = a;
            }
            if (b > number) 
            {
                number = b;
            }
            if (c > number)
            {
                number = c;
            }
            if (d > number)
            {
                number = d;
            }
            if (e > number)
            {
                number = e;
            }
            //Output
            Console.WriteLine(number);
        }

    }
}
