namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            double grade = double.Parse(Console.ReadLine());
            GradeCalculator(grade);
        }
        //Methods
        static void GradeCalculator(double grade)
        {
            //Calculation
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail"); //Output
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Average"); //Output
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good"); //Output
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good"); //Output
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Excellent"); //Output
            }

        }
    }
}
