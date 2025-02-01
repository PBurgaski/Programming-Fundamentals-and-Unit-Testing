namespace _01.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {    //Input
            string text = Console.ReadLine();
            CountVowels(text);
        }
            //Method
        static void CountVowels(string text)
        {
            int vowelsCount = 0;
            //Calculation
            foreach (char charecter in text)
            {
                if (charecter == 'a')
                {
                    vowelsCount++;
                }
                 if (charecter == 'o')
                {
                    vowelsCount++;
                }
                 if (charecter == 'u')
                {
                    vowelsCount++;
                }
                 if (charecter == 'i')
                {
                    vowelsCount++;
                }
                 if (charecter == 'e')
                {
                    vowelsCount++;
                }
                 if (charecter == 'A')
                {
                    vowelsCount++;
                }
                 if (charecter == 'O')
                {
                    vowelsCount++;
                }
                 if (charecter == 'U')
                {
                    vowelsCount++;
                }
                 if (charecter == 'I')
                {
                    vowelsCount++;
                }
                 if (charecter == 'E')
                {
                    vowelsCount++;
                }
            }
                //Output
                Console.WriteLine(vowelsCount);
        }
    }
}
