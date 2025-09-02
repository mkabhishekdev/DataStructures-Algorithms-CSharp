using System;

class Program
{
    static void Main(string[] args)
    {
        DS4_4_CircularQueueUsingLinkedList ds44 = new DS4_4_CircularQueueUsingLinkedList();
        ds44.Enqueue(1);
        ds44.Enqueue(2);
        ds44.Enqueue(3);
        ds44.Display();
        ds44.Dequeue();
        ds44.Display();
        Console.WriteLine("The front element in the circular list is: "+ ds44.Peek());
    }
}