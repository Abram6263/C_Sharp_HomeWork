using ClassLibrary1;
using System;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var blue = new BluePrint();
            var green = new GreenPrint();
            var room = new Room();
            room.Printer = blue;
            room.MakeThisLazyPrinterWork("Какой то синий текст");
            room.Printer = green;
            room.MakeThisLazyPrinterWork("Како то зеленый текст");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
