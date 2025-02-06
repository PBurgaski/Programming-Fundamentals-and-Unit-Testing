namespace _03.ReverseAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {       //Input
            int number = int.Parse(Console.ReadLine());
            int[] numArr = new int[number];
                //Calculations
            for (int i = number - 1 ; i >= 0; i--)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < number; j++)
            {
                //Output
                Console.Write(numArr[j] + " ");
            }
        }
    }
}
