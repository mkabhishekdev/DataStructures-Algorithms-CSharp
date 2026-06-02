using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace ProblemSolvingFromFirstPrinciples.StackQueue
{
    public class StackUsingLinkedList
    {
        
        ListNode top = null;

        public void Push(int data)
        {
            ListNode newNode = new ListNode(data);

            if(top == null)
            {
                top = newNode;    
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
        }

    
        public int Pop()
        {
            int temp;
            if(top != null)
            {
                temp = top.val;
                top = top.next;
                return temp;
            }
            return -1;
        }

        public void Peek()
        {
            if(top != null)
            {
                Console.WriteLine("The top element in the stack is: "+top.val);
            }
            else
            {
                Console.WriteLine("Stack Underflow!");
            }
        }

        public bool IsEmpty()
        {
            if(top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayLL()
        {
            ListNode curr = top;

            while(curr != null)
            {
                Console.WriteLine("elements are:"+curr.val);
                curr = curr.next;
            }
        }
    }
}