

namespace _03.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string commandInput = "";
            //Logic 
            while (true)
            {
                commandInput = Console.ReadLine();

                List<string> input = commandInput.Split(" ").ToList();
                string command = input[0];
                if (command == "End")
                {
                    break;
                }
                string shiftDirection = input[1];
                if (command == "Add")
                {
                    numbers.Add(int.Parse(input[1]));
                    continue;
                }
                else if (command == "Insert")
                {
                    if (int.Parse(input[2]) < 0 || int.Parse(input[2]) >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                    continue;
                }
                else if (command == "Remove")
                {
                    if (int.Parse(input[1]) < 0 || int.Parse(input[1]) >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(int.Parse(input[1]));
                    continue;
                }
                else if (command == "Shift")
                {
                    int count = int.Parse(input[2]);
                    count %= numbers.Count;
                    if (shiftDirection == "left")
                    {
                        ShiftInLeft(numbers, count);
                        continue;
                    }
                    else if (shiftDirection == "right")
                    {
                        ShiftInRight(numbers, count);
                        continue;
                    }
                }

            }
            //Output
            Console.WriteLine(string.Join(" ", numbers));
        }
        public static void ShiftInLeft(List<int> numbers, int countOfShifts)
        {
            for (int i = 0; i < countOfShifts; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }
        public static void ShiftInRight(List<int> numbers, int countOfShifts)
        {
            for (int i = 0; i < countOfShifts; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}
