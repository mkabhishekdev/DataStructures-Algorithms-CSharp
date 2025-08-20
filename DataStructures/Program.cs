using System;

class Program
{
    static void Main(string[] args)
    {
        DS3_2_RepeatStackUsingLinkedListImpl ds32 = new DS3_2_RepeatStackUsingLinkedListImpl();
        ds32.Push(2);
        ds32.Push(5);
        ds32.Push(8);
        ds32.Display();
        ds32.Peek();
        ds32.Pop();
        ds32.Peek();
    }
}