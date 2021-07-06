using System;

namespace Lesson10_Delegates.Chapter5
{
    class Account
    {
        //public delegate void AccountHandler(string message);
        //public event AccountHandler Notify;              // 1.Определение события
        
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        
        public int Sum { get; private set;}
        private event AccountHandler _notify;
        public event AccountHandler Notify
        {
            add
            {
                _notify += value;
                Console.WriteLine($"{value.Method.Name} добавлен");
            }
            remove
            {
                _notify -= value;
                Console.WriteLine($"{value.Method.Name} удален");
            }
        }
        public Account(int sum)
        {
            Sum = sum;
        }

        public void Balance()
        {
            Console.WriteLine(Sum);
        }
        public void Put(int sum)    
        {
            Sum += sum;
            _notify?.Invoke(this, new AccountEventArgs($"На счет поступило: {sum}", sum));   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                _notify?.Invoke(this, new AccountEventArgs($"Со счета снято: {sum}", sum));   // 2.Вызов события
            }
            else
            {
                _notify?.Invoke(this, new AccountEventArgs($"Недостаточно денег на счете. Текущий баланс: {sum}", sum));
            }
        }
    }
}

