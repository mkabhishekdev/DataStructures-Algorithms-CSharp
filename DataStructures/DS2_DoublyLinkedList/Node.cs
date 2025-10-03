namespace DataStructures.DoublyLinkedList
{
    public class Node
    {
        public int data { get; set; }
        public Node next;
        public Node prev;
        public Node(int x)
        {
            data = x;
            next = null;
            prev = null;
        }
    }
}
