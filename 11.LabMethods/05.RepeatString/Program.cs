namespace _05.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            PrintTextSeveralTimes(text, count);
        }
        // Methods
        static void PrintTextSeveralTimes(string text, int count)
        {
            //Calculation
            for (int i = 0; i < count; i++)
            {
                //Output
                Console.Write(text);
            }
        }
    }
}
