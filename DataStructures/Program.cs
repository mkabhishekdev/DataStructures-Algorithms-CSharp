using System;

class Program
{
    static void Main(string[] args)
    {
        DS4_5_QueueUsingStackImpl ds45 = new DS4_5_QueueUsingStackImpl();
        ds45.Enqueue(4);
        ds45.Enqueue(11);
        ds45.Enqueue(7);
        ds45.Enqueue(2);
        ds45.Enqueue(6);
        ds45.Dequeue();
        ds45.Display();
    }
}