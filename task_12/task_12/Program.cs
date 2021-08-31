using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var client1 = new Client("News", "SportNews");
            client1.AddSubscribe("Humor");
            client1.StartMailing();

            Console.ReadKey();
        }
    }
}
