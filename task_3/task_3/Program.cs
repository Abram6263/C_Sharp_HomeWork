using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 1 -----------------------------------------------------------------
            const double pi = 3.14;
            double r, l, S;

            Console.Write("Введите радиус окружности: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Введите образующую окружности: ");
            l = double.Parse(Console.ReadLine());
            S = pi * r * (r + l);
            Console.WriteLine($"Площадь окружности равна {S}");

            // задание 2 --------------------------------------------------------------------
            Console.WriteLine("------------------задание 2-----------------------------------------");
            int x = 14, y = 1, z = 5;
            x += y - x++ * z;
            Console.WriteLine($"Переменная x: {x} \nПеременная y: {y} \nПеременная z: {z}");
            z = --x - y * 5;
            Console.WriteLine($"\n\nПеременная x: {x} \nПеременная y: {y} \nПеременная z: {z}");
            y /= x + 5 % z;
            Console.WriteLine($"\n\nПеременная x: {x} \nПеременная y: {y} \nПеременная z: {z}");
            z = x++ + y * 5;
            Console.WriteLine($"\n\nПеременная x: {x} \nПеременная y: {y} \nПеременная z: {z}");
            x = y - x++ * z;
            Console.WriteLine($"\n\nПеременная x: {x} \nПеременная y: {y} \nПеременная z: {z}");


            Console.ReadKey();
        }
    }
}
