using System;

class Program
{
    static void Main(string[] args)
    {
        DS3_1_StackUsingArrayImpl ds3_1 = new DS3_1_StackUsingArrayImpl();

        ds3_1.Push(1);
        ds3_1.Push(2);
        ds3_1.Push(3);
        ds3_1.Push(4);
        ds3_1.Push(5);
        ds3_1.Pop();
        ds3_1.DisplayStack();
        Console.WriteLine("The peek item is: " +ds3_1.Peek());
        
    }
}