using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Boat
    {
        private string name;
        private int valueMotors;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ValueMotors
        {
            get { return valueMotors; }
            set { valueMotors = value; }
        }
    }
}
