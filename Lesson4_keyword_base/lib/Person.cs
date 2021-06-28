using System;

namespace Lesson4_keyword_base.lib
{
    public class Person
    {
        private protected string _name;
        private protected string _company;
    
        public string Name
        {
            get 
            { 
                if (_name == string.Empty)
                    _name = "noname";
                return _name;
            }
            set { _name = value; }
        }
        public void Display()
        {
            Console.WriteLine($"This is Person - {_name}");
        }

        public Person (string name)
        {
            _name = name;
        }

        public Person (string name, string company)
        {
            _name = name;
            _company = company;

        }
    }
}