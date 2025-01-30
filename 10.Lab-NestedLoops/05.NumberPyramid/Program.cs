namespace _05.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int number = int.Parse(Console.ReadLine());
            int current = 1;
            //Calculation
            for (int rows = 1; true; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    //Output
                    Console.Write(current + " ");
                    current++;
                    if (current > number)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
