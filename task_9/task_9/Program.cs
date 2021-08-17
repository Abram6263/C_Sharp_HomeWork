using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new MyCollection<Car>();
            car.AddInList(new Car { Name = "Car 1", ValueDoors = 2 });
            car.AddInList(new Car { Name = "Car 2", ValueDoors = 3 });
            car.AddInList(new Car { Name = "Car 3", ValueDoors = 2 });
            Console.WriteLine("Список машин: ");
            for (int i = 0; i < car.GetCount(); i++)
            {
                Console.WriteLine(car[i].Name + " дверей:" + car[i].ValueDoors);
            }
            Console.WriteLine("Количество элементов: " + car.GetCount());
            var boat = new MyCollection<Boat>();
            boat.AddInList(new Boat { Name = "Boat 1", ValueMotors = 2 });
            boat.AddInList(new Boat { Name = "Boat 2", ValueMotors = 3 });
            for (int i = 0; i < boat.GetCount(); i++)
            {
                Console.WriteLine(boat[i].Name + " дверей:" + boat[i].ValueMotors);
            }
            Console.WriteLine("Количество элементов: " + boat.GetCount());
            Console.ReadKey();
        }
    }
}
