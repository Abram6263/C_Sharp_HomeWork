using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18_D
{
    class People
    {
        public string Name { get; set; }
        public string PhoneModel { get; set; }

        public People(string name, string model)
        {
            Name = name;
            PhoneModel = model;
        }
    }
}
