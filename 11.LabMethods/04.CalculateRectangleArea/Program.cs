namespace _04.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            PrintRectangleArea(width, length);

        }
        //Methods
        static void PrintRectangleArea(int width, int height)
        {
            //Calculation
            int result = width * height;
            //Output
            Console.WriteLine(result);
        }
    }
}
