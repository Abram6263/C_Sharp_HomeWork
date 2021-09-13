using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AttributesClass
{
    
   public class People
    {
        private string name;
        private string lastName;
        [ValidateStringAttribure(@"^А\w*")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [ValidateStringAttribure(@"^А\w*")]
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public People(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

    }
}
