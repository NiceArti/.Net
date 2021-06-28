using System;

namespace Lesson4_keyword_base.lib
{
    public class Employee : Person
    {
        public string Company { get; set; }
 
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
        public new void Display()
        {
            Console.WriteLine($"This is Employee - {_name} - company - {Company}");
        }
    }
}