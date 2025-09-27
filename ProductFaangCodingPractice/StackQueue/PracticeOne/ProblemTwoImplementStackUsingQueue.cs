using System;
using System.Collections;

public class ProblemTwoImplementStackUsingQueue()
{

    Queue<int> queue = new Queue<int>();
    List<int> store = new List<int>();

    int queueSize = 0;

    public void Push(int data)
    {
        queue.Enqueue(data);
        queueSize++;
        Console.WriteLine("Element inserted into the stack");
    }

    public void Pop()
    {
        foreach (var item in queue)
        {
            store.Add(item);
        }
        
    }

    public void Peek()
    {
        foreach (var item in queue)
        {
            store.Add(item);
        }
        Console.WriteLine("Element in the top of the stack is: " + store.ElementAt(queueSize));
    }

    public void Display()
    {
        Console.WriteLine("Elements in the stack are: ");
        
        for (int i = store.Count; i > 0; i--)
        {
            Console.WriteLine(store.ElementAt(i));
        }
    }

}