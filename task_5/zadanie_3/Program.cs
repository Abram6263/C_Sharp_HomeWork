using ClassLibrary2;
using System;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var cone = new Cone(10, 3);
            Console.WriteLine($"Площадь основания конуса равна: {cone.SCircle()}");
            Console.WriteLine($"Площадь конуса равна: {cone.SCone()}");

            Console.ReadKey();
        }
    }
}
