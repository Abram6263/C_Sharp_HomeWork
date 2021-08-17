using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class BluePrint : Printer
    {
        public override string Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return value;
        }
    }
}
