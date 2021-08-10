using System;

namespace ClassLibrary1
{
    public static class ExtensionClass
    {
        public static void FillMass( this int[] mass)
        {
            for(int i = 0; i < mass.Length; i++)
            {
                Console.Write($"Введиет {i + 1}-ый элемент массива: ");
                mass[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void OutMass(this int[] mass)
        {
            Console.WriteLine("Ваш массив:");
            foreach (int i in mass)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Swap(ref int x1, ref int x2)
        {
            int b = x1;
            x1 = x2;
            x2 = b;
        }
        public static void BubleSort(this int[] mass)
        {
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int k = i + 1; k < mass.Length; k++)
                {
                    if (mass[k] < mass[i])
                    {
                        Swap(ref mass[i], ref mass[k]);
                    }
                }
            }

        }

    }
}
