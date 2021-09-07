using System;
using ClassLibrary1;

namespace task_13
{
    struct Products
    {
        public  string name;
        public string shop;
        public Products(string name, string shop)
        {
            this.name = name;
            this.shop = shop;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Products[] massProduct = { new Products("apple", "Fives"), new Products("bmw", "Luxury"), new Products("bently", "Luxury"), new Products("banana", "Fives"), new Products("tv", "Electronics") };
            Console.WriteLine("Исходный массив продуктов:");
            foreach (var i in massProduct)
            {
                Console.WriteLine(i.name + " " + i.shop);
            }
            Console.WriteLine();

            Array.Sort(massProduct, (x1, x2) => x1.shop.CompareTo(x2.shop));
            Console.WriteLine("Сортированный массив продуктов:");
            foreach (var i in massProduct)
            {
                Console.WriteLine(i.name + " " + i.shop);
            }
            Console.WriteLine();

            string value = "";
            try
            {
                Console.Write("Введите название магазина: ");
                value = Console.ReadLine();
                if (value != massProduct[0].shop && value != massProduct[1].shop && value != massProduct[2].shop &&
                    value != massProduct[3].shop && value != massProduct[4].shop)
                {
                    throw new MyException($"Магазина с названием {value} не существует!!!");
                }
            }
            catch (MyException e)
            {
                Console.WriteLine($"Ошибка!!! {e.Message} ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Продукты имеющиеся в данном магазине:");
            foreach (var i in massProduct)
            {
                if (i.shop == value)
                {
                    Console.WriteLine(i.name);
                }
            }
            Console.ReadKey();
        }
    }
}
