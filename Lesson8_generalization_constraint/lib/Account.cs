namespace Lesson8_generalization_constraint
{
    public class Account<T>
    {
        public T Id { get; private set;} // номер счета
        public T Sum { get; set; }
        public Account(T _id)
        {
            Id = _id;
        }
    }
}