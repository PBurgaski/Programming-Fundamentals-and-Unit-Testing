namespace _01.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            List<int> numberList = Console.ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToList();
            string command = "";
            //Calculations
            while (command != "end")
            {
                command = Console.ReadLine();
                string[] commandNumber = command.Split();
                string commandAction = commandNumber[0];
                if (commandAction == "Delete")
                {
                    numberList.RemoveAll(n => n == int.Parse(commandNumber[1]));
                }
                else if (commandAction == "Insert")
                {
                    int number = int.Parse(commandNumber[1]);
                    int index = int.Parse(commandNumber[2]);
                    numberList.Insert(index, number);
                }
            }
            //Output
            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
