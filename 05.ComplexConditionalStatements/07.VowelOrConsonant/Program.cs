using Microsoft.VisualBasic;

namespace _07.VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string letter = Console.ReadLine();
            //Output
            bool isValid = (letter == "B") || (letter == "C") || (letter == "D") || (letter == "F") || (letter == "G") ||
             (letter == "H") || (letter == "J") || (letter == "K") || (letter == "L") || (letter == "M") ||
             (letter == "N") || (letter == "P") || (letter == "Q") || (letter == "R") || (letter == "S") ||
             (letter == "T") || (letter == "V") || (letter == "W") || (letter == "X") || (letter == "Y") ||
             (letter == "Z") || (letter == "b") || (letter == "c") || (letter == "d") || (letter == "f") ||
             (letter == "g") || (letter == "h") || (letter == "j") || (letter == "k") || (letter == "l") ||
             (letter == "m") || (letter == "n") || (letter == "p") || (letter == "q") || (letter == "r") ||
             (letter == "s") || (letter == "t") || (letter == "v") || (letter == "w") || (letter == "x") ||
             (letter == "y") || (letter == "z");
            bool isntValid = (letter == "A") || (letter == "E") || (letter == "I") || (letter == "O") || (letter == "U") ||
         (letter == "a") || (letter == "e") || (letter == "i") || (letter == "o") || (letter == "u");
            if (isValid)
            {
                Console.WriteLine("Consonant");
            }
            else if (isntValid)
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

