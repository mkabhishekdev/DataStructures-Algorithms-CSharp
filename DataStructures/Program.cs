using System;

class Program
{
    static void Main(string[] args)
    {
        DS4_2_QueueUsingLinkedListImpl ds42 = new DS4_2_QueueUsingLinkedListImpl();
        ds42.Enqueue(7);
        ds42.Enqueue(6);
        ds42.Enqueue(1);
        ds42.Display();
        ds42.Dequeue();
        ds42.Display();
        Console.WriteLine("The element in the front of the queue is: " + ds42.Peek());
    }
}