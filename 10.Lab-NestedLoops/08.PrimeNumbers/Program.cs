namespace _08.PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            //Calculation
            for (int num = startNumber; num <= endNumber; num++)
            {
                int primeCounter = 0;
                for (int i = 1; i <= num; i++) 
                {
                    if (num % i == 0)
                    {
                        primeCounter++;
                    }
                }
                if (primeCounter == 2)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }
    }
}
