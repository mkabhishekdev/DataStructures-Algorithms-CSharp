using System;
using System.Collections;

public class ProblemTwoImplementStackUsingQueue()
{
    //push(data),pop(),peek(),display()

    Queue<int> primaryQueue = new Queue<int>();
    Queue<int> helperQueue = new Queue<int>();

    public void Push(int inputData)
    {
        if (primaryQueue.Count == 0)
        {
            primaryQueue.Enqueue(inputData);
            return;
        }

        while (primaryQueue.Count != 0)
        {
            helperQueue.Enqueue(primaryQueue.Peek());
            primaryQueue.Dequeue();
        }
        primaryQueue.Enqueue(inputData);
        while (helperQueue.Count != 0)
        {
            primaryQueue.Enqueue(helperQueue.Peek());
            helperQueue.Dequeue();
        }

        Console.WriteLine("Element added to the stack successfully");
    }


    public void Pop()
    {
        primaryQueue.Dequeue();
        Console.WriteLine("Pop operation finished");
    }


    public int Peek()
    {
        int top = primaryQueue.Peek();
        return top;
    }


    public void Display()
    {
        Console.WriteLine("Elements in the stack are: ");
        foreach (var item in primaryQueue)
        {
            Console.WriteLine(item);
        }
    }


}

/*
     ProblemTwoImplementStackUsingQueue suq = new ProblemTwoImplementStackUsingQueue();
        suq.Push(1);
        suq.Push(2);
        suq.Push(3);
        suq.Push(4);
        suq.Display();
        Console.WriteLine("Element in top of the stack is: " + suq.Peek());
        suq.Pop();
        suq.Display();
        Console.WriteLine("Element in top of the stack is: " + suq.Peek());
*/