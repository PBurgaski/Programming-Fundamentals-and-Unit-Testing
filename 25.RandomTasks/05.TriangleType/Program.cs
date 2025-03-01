namespace _05.TriangleType
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            int[] triangleSides = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sideA = triangleSides[0];
            int sideB = triangleSides[1];
            int sideC = triangleSides[2];
            // Logic & Output
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                Console.WriteLine("Not a Triangle");
            }
            else
            {
                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("Equilateral");
                }
                else if ((sideA == sideB || sideA == sideC) || (sideB == sideA || sideB == sideC) || (sideC == sideB || sideC == sideA))
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }
            }
        }
    }
}
