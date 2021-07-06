using System;

namespace Lesson10_Delegates
{
    class Program
    {
        delegate void Message(); // 1. Объявляем делегат
        delegate int Operation(int x, int t); // 1. Объявляем делегат
        delegate void MessageHandler(string message);
        delegate int Square(int x);
        delegate void Hello(); // делегат без параметров
        delegate bool IsEqual(int x);

        static void Main(string[] args)
        {
            // Delegate
            #region Chapter 1
         
            Message mes; // 2. Создаем переменную делегата
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; // 3. Присваиваем этой переменной адрес метода
            }
            else
            {
                mes = GoodEvening;
            }
            mes(); // 4. Вызываем метод

            //-------------------------------------------------

            // присваивание адреса метода через контруктор
            Operation del = Add; // делегат указывает на метод Add
            int result = del(4,5); // фактически Add(4, 5)
            Console.WriteLine(result);
    
            del = Multiply; // теперь делегат указывает на метод Multiply
            result = del(4, 5); // фактически Multiply(4, 5)
            Console.WriteLine(result);
            #endregion
            Console.WriteLine("============================");
            // Why delegates are needed
            #region Chapter 2
            Chapter4.Account account = new Chapter4.Account(200);
            // Добавляем в делегат ссылку на метод Show_Message
            Chapter4.Account.AccountStateHandler colorDelegate = new Chapter4.Account.AccountStateHandler(Color_Message);
    
            // Добавляем в делегат ссылку на методы
            account.RegisterHandler(new Chapter4.Account.AccountStateHandler(Show_Message));
            account.RegisterHandler(colorDelegate);
            // Два раза подряд пытаемся снять деньги
            account.Withdraw(100);
            account.Withdraw(150);
 
            // Удаляем делегат
            account.UnregisterHandler(colorDelegate);
            account.Withdraw(50);
            #endregion
            Console.WriteLine("============================");
            // Anonymous methods
            #region Chapter 3
            ShowMessage("hello!", delegate(string mes)
            {
                Console.WriteLine(mes);
            });

            Operation operation = delegate (int x, int y)
            {
                return x + y;
            };

            int d = operation(99, 5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(d);       // 104
            Console.ResetColor();


            int z = 8;
            Operation operation1 = delegate (int x, int y)
            {
                return x + y + z;
            };
            //int d = operation1(4, 5);
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine(d);       // 17
            Console.WriteLine(operation1(4, 5));       // 17
            Console.ResetColor();

            #endregion
            Console.WriteLine("============================");
            // Lamda
            #region Chapter 4
            
            Operation operation2 = (x, y) => x + y;
            Console.WriteLine(operation2(10, 20));       // 30
            Console.WriteLine(operation2(40, 20));       // 60

            Square square = i => i * i; // объекту делегата присваивается лямбда-выражение
 
            int z1 = square(6); // используем делегат
            Console.WriteLine("--------------\n" + z1); // выводит число 36

            Hello hello1 = () => Console.WriteLine("Hello");
            Hello hello2 = () => Console.WriteLine("Welcome");
            hello1();       // Hello
            hello2();       // Welcome

            //=====================================================================
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
         
            // найдем сумму чисел больше 5
            int result1 = Sum(x => x > 5, 1,2,4,5,2345,23,45,2346,2,27);
            Console.WriteLine(result1); // 4786
            
            // найдем сумму четных чисел
            int result2 = Sum(x => x % 2 == 0, integers);
            Console.WriteLine(result2);  //20

            #endregion
            Console.WriteLine("============================");
            // Events
            #region Chapter 5
                 
            Chapter5.Account acc = new Chapter5.Account(100);
            acc.Notify += DisplayMessage;                       // Добавляем обработчик для события Notify
            acc.Notify += DisplayRedMessage;    // добавляем обработчик DisplayMessage
            Console.ForegroundColor = ConsoleColor.Yellow;
            acc.Put(20);                                        // добавляем на счет 20
            Console.WriteLine($"Сумма на счете: {acc.Sum}");
            acc.Take(70);                                       // пытаемся снять со счета 70
            acc.Notify -= DisplayRedMessage;    // добавляем обработчик DisplayMessage
            Console.WriteLine($"Сумма на счете: {acc.Sum}");
            acc.Take(180);                                      // пытаемся снять со счета 180
            Console.WriteLine($"Сумма на счете: {acc.Sum}");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            //============================================
            Chapter5.Account acc2 = new Chapter5.Account(100);
            // установка делегата, который указывает на метод DisplayMessage
            acc2.Notify += new Chapter5.Account.AccountHandler(DisplayMessage);
            // установка в качестве обработчика метода DisplayMessage
            acc2.Notify += DisplayMessage;       // добавляем обработчик DisplayMessage
            
            acc2.Put(20);    // добавляем на счет 20

            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
            //================================
            Chapter5.Account acc3 = new Chapter5.Account(123);
            //acc3.Notify += (super_message, e) => Console.WriteLine(super_message);
            acc.Notify += DisplayMessage;
            acc3.Balance();
            acc3.Put(200);
            acc3.Balance();
            acc.Notify -= DisplayMessage;     // удаляем обработчик DisplayRedMessage
            acc3.Take(100);
            acc3.Balance();

            //==========================================================================
            

            
            Console.ResetColor();
            #endregion
            Console.WriteLine("============================");

            #region Chapter 6
                 
            #endregion
            Console.WriteLine("============================");
        }

        #region Chapter 1    
        
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply (int x, int y)
        {
            return x * y;
        }
        #endregion
        //===================================================

        #region Chapter 2
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }

        private static void Color_Message(string message)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }

        #endregion
    
        #region Chapter 3
        static void ShowMessage(string mes, MessageHandler handler)
        {
            handler(mes);
        }
        #endregion
    
        #region Chapter 4

        private static int Sum (IsEqual func, params int[] numbers)
        {
            int result = 0;
            foreach(int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }
        #endregion
    
        #region Chapter 5

        /*private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void DisplayRedMessage(String message)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }*/

        private static void DisplayMessage(object sender, Chapter5.AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }

        private static void DisplayRedMessage(object sender, Chapter5.AccountEventArgs e)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }
        #endregion
    }
}
