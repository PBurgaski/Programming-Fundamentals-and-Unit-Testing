using System.Linq;
using System.Xml.Linq;

namespace _02.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {//Input      George is not going
            int commandCount = int.Parse(Console.ReadLine());
            List<string> commands = new List<string>();
            List<string> guests = new List<string>();
            for (int i = 0; i < commandCount; i++)
            {
                commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string guestsName = commands[0];
                if (commands.Count == 3)
                {
                    if (!guests.Contains(guestsName))
                    {
                        guests.Add(guestsName);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{guestsName} is already in the list!");
                        continue;
                    }
                }
                else if (commands.Count == 4)
                {
                    if (guests.Contains(guestsName))
                    {
                        guests.Remove(guestsName);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{guestsName} is not in the list!");
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
