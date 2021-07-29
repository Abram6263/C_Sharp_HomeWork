using System;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "";
            int num1 = 201;
            while (num1 < 500)
            {
                if (num1 % 17 == 0)
                {
                    s1 += Convert.ToString(num1 + ", ");
                }
                num1++;
            }

            Console.WriteLine(s1.Remove(s1.Length - 2));

            Console.ReadKey();
        }
    }
}
