public class TYS2_3_ReverseSinglyLinkedList
{

    public Node head;

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



    public void AppendNode(int data)
    {
        Node insertNode = new Node(data);
        Node curr = head;

        if (head == null)
        {
            head = insertNode;
            return;
        }
        while (curr.next != null)
        {
            curr = curr.next;
        }
        curr.next = insertNode;
        insertNode.next = null;
    }

    public void Reverse()
    {
        Node curr = head;
        Node prev = null;
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

    public void PrintMyList()
    {
        Node curr = head;

        Console.WriteLine("The list is: ");

        while (curr != null)
        {
            Console.WriteLine(curr.data);
            curr = curr.next;
        }

    }
}