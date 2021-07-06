using System;

class PersonException : ArgumentException
{
    public int Value { get;}
    public PersonException(string message, int val)
        : base(message)
    {
        Value = val;
    }
}