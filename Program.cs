using System;
using System.Threading;


namespace Studio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is Hazel");

            // Hazels Code line    
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            Console.WriteLine("Hello, World!");
            Console.WriteLine("123 123 123 Aston Code Line 123 123 123");
            /* Aston Code */
            int astoncount = 0;
            do
            {
                Console.WriteLine($"Aston Count Num: {astoncount}");
                astoncount++;
                Thread.Sleep(1000);
            } while (astoncount != 10);
            Console.WriteLine("Jays Turn!!");
            Console.ReadLine();

            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("-+-");
                }
                Console.WriteLine("Press enter");
                Console.ReadLine();

                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(":(");
                }

                Console.WriteLine(":)");
                Thread.Sleep(500);
                Console.WriteLine(":(");
                Thread.Sleep(500);
                Console.WriteLine(":)");
                Thread.Sleep(500);
                Console.WriteLine(":(");
                Thread.Sleep(500);
                Console.WriteLine(":)");
                Thread.Sleep(500);
                Console.WriteLine(":(");
                Thread.Sleep(500);
                Console.ReadLine();
            }
        }
    }
}
