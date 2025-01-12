namespace _06.Aquarium
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            //Calculation

            double aquariumVol = length * width * height;
            double aquariumVolInLiters = aquariumVol * 0.001;
            double occupiedSpace = percentage / 100;
            double requiredLiters = aquariumVolInLiters * (1 - occupiedSpace);

            //Output

            Console.WriteLine($"{requiredLiters:F2}");
        }
    }
}