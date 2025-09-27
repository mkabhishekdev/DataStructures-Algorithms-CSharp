using System;
using System.Collections;

public class ProblemOneImplementQueueUsingStack
{
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();

    int stack1ElementCount = 0;
    int stack2ElementCount = 0;

    public void Enqueue(int data)
    {
        stack1.Push(data);
        stack1ElementCount++;
        Console.WriteLine("Element inserted into the queue successfully.");
    }

    public void Dequeue()
    {
        foreach (var item in stack1)
        {
            stack2.Push(stack1);
            stack2ElementCount++;
        }
        Console.WriteLine("The element removed from the queue is: " + stack2.Pop());
        while (stack1ElementCount != 0)
        {
            stack1.Pop();
            stack1ElementCount--;
        }
        foreach (var item in stack2)
        {
            stack1.Push();
        }
        while (stack2ElementCount != 0)
        {
            stack2.Pop();
            stack2ElementCount--;
        }
    }

    public void Display()
    {
        foreach (var item in stack1)
        {
            stack2.Push(stack1);
            stack2ElementCount++;
        }
        Console.WriteLine("Elements in the queue are: ");
        foreach (var item in stack2)
        {
            Console.WriteLine(item);
        }
    }

}