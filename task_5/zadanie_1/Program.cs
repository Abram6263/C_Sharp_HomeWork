using ClassLibrary1;
using System;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 1, 2, 3, 4, 5 };
            #region Инвертирование массива

            Console.Write("Исходный массив: ");
            foreach (int i in mass)
            {
                Console.Write($"{i} ");
            }

            mass = ArrayWorker.MassInvert(mass);
            Console.Write("\nИвертированный массив: ");
            foreach(int i in mass)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            #endregion
            #region Добавление нового элемент в массив

            mass = ArrayWorker.MassNewValue(mass, 3, 12);
            foreach (int i in mass)
            {
                Console.Write($"{i} ");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
