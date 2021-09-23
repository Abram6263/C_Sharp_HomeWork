using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace task_18
{
    class Program
    {
        public static IEnumerable<string> SearchWordWIthSimbol(string text, char simbol)
        {
            var str = from t in text.Split()
                      where t.EndsWith(simbol)
                      select t;
            if (str.Count() == 0)
            {
                return null;
            }
            else if (str.Count() > 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return str;
            }
            
        }

        static void Main(string[] args)
        {
            string text = "Жаба бык улыбка пупок ступенька дуб";
            char simbol = 'б';

            try
            {
                foreach (var i in SearchWordWIthSimbol(text, simbol))
                {
                    Console.WriteLine(i);
                }
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine("Ошибка! -> " + outOfRange.Message);
            }

            Console.ReadKey();
        }
    }
}
