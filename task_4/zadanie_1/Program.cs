using System;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Введите число: ");
            num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 30)
            {
                Console.WriteLine("Число попало в промежуток от 0 до 30");
            }
            else if (num >= 31 && num <= 60)
            {
                Console.WriteLine("Число попало в промежуток от 31 до 60");
            }
            else if (num >= 61 && num <= 100)
            {
                Console.WriteLine("Число попало в промежуток от 61 до 100");
            }
            else
            {
                Console.WriteLine("Я такого числа не знаю!");
            }

            Console.ReadKey();
        }
    }
}
