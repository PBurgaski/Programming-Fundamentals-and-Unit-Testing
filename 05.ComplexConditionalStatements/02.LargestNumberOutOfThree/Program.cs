namespace _02.LargestNumberOutOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            //Output
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1);
                }
            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2);
                }
            else if (num3 > num1)
            {
                if (num3 > num2)
                {
                    Console.WriteLine(num3);
                }
            }
            }
        }
    }
}
