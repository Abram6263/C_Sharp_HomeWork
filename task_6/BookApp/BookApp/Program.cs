using System;
using ClassLibrary1;

namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library l1 = new Library();
            l1.SearchByNumberBook(2);
            l1.SearchByNameBook("Книга 1");
            l1.SearchFatBook();

            
            #region Сортировка пузырьком
            int[] array = { 7, 4, 12, 9, 1 };
            Console.Write("Изначальный массив: ");
            foreach(int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\nСортированный массив: ");
            array.BubleSort();
            foreach(int i in array)
            {
                Console.Write($"{i} ");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
