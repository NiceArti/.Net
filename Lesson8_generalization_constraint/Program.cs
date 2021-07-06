using System;

namespace Lesson8_generalization_constraint
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> acc1 = new Account<int>(1857) { Sum = 4500 };
            Account<int> acc2 = new Account<int>(3453) { Sum = 5000 };

            Transaction<Account<int>> transaction1 = new Transaction<Account<int>>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 6900
            };
            transaction1.Execute();

            Transaction<Account<int>> transaction2 = new Transaction<Account<int>>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 634600
            };

            transaction2.Execute();
        }
    }
}
