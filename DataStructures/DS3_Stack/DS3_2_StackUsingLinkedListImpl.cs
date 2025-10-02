public class DS3_2_StackUsingLinkedListImpl
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

    Node top = null;

    public void Push(int x)
    {
        Node newNode = new Node(x);
        newNode.next = top;
        top = newNode;
    }

    public void Display()
    {
        Node temp = top;
        Console.WriteLine("The Stack is: ");
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    public void Peek()
    {
        Console.WriteLine("The Peek data in the stack is: " + top.data);
    }

    public void Pop()
    {
        Console.WriteLine("The Popped element is: " + top.data);
        top = top.next;
    }

}

/*
  DS3_2_StackUsingLinkedListImpl ds32 = new DS3_2_StackUsingLinkedListImpl();
        ds32.Push(2);
        ds32.Push(5);
        ds32.Push(8);
        ds32.Display();
        ds32.Peek();
        ds32.Pop();
        ds32.Peek();
*/