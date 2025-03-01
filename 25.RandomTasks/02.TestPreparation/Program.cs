namespace _02.TestPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            int poorScoreCount = int.Parse(Console.ReadLine());
            int counter = 0;
            int poorScoreCounter = 0;
            int score = 0;
            double avarageScore = 0.0;
            double result = 0.0;
            string problem = string.Empty;
            string task = string.Empty;
            string lastTask = string.Empty;
            // Logic & Calculations & Output
            if (poorScoreCount < 1 && poorScoreCount > 5)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            while (!(task == "Enough"))
            {
                task = Console.ReadLine();
                score = int.Parse(Console.ReadLine());
                if (score < 2 && score > 6)
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
                if (score <= 4)
                {
                    poorScoreCounter++;
                }
                if (poorScoreCounter == poorScoreCount)
                {
                    Console.WriteLine($"You need a break, {counter} poor grades.");
                    return;
                }
                avarageScore += score;
                lastTask = task;
                counter++;
            }
            // Output & Calculations
            result = avarageScore / counter;
            Console.WriteLine($"Average score: {result:F2}");
            Console.WriteLine($"Number of problems: {counter}");
            Console.WriteLine($"Last problem: {lastTask}");

        }
    }
}
