using System;

public class DS2_DoublyLinkedListImpl
{
    Node head, tail;  // in DLL - you need a tail node as well
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

    //To add new data in front of the list(push)
    public void Push(int newData)
    {
        Node newNode = new Node(newData);
        Node temp = head;

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            return;
        }
        head.prev = newNode;
        newNode.next = head;
        head = newNode;

        while (temp.next != null)
        {
            temp = temp.next;
        }
        tail = temp;
    }


    // Method to Insert at the end of a Doubly Linked List
    public void Append(int newData)
    {
        Node nodeToAppend = new Node(newData);

        if (head == null)
        {
            head = nodeToAppend;
            tail = nodeToAppend;
            return;
        }
        else
        {
            tail.next = nodeToAppend;
            nodeToAppend.prev = tail;
            tail = nodeToAppend;
        }

        Console.WriteLine("Appended new node to the doubly linked list");

    }



    // Method to Insert at a given position in the Doubly Linked List
    public void InsertAfterNode(int position, int newData)
    {
        Node toInsert = new Node(newData);
        Node temp = head;

        for (int i = 1; i < position; i++)
        {
            temp = temp.next;
        }

        toInsert.prev = temp;
        toInsert.next = temp.next;
        temp.next = toInsert;
        temp.next.prev = toInsert;

        Console.WriteLine("Doubly linked list updated with new node at the said position");
    }


    // Method to Delete from beginning in a Doubly Linked List
    public void DeleteNodeAtBeginning()
    {

        if (head == null)
        {
            Console.WriteLine("No list to delete");
        }
        else
        {
            head = head.next;
            head.prev = null;
        }
    }

    // Method to Delete from end in a Doubly Linked List
    public void DeleteNodeAtEnd()
    {
        tail = tail.prev;
        tail.next = null;
    }

    // Method to Delete from a position in a Doubly Linked List 
    public void DeleteNodeFromPosition(int position)
    {
        Node temp = head;

        for (int i = 1; i < position; i++)
        {
            temp = temp.next;
        }
        temp.prev.next = temp.next;
        temp.next.prev = temp.prev;

    }

    // Method to Reverse from a Doubly Linked List
    public void ReverseDLL()
    {
        Node current = head, nextNode;

        while (current != null)
        {
            nextNode = current.next;
            current.next = current.prev;
            current.prev = nextNode;
            current = nextNode;
        }

        current = head;
        head = tail;
        tail = current;

    }

    public void PrintDLL()
    {
        Node temp = head;

        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
        Console.WriteLine("head of the dll is: " + head.data);
        Console.WriteLine("tail of the dll is: " + tail.data);

    }
}


/*
  DS2_DoublyLinkedListImpl dll = new DS2_DoublyLinkedListImpl();
        dll.Push(1);
        dll.Push(2);
        dll.Push(3);
        dll.PrintDLL();
        dll.Append(5);
        dll.Append(7);
        dll.PrintDLL();
        dll.PrintDLL();
        dll.ReverseDLL();
        dll.PrintDLL();
*/