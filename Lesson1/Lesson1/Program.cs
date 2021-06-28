using System;

namespace Lesson1
{
    interface INameable
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
    /** 
     * <summary>
     *      this class is made to create employee 
     *      that inherit from the abstract class 
     *      <c>Person</c>
     * </summary>
     * **/
    public abstract class Person
    {
        protected string name;
        protected string lastName;
        protected string middleName;

        public abstract void CallName();

        public Person()
        {
            name = string.Empty;
            lastName = string.Empty;
            middleName = string.Empty;
        }
    }

    public class Employee : Person, INameable
    {
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }

        public override void CallName()
        {
            Console.WriteLine($"name: {name}\nsurname: {lastName}\nmiddle: {middleName}\n");
        }

        public Employee() 
        {
            name = "unknown";
            lastName = "unknown";
            middleName = "unknown";
        }

        public Employee(string name, string lastName, string middleName)
        {
            this.name = name;
            this.lastName = lastName;
            this.middleName = middleName;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();


            emp1.CallName();

            emp1.Name = "Sandu";
            emp1.LastName = "Candu";
            emp1.MiddleName = "Stepanov";


            emp1.CallName();

            Console.WriteLine($"{emp1.Name}");
        }
    }
}
