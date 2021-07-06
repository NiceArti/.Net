namespace Lesson10_Delegates.Chapter5
{
    class AccountEventArgs
    {
        // Сообщение
        public string Message{get;}
        // Сумма, на которую изменился счет
        public int Sum {get;}
    
        public AccountEventArgs(string mes, int sum)
        {
            Message = mes;
            Sum = sum;
        }
    }
}