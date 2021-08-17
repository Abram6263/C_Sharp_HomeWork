using System;

namespace ClassLibrary1
{
    public class Car
    {
        private string name;
        private int valueDoors;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ValueDoors
        {
            get { return valueDoors; }
            set { valueDoors = value; }
        }
    }
}
