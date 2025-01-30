namespace _04.Building
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            int countOfFloors = int.Parse(Console.ReadLine());
            int countOfRooms = int.Parse(Console.ReadLine());
            //Calculation
            for (int floorNumber = countOfFloors; floorNumber >= 1; floorNumber--)
            {
                for (int roomNumber = 0; roomNumber < countOfRooms; roomNumber++)
                {
                    if (floorNumber == countOfFloors)
                    {
                        Console.Write($"L{floorNumber}{roomNumber}"); //Output
                    }
                    else if (floorNumber % 2 == 0)
                    {
                        Console.Write($"O{floorNumber}{roomNumber}"); //Output
                    }
                    else if (floorNumber % 2 != 0)
                    {
                        Console.Write($"A{floorNumber}{roomNumber}"); //Output

                    }
                    if (roomNumber == countOfRooms - 1)
                    {
                        Console.WriteLine(); //Output
                    }
                    else
                    {
                        Console.Write(" "); //Output
                    }
                }
            }
        }
    }
}
