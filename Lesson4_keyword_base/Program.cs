using System;
using Lesson4_keyword_base.lib;

namespace Lesson4_keyword_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("John", "Apple");
            Person per1 = new Employee("Does", "Google");
            Person per2 = new Person("Brown");
            Admin adm = new Admin("Julina");

            Employee employee = new Employee("Tom", "Microsoft");
            Person person = employee;   // преобразование от Employee к Person
            
            //Employee employee2 = person;    // так нельзя, нужно явное преобразование
            Employee employee2 = (Employee)person; 

            emp.Display();
            adm.Display();
            per1.Display();
            per2.Display();

            Console.WriteLine("Hello World!");
        }
    }
}
