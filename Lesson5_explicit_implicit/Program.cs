using System;

namespace Lesson5_explicit_implicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter { Seconds = 340214 };
 
            Timer timer = counter1;
            Console.WriteLine($"{timer.Hours}:{timer.Minutes}:{timer.Seconds}"); // 0:1:55
        
            Counter counter2 = (Counter)timer;
            Console.WriteLine(counter2.Seconds);  //115
        }
    }
}
