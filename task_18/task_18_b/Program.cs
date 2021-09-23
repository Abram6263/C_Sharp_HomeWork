using System;
using System.Linq;
namespace task_18_b
{
    class Program
    {
        // так и не понял как сделать в одном запросе, если это возможно
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 0, -1, 6, 4, -1, -3 };

            var result = (from number in numbers
                          where number >= 0
                          select number).Count();

            Console.WriteLine($"Количество положительных элементов: {result}");

            var result2 = (from number in numbers
                           where number >= 0
                           select number).Average();

            Console.WriteLine($"Среднее значение: {result2}");

            Console.ReadKey();
        }
    }
}
