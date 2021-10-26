using System;

namespace vek
{
    class Program
    {
        static void Main(string[] args)
        {
            double roknarozeni;
            double vek;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("vypocet veku");
                Console.Write("rok narozeni:");
                double.TryParse(Console.ReadLine(), out roknarozeni);

                int aktualnirok = DateTime.Now.Year;
                vek = aktualnirok - roknarozeni;
                Console.WriteLine($"tvuj vek je {vek}");


                Console.ReadLine();
            }
        }
        static void Frameboard; 
    }
}
