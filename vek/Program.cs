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
                if (vek > 0 & vek < 14) 
                {
                    Console.WriteLine();
                    Console.WriteLine("jsi stale dite"); 
                }
                if (vek > 15 & vek <19)
                {
                    Console.WriteLine();
                    Console.WriteLine("jsi student");
                }
                if (vek > 19 & vek < 23)
                {
                    Console.WriteLine();
                    Console.WriteLine("jsi mozna student vysoke skoly");
                }
                if (vek >23)
                {
                    Console.WriteLine();
                    Console.WriteLine("pomalu umiras");
                }

                Console.ReadLine();
            }
        }
         
    }
}
