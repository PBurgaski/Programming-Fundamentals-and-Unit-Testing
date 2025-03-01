namespace _01.LibraryChecker
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            string bookToFind = Console.ReadLine();
            int counter = 0;
            bool IsBookFinded = false;
            // Logic & Calculations & Output
            while (!IsBookFinded)
            {
                string bookName = Console.ReadLine();
                if (bookName == bookToFind) 
                { 
                    IsBookFinded = true;
                    Console.WriteLine($"You checked {counter} books and found it.");
                }
                else if (bookName == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                    counter++;

            }
        }
    }
}