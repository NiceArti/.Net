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

            emp.Display();
            adm.Display();
            per1.Display();
            per2.Display();

            Console.WriteLine("Hello World!");
        }
    }
}
