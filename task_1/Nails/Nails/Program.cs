using System;

namespace Nails
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount, hits; // amount - кол-во гвоздей, hits - удары
            Random rnd = new Random();
            amount = rnd.Next(1, 11);
            
            for (int i = 1; i <= amount; i++)
            {
                Console.Write($"Гвоздь номер {i}:");
                hits = rnd.Next(1, 6);
                for (int j = 1; j <= hits; j++)
                {
                    Console.Write(" стук");
                }
                Console.WriteLine(" Гвоздь забит!!!");
            }
            
            Console.ReadKey();
        }
    }
}
