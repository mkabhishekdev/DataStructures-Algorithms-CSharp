using System;

public class DS1_SinglyLinkedListImpl
{
    Node head;

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

    //To add new data in front of the list(push)
    public void Push(int inputData)
    {
        
        Node inputNode = new Node(inputData);
        
        inputNode.next = head;
        head = inputNode;
    }

    //To add data after a given node
    public void insertAfter(Node previousNode, int newData)
    {
        Node newNode = new Node(newData);
        Node temp = head;

        while(temp != null)
        {
            if(temp == previousNode)
            {
                Node store = temp.next;
                temp.next = newNode;
                newNode.next = store;
                break;
            }
            temp = temp.next;
        }
    }

    //At the end of the linked list (append)
    public void Append(int appendData)
    {
        Node appendNode = new Node(appendData);
        Node temp = head;
        
        if(head == null)
        {
            head = new Node(appendData);
            return;
        }

        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = appendNode;
        appendNode.next = null;
    }

    // delete a node from the linked list
    public void Delete(int deleteData)
    {
        Node temp=head,prev=null;
	      
	    while(temp.next!=null && temp.data!=deleteData)
        {
	    	prev=temp;
	    	temp=temp.next;
		}
	    prev.next = temp.next;
    }

    // delete a node from the linked list given its position
    public void DeleteNodeFromPositon(int position)
    {
        Node temp = head;

        for(int i = 0; i < position-1 ; i++)
        {
            temp = temp.next;
        }
        Node jumpPoint = temp.next.next;
        temp.next = jumpPoint;
    }


    //search an element in the linked list, check whether value x is present in the list
    public void SearchElement(int x)
    {
        Node searchNode = new Node(x);
        Node temp = head;

        while(temp != null)
        {
            if(temp.data == searchNode.data)
            {
                Console.WriteLine("Element found in the linked list");
                return;
            }
            temp = temp.next;
        }
        if(temp == null)
        {
            Console.WriteLine("Element not found in the linked list");
            return;
        }
        
    }


    // reverse a linked list (if confusion, look into Jennys lecture)
    public void ReverseLinkedList()
    {
        Node previousNode = null;
        Node currentNode = head;
        Node nextNode = head;

        while(nextNode != null)
        {
            nextNode = nextNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = nextNode;
        }
        head = nextNode;
    }
    
    public void PrintList()
    {
        Node PrintMe = head;
        while(PrintMe != null)
        {
            Console.WriteLine(PrintMe.data + " ");
            PrintMe = PrintMe.next;
        }
    }




}

/*
DS1_SinglyLinkedListImpl singlyLinkedList= new DS1_SinglyLinkedListImpl();
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
*/