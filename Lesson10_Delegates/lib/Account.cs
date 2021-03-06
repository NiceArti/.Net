namespace Lesson10_Delegates.Chapter4
{
    class Account
    {
        int _sum; // Переменная для хранения суммы
    
        // Объявляем делегат
        public delegate void AccountStateHandler(string message);
        // Создаем переменную делегата
        AccountStateHandler _del;
    
        // Регистрируем делегат
        public void RegisterHandler(AccountStateHandler del)
        {
            _del += del;
        }

        // Отмена регистрации делегата
        public void UnregisterHandler(AccountStateHandler del)
        {
            _del -= del; // удаляем делегат
        }

        //===================================================
        public Account(int sum)
        {
            _sum = sum;
        }
    
        public int CurrentSum
        {
            get { return _sum; }
        }
    
        public void Put(int sum)
        {
            _sum += sum;
        }
    
        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
        
                if (_del != null)
                    _del($"Сумма {sum} снята со счета");
            }
            else
            {
                if (_del != null)
                    _del("Недостаточно денег на счете");
            }
        }
    }
}