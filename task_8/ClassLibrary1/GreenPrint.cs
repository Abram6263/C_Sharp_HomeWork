using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class GreenPrint : Printer
    {
        public override string Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return value;
        }
    }
}
