
//Find Out: what problem you face if you use 'count' instead of 'top' while displaying?

public class DS4_5_QueueUsingStackImpl
{

    int[] stack1 = new int[5];
    int[] stack2 = new int[5];
    int top1 = -1, top2 = -1;
    int count = 0;
    /*
    Enqueue(5);
    Enqueue(2);
    Enqueue(1);
    Dequeue();
    Display();
    */
    public void Enqueue(int data)
    {
        Push1(data);
        count++;
    }

    public void Dequeue()
    {
        if (top1 == -1 && top2 == -1)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        for (int i = 0; i < count; i++)
        {
            int x = Pop1();
            Push2(x);
        }
        Console.WriteLine("Popped element is: " + Pop2());
        count--;
        for (int i = 0; i < count; i++)
        {
            int y = Pop2();
            Push1(y);
        }

    }

    public void Display()
    {
        Console.WriteLine("Elements in the queue are: ");
        Console.WriteLine("Printing to check the value of count variable: " + count);
        for (int i = 0; i <= top1; i++)
        {
            Console.WriteLine(stack1[i]);
        }
    }

    public void Push1(int stackoneData)
    {
        if (top1 == (stack1.Length - 1))
        {
            Console.WriteLine("Stack is already full");
            return;
        }
        top1++;
        stack1[top1] = stackoneData;
        
    }

    public int Pop1()
    {
        return stack1[top1--];
    }

    public void Push2(int stacktwoData)
    {
        if (top2 == (stack2.Length - 1))
        {
            Console.WriteLine("Stack is already full");
            return;
        }
        count++;
        top2++;
        stack2[top2] = stacktwoData;
    }

    public int Pop2()
    {
        return stack2[top2--];
    }

}  