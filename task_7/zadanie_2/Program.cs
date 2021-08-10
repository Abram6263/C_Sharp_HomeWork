using System;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue;
            int[,] mass = { { 3, 12, 6 }, { 7, 1, 28 }, { 9, 3, 21 } };
            for(int i = 0; i <= mass.GetUpperBound(0); i++)
            {
                maxValue = 0;
                for (int k = 0; k <= mass.GetUpperBound(1); k++)
                {
                    if(mass[i,k] > maxValue)
                    {
                        maxValue = mass[i, k];
                    }
                }
                Console.WriteLine($"В ряду {i + 1} самое больше значение: {maxValue}");
            }

            Console.ReadKey();
        }
    }
}
