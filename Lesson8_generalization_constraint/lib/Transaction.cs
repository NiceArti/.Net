using System;

namespace Lesson8_generalization_constraint
{
    public class Transaction<T> where T : Account<int>
    {
        public T FromAccount { get; set; }  // с какого счета перевод
        public T ToAccount { get; set; }    // на какой счет перевод
        public int Sum { get; set; }        // сумма перевода
    
        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Счет {FromAccount.Id}: {FromAccount.Sum}$ \nСчет {ToAccount.Id}: {ToAccount.Sum}$");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
            }
        }
    }
}