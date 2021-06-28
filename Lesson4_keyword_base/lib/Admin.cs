using System;

namespace Lesson4_keyword_base.lib
{
    /// sealed class - класс который нельзя унаследовать
    sealed class Admin : Person
    {
        public Admin (string name) : base(name)
        {
        }
        public new void Display()
        {
            Console.WriteLine($"This is Admin - {_name}");
        }
    }
}