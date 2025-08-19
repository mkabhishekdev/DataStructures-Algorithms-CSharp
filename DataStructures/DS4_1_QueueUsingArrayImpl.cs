/*
1. Enqueue(int x)
2. Dequeue()
3. Front()/Peek()
4. Display()
*/
public class DS4_1_QueueUsingArrayImpl
{
    int front = -1;
    int rear = -1;
    int[] queue = new int[5];

    public void Enqueue(int x, int size)
    {
        if (rear == size - 1)
        {
            Console.WriteLine("Queue Overflow");
        }
        else if (front == -1 && rear == -1)
        {
            front = 0;
            rear = 0;
            queue[rear] = x;
        }
        else
        {
            rear++;
            queue[rear] = x;
        }
    }

    public void Dequeue()
    {
        if ((front == -1) && (rear == -1))
        {
            Console.WriteLine("Queue Underflow");
        }
        else if (front == rear)
        {
            front = rear = -1;
        }
        else
        {
            Console.WriteLine("The element being removed from the queue is: " + queue[front]);
            front++;
        }
    }

    public int Front()
    {
        if (front == -1)
        {
            Console.WriteLine("Queue Underflow");
        }
        return queue[front];
    }

    public void Display()
    {
        if (rear != -1)
        {
            Console.WriteLine("Queue is: ");
            for (int i = 0; i <= rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
}

/*
        DS4_1_QueueUsingArrayImpl ds41 = new DS4_1_QueueUsingArrayImpl();
        ds41.Enqueue(1, 5);
        ds41.Enqueue(2, 5);
        ds41.Enqueue(3, 5);
        ds41.Enqueue(4, 5);
        ds41.Display();
        ds41.Dequeue();
        ds41.Dequeue();
        ds41.Display();
        int frontElement = ds41.Front();
        Console.WriteLine("The front element in the queue is: "+frontElement);
*/