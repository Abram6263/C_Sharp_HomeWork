using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            var stopwatch = new Stopwatch();

            for(int i = 0; i < 100000; i++)
            {
                cars.Add(new Car(i));
            }

            stopwatch.Start();
            foreach(var i in cars)
            {
                i.Age = (343 * 34 * 2 * 77) / 567;
            }
            Console.WriteLine($"Foreach: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for(int i = 0; i < 100000; i++)
            {
                cars[i].Age = (343 * 34 * 2 * 77) / 567;
            }
            Console.WriteLine($"For: {stopwatch.Elapsed}");

            stopwatch.Restart();
            Parallel.For(0, cars.Count, (i) => cars[i].Age = (343 * 34 * 2 * 77) / 567);
            Console.WriteLine($"Parallel.For: {stopwatch.Elapsed}");

            stopwatch.Restart();
            Parallel.ForEach(cars, car => car.Age = (343 * 34 * 2 * 77) / 567);
            Console.WriteLine($"Parallel.Foreach: {stopwatch.Elapsed}");
            stopwatch.Stop();
            Console.ReadKey();
        }
    }
}
