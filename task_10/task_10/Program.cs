using System;
using ClassLibrary1;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list1 = new MyList();
            var item1 = new MyItem() { Value = 10 };
            var item2 = new MyItem() { Value = 20 };
            list1.Add(item1);
            list1.Add(item2);
            foreach(var i in list1)
            {
                Console.WriteLine(i.Value);
            }

            Console.ReadKey();
        }
    }
}
