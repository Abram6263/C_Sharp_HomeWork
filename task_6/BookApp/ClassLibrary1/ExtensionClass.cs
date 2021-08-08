using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
   public static class ExtensionClass
    {
        public static void SearchFatBook(this Library lib)
        {
            int maxValue = 0;
            int num = 0;
            Book[] b;
            b = lib.GetBooks();
            for (int i= 0; i < b.Length; i++)
            {
                if(b[i].ValuePages > maxValue)
                {
                    maxValue = b[i].ValuePages;
                    num = i;
                }
            }
            Console.WriteLine($"Самая толстая книга: \n{b[num].NameBook} {b[num].LibraryWithBook} страниц {b[num].ValuePages}");
        }

        public static void Swap(ref int x1, ref int x2)
        {
            int b = x1;
            x1 = x2;
            x2 = b;
        }
        public static int[] BubleSort(this int[] mass)
        {
            for(int i = 0; i < mass.Length-1; i++)
            {
                for(int k = i+1; k < mass.Length; k++)
                {
                    if(mass[k] < mass[i])
                    {
                        Swap(ref mass[i], ref mass[k]);
                    }
                }
            }

            return mass; 
        }
    }
}
