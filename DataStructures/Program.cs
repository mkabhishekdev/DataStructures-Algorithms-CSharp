using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}