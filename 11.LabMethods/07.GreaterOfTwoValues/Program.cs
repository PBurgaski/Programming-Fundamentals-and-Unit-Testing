namespace _07.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var firstValue = Console.ReadLine();
            var secondValue = Console.ReadLine();
            //Calculation
            if (type == "int")
            {
                CalculateGreaterIntegerValue(int.Parse(firstValue), int.Parse(secondValue));
            }
            else if (type == "char")
            {
                CalculateGreaterCharValue(char.Parse(firstValue), char.Parse(secondValue));
            }
            else if (type == "string")
            {
                CalculateGreaterStringValue(firstValue, secondValue);
            }
        }
            //Method
            static void CalculateGreaterCharValue(char firstValue, char secondValue)
            {
                //Input
                char result = 'а';
                //Calculation
                if (firstValue > secondValue)
                {
                    result = firstValue;
                }
                else
                {
                    result = secondValue;
                }
                //Output
                Console.WriteLine(result);
            }
            //Method
            static void CalculateGreaterStringValue(string firstValue, string secondValue)
            {
                //Input
                string result = "";
                //Calculation
                if (firstValue.CompareTo(secondValue) > 0)
                {
                    result = firstValue;
                }
                else
                {
                    result = secondValue;
                }
                //Output
                Console.WriteLine(result);
            }
            //Method
            static void CalculateGreaterIntegerValue(int firstValue, int secondValue)
            {
                //Input
                int result = 0;
                //Calculation
                if (firstValue > secondValue)
                {
                    result = firstValue;
                }
                else
                {
                    result = secondValue;
                }
                //Output
                Console.WriteLine(result);
            }

    }
}
