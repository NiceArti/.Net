using System;

namespace Lesson9_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch finally
            #region Chapter 1

            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
        
            //условные конструкции
            Console.WriteLine("Введите число");
            int _x;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out _x))
            {
                _x *= _x;
                Console.WriteLine("Квадрат числа: " + _x);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            #endregion
            Console.WriteLine("===================================\n\n");
            // catch and filter "when"
            #region Chapter 2
            
            try
            {
                int __x = 5;
                int __y = __x / 0;
                Console.WriteLine($"Результат: {__y}");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }

            //when 
            int ___x = 0;
            int ___y = 0;
            
            try
            {
                int result = ___x / ___y;
            }
            catch(DivideByZeroException) when (___y==0 && ___x == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion
            Console.WriteLine("===================================\n\n");
            // Exception class
            #region Chapter 3
            
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");     
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Ресурс: {ex.Source}");
                Console.WriteLine($"Метод: {ex.InnerException}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            #endregion
            Console.WriteLine("===================================\n\n");
            // Create Exception
            #region Chapter 4
            
            try
            {
                Person p = new Person { Name = "Tom", Age = 13 };
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
            #endregion
            Console.WriteLine("===================================\n\n");
            // Поиск блока catch при обработке исключений
            #region Chapter 5
            //read about this article here: https://metanit.com/sharp/tutorial/2.30.php

            #endregion
            // Генерация исключения и оператор throw
            #region Chapter 6
            
            try
            {
                Console.Write("Введите строку: ");
                string message = Console.ReadLine();
                if (message.Length > 6)
                {
                    throw new Exception("Длина строки больше 6 символов");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            try
            {
                try
                {
                    Console.Write("Введите строку: ");
                    string message = Console.ReadLine();
                    if (message.Length > 6)
                    {
                        throw new Exception("Длина строки больше 6 символов");
                    }
                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion

        }
    }
}
