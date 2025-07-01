public class TYS1_3_REPEAT_ReverseSinglyLinkedList
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

    public void Reverse(Node head)
    {
        Node prev = null;
        Node curr = head;
        Node next;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        head = prev;

    }

}
