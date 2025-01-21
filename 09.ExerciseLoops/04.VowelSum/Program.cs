namespace _04.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input
            int n = int.Parse(Console.ReadLine());
            string value = "";
            int result = 0;
            int finalResult = 0;
            //Calculation
            for (int i = 1; i <= n; i++)
            {
                value = Console.ReadLine();
                switch (value)
                {
                    case "a":
                        result = 1;
                        break;
                    case "e":
                        result = 2;
                        break;
                    case "i":
                        result = 3;
                        break;
                    case "o":
                        result = 4;
                        break;
                    case "u":
                        result = 5;
                            break;
                    default:
                        result = 0;
                            break;
                }
                finalResult += result;
            }
            //Output
            Console.WriteLine(finalResult);
        }
    }
}
