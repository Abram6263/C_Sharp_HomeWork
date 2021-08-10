using System;
using ClassLibrary1;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[6];
            mass.FillMass();
            mass.OutMass();
            mass.BubleSort();
            mass.OutMass();

            Console.ReadKey();
        }
    }
}
