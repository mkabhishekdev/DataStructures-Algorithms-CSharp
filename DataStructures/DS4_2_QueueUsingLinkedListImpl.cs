public class DS4_2_QueueUsingLinkedListImpl
{
    public Node front = null;
    public Node rear = null;
    public class Node
    {
        public int data;
        public Node next;
        public Node(int x)
        {
            data = x;
            next = null;
        }
    }

    public void Enqueue(int inputData)
    {
        Node toAddNode = new Node(inputData);

        if (front == null && rear == null)
        {
            front = rear = toAddNode;
            return;
        }
        else
        {
            rear.next = toAddNode;
            rear = toAddNode;
        }
    }

    public void Display()
    {
        Node temp = front;

        Console.WriteLine("The queue is: ");

        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    public void Dequeue()
    {
        if (front != null)
        {
            front = front.next;
            return;
        }
    }

    public int Peek()
    {
        if (front != null)
        {
            return front.data;
        }
        return -1;
    }


}


/*
  DS4_2_QueueUsingLinkedListImpl ds42 = new DS4_2_QueueUsingLinkedListImpl();
        ds42.Enqueue(7);
        ds42.Enqueue(6);
        ds42.Enqueue(1);
        ds42.Display();
        ds42.Dequeue();
        ds42.Display();
        Console.WriteLine("The element in the front of the queue is: " + ds42.Peek());
*/