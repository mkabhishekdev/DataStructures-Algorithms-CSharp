using System;

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedListImpl singlyLinkedList= new SinglyLinkedListImpl();
        singlyLinkedList.Push(4);
        singlyLinkedList.Push(3);
        singlyLinkedList.Push(2);
        singlyLinkedList.Push(1);
        Console.WriteLine("Linked List is: ");
        singlyLinkedList.PrintList();
     //   singlyLinkedList.DeleteNodeFromPositon(3);
     //   Console.WriteLine("Linked list after deletion: ");
        singlyLinkedList.SearchElement(1);
       // singlyLinkedList.SearchElement(2);
    }
}