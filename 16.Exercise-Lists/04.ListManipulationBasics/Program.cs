namespace _04.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string command = "";
            //Logic
            while (true)
            {
                command = Console.ReadLine();
                if (command == "end") 
                {
                    break;
                }
                List<string> listOfCommands = command.Split(" ").ToList();
                string action = listOfCommands[0];
                int number = int.Parse(listOfCommands[1]);
                switch (action)
                {
                    case "Add":
                        numbers.Add(number);
                        break;
                    case "Remove":
                        numbers.Remove(number);
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(number);
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(listOfCommands[2]), number);
                        break;
                }
            }
            //Output
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
