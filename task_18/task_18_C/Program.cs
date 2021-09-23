using System;
using System.Linq;

namespace task_18_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Женя скоро будет свободен, а у вас все только начинается";


            var str = from t in text
                      where t != 'о'
                      select t;
            
            foreach(var i in str)
            {
                Console.Write(i);
            }

            Console.ReadKey();
        }
    }
}
