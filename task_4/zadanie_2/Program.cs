using System;
using System.Text;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "";
            var s1 = new StringBuilder();
            string s2;
            int num1 = 201;
            while (num1 < 500)
            {
                if (num1 % 17 == 0)
                {
                    s1.Append(num1.ToString() + ", ");
                    //s1 += Convert.ToString(num1 + ", ");
                }
                num1++;
            }
            s1.Remove(s1.Length - 2, 2);
            s2 = s1.ToString();
            Console.WriteLine(s2);
            //Console.WriteLine(s1.Remove(s1.Length - 2));

            Console.ReadKey();
        }
    }
}
