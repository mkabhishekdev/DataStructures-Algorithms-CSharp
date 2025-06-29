public class TYS1_3_ReverseSinglyLinkedList
{

    public class Node
    {
        public int data;
        public  Node next;

        public Node(int x)
        {
            data = x;
            next = null;
        }
    }

    public Node head;

    public void InsertNode(int data)
    {
        Node newNode = new Node(data);
        Node temp = head;

        while (temp != null)
        {
            temp = temp.next;
        }
        temp = newNode;
    }

    public void PrintLL()
    {
        Node temp = head;

        Console.WriteLine("Linked List is: ");
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    public void Reverse()
    {

    }

}
