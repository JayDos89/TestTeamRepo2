﻿namespace Studio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is Hazel");
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

        }
    }
}
