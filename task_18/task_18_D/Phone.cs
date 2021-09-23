using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18_D
{
  public  class Phone
    {
        public string PhoneModel { get; set; }
        public int YearOfCreation { get; set; }

        public Phone(string model, int year)
        {
            PhoneModel = model;
            YearOfCreation = year;
        }
    }
}
