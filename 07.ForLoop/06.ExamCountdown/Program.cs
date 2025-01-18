namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int day = int.Parse(Console.ReadLine());
            int currentDay = 0;
            //Calculation
            for (int i = day; i >= 1; i--)
            {
                currentDay = day--;
                Console.WriteLine($"{currentDay} days before the exam");
            }
            //Output
            Console.WriteLine("The exam has come");
        }
    }
}
