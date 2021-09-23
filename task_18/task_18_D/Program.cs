using System;
using System.Collections.Generic;
using System.Linq;

namespace task_18_D
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача: даны тип People со свойствами Name и phoneModel и тип Phone со свойствами PhoneModel и YearOfCreation.
            // Создать 8 человек и 8 телефонов.
            // Отсортировать по году выпуска телефона и вывести на консоль 2 человека начиная с третьего, у которых телефоны 2020 года

            List<People> peoples = new List<People>
            {
                new People("Никита", "iphone 12"),
                new People("Дима", "iphone 12pro"),
                new People("Илья", "samsung flip Z"),
                new People("Даша", "huawei P40"),
                new People("Влад", "iphone 11"),
                new People("Настя", "galaxy s10"),
                new People("Глеб", "galaxy A7"),
                new People("Света", "huawei P Smart"),
            };
            List<Phone> phones = new List<Phone>
            {
                new Phone("samsung flip Z", 2021),
                new Phone("iphone 12pro", 2020),
                new Phone("iphone 11", 2019),
                new Phone("huawei P Smart", 2020),
                new Phone("huawei P40", 2020),
                new Phone("galaxy s10", 2020),
                new Phone("galaxy A7", 2017),
                new Phone("iphone 12", 2020)
            };

            var result = (from people in peoples
                         join phone in phones
                         on people.PhoneModel equals phone.PhoneModel
                         select new { Name = people.Name, PhoneModel = people.PhoneModel, Year = phone.YearOfCreation }).OrderBy(p => p.Year);

            Console.WriteLine("Изначальный список:");
            foreach(var i in result)
            {
                Console.WriteLine($"{i.Name} \t{i.PhoneModel} \t{i.Year}");
            }
            Console.WriteLine();

            var result2 = (from p in result
                           where p.Year == 2020
                           select p).Skip(2).Take(2);

            Console.WriteLine("Конечный список: ");
            foreach (var i in result2)
            {
                Console.WriteLine($"{i.Name} \t{i.PhoneModel} \t{i.Year}");
            }
            Console.ReadLine();
        }
    }
}
