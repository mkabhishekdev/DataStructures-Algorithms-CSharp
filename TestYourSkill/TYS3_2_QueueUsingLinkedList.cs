public class TYS3_2_QueueUsingLinkedList
{
    Node front = null;
    Node rear = null;

    public class Node
    {
        public int data;
        public Node next;
        public Node(int x)
        {
            data = x;
            Node = null;
        }
    }

    public void Enqueue(int data)
    {
        Node toInsertNode = new Node(data);

        if (front == null && rear == null)
        {
            front = toInsertNode;
            rear = toInsertNode;
            return;
        }

        rear.next = toInsertNode;
        rear = toInsertNode;
        Console.WriteLine("New element inserted into the queue");
    }

    public void Display()
    {
        Node temp = front;

        Console.WriteLine("Elements in the queue are: ");

        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    public void Dequeue()
    {
        front = front.next;
        Console.WriteLine("Dequeue process done");
    }

    public void Peek()
    {
        Console.WriteLine("On peek, the element is: " + front.data);
    }

}