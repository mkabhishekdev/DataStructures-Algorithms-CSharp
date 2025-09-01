public class DS3_2_RepeatStackUsingLinkedListImpl
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

    public void Push(int data)
    {
        Node newNode = new Node(data);

        if (top == null)
        {
            top = newNode;
        }
        else
        {
            newNode.next = top;
            top = newNode;
        }
    }

    public void Display()
    {
        if (top == null)
        {
            Console.WriteLine("Stack underflow");
        }
        else
        {
            Node temp = top;
            Console.WriteLine("Elements in the stack are: ");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }

    public void Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack underflow");
        }
        else
        {
            Console.WriteLine("The element being popped is: " + top.data);
            top = top.next;
        }
    }

    public void Peek()
    {
        if (top != null)
        {
            Console.WriteLine("The element in the top of stack is: " + top.data);
        }
    }

}

/*
   DS3_2_RepeatStackUsingLinkedListImpl ds32 = new DS3_2_RepeatStackUsingLinkedListImpl();
        ds32.Push(2);
        ds32.Push(5);
        ds32.Push(8);
        ds32.Display();
        ds32.Peek();
        ds32.Pop();
        ds32.Peek();
*/