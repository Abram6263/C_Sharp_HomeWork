using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Room
    {
        private Printer printer;
        public Printer Printer
        {
            get { return printer; }
            set { printer = value; }
        }
        public void MakeThisLazyPrinterWork(string value)
        {
           Console.WriteLine( printer.Print(value));
        }
    }
}
