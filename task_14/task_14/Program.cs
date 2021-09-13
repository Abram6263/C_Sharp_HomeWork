using System;
using System.Reflection;
using System.Text.RegularExpressions;
using AttributesClass;


namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var people1 = new People("Александр", "Афанасьев");
            var people2 = new People("Олег", "Ажипа");
            Console.WriteLine(ValidateString(people1));
            Console.WriteLine(ValidateString(people2));


            Console.ReadKey();
        }

        static string ValidateString(People people)
        {
            Type t = typeof(People);
            PropertyInfo[] properties = t.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach(PropertyInfo property in properties)
            {
                foreach(ValidateStringAttribure attr in property.GetCustomAttributes(false))
                {
                    if(Regex.IsMatch(people.Name, attr.Pattern) && Regex.IsMatch(people.LastName, attr.Pattern))
                    {
                        return "данные корректны!";
                    }
                    else
                    {
                        return "Ошибка, данные не корректны!";
                    }
                }
            }
            return "данные корректны!";
        }
    }
}
