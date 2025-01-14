using Microsoft.VisualBasic;

namespace _07.VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            char letter = char.Parse(Console.ReadLine());
            //Output
            bool isValid = (letter == 'A') || (letter == 'E') || (letter == 'I') || (letter == 'O') || (letter == 'U') ||
         (letter == 'a') || (letter == 'e') || (letter == 'i') || (letter == 'o') || (letter == 'u');
            if (isValid)
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}

