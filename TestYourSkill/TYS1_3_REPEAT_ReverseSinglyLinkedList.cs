public class TYS1_3_REPEAT_ReverseSinglyLinkedList
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



    public void InsertNode(int data)
    {
        Node appendData = new Node(data);
        Node temp = head;

        if (head == null)
        {
            head = appendData;
            return;
        }
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = appendData;
        appendData.next = null;
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

}
