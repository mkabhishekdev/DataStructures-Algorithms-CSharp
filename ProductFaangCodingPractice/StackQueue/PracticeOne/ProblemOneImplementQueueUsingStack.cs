using System;
using System.Collections;

public class ProblemOneImplementQueueUsingStack
{
    Stack<int> primaryStack = new Stack<int>();
    Stack<int> helperStack = new Stack<int>();

    int top = -1;

    public void Enqueue(int inputData)
    {
        if (primaryStack.Count == 0)
        {
            primaryStack.Push(inputData);
            return;
        }

        while (primaryStack.Count != 0)
        {
            helperStack.Push(primaryStack.Peek());
            primaryStack.Pop();
        }

        primaryStack.Push(inputData);

        while (helperStack.Count != 0)
        {
            primaryStack.Push(helperStack.Peek());
            helperStack.Pop();
        }
        Console.WriteLine("Element inserted into the queue");
    }

    public int Dequeue()
    {
        int toRemove = primaryStack.Peek();
        primaryStack.Pop();
        Console.WriteLine("Element from the Queue removed successfully");
        return toRemove;
    }

    public int Front()
    {
        if (primaryStack.Count == 0)
        {
            return -1;
        }
        return primaryStack.Peek();
    }

    public void Display()
    {
        Console.WriteLine("Elements in my queue are: ");
        foreach (var item in primaryStack)
        {
            Console.WriteLine(item);
        }
    }

}

/*
 ProblemOneImplementQueueUsingStack qus = new ProblemOneImplementQueueUsingStack();
        qus.Enqueue(1);
        qus.Enqueue(2);
        qus.Enqueue(3);
        qus.Enqueue(4);
        qus.Display();
        Console.WriteLine("Elemet in front of the queue is: "+qus.Front());
        qus.Dequeue();
        Console.WriteLine("Elemet in front of the queue is: "+qus.Front());
        qus.Display();
*/