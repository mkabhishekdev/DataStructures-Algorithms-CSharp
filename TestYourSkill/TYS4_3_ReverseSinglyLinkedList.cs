using System.Diagnostics.Contracts;

public class TYS4_3_ReverseSinglyLinkedList
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

    public Node head = null;

    public Node Reverse(Node head)
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

        return head;
    }
}


// SCORE = 9/10
// OVERALL TEST SCORE = 8.5/10,4/10,9/10 = 21.5/30 = 71.6%