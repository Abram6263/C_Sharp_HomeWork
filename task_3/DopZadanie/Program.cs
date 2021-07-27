using System;

namespace DopZadanie
{
    class Program
    {
        static int Delit (int a, int b)
        {
            return a % b;
        }

        // сделал для двух чисел так как не понимаю как математически рассчитывается нод для большего кол-ва чисел
        static void Main(string[] args)
        {

            int x, y;
            int ost;

            Console.Write("Введите первое число: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                ost = Delit(x, y);
                x = y;
                y = ost;
            }
            else
            {
                ost = Delit(y, x);
                y = ost;
            }

            while(true)
            {
                ost = Delit(x, y);
                x = y;
                if(ost > 0)
                {
                    y = ost;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"НОД = {y}");


            Console.ReadKey();
        }
    }
}
