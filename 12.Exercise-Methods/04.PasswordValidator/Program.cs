//namespace _04.PasswordValidator
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {   //Input
//            string password = Console.ReadLine();
//            //Calculations + Output
//            if (!(IsValidPasswordLength(password)))
//            {
//                Console.WriteLine("Password must be between 6 and 10 characters" + Environment.NewLine);
//            }
//            if (!(IsValidPasswordCharacters(password)))
//            {
//                Console.WriteLine($"Password must consist only of letters and digits" + Environment.NewLine);
//            }
//            if (!(IsValidDiggits(password)))
//            {
//                Console.WriteLine($"Password must have at least 2 digits" + Environment.NewLine);
//            }
//            bool isValid = IsValidPasswordLength(password) && IsValidPasswordCharacters(password) && IsValidDiggits(password);
//            if (isValid)
//            {
//                Console.WriteLine("Password is valid");
//            }
//        }
//            //Methods
//        static bool IsValidPasswordLength(string password)
//        {
//            bool isValid = password != null && password.Length >= 6 && password.Length <= 10;
//            return isValid;
//        }
//        static bool IsValidPasswordCharacters(string password)
//        {
//            bool isValid = password.All(char.IsLetterOrDigit);
//            return isValid;
//        }
//        static bool IsValidDiggits(string password)
//        {
//            bool isValid = (password.Count(char.IsDigit) >= 2);
//            return isValid;
//        }
//    }
//}

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string password = Console.ReadLine();
            bool isLengthValid = IsValidPasswordLength(password);
            bool isCharactersValid = IsValidPasswordCharacters(password);
            bool isDigitsValid = IsValidDigits(password);

            // Calculations + Output
            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isCharactersValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isDigitsValid)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLengthValid && isCharactersValid && isDigitsValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        // Methods
        static bool IsValidPasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool IsValidPasswordCharacters(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }
        static bool IsValidDigits(string password)
        {
            return password.Count(char.IsDigit) >= 2;
        }
    }
}