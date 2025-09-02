public class DS4_4_CircularQueueUsingLinkedList
{
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

    public Node front = null;
    public Node rear = null;

    public void Enqueue(int data)
    {
        Node toInsert = new Node(data);

        if ((front == null) && (rear == null))
        {
            front = rear = toInsert;
            rear.next = front;
        }
        else
        {
            rear.next = toInsert;
            rear = toInsert;
            rear.next = front;
        }

    }

    public void Dequeue()
    {
        if (front == null && rear == null)
        {
            Console.WriteLine("Queue underflow");
        }
        else if (front == rear)
        {
            front = null;
            rear = null;
        }
        else
        {
            front = front.next;
            rear.next = front;
        }
    }

    public int Peek()
    {
        if (front == null && rear == null)
        {
            return -1;
        }
        return front.data;
    }

    public void Display()
    {
        if (front == null && rear == null)
        {
            Console.WriteLine("Circular Queue underflow");

        }
        else
        {
            Node temp = front;
            Console.WriteLine("Elements in the circular list are: ");
            while (temp.next != rear.next)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }
    }

}