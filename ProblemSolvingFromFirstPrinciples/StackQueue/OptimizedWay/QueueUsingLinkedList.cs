using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.StackQueue
{
    public class QueueUsingLinkedList
    {
        ListNode front;
        ListNode rear;

        public void Enqueue(int data)
        {
            ListNode newNode = new ListNode(data);

            if(front == null)
            {
                front = newNode;
                rear = newNode;
            }    
            else
            {
                rear.next = newNode;
                rear = rear.next;
            }
        }

        public void Dequeue()
        {
            int temp;

            if(front != null)
            {
                temp = front.val;
                front = front.next;
                Console.WriteLine("Element Dequeued is: "+temp);    
            }
        }

        public int Peek()
        {
            if(front != null)
            {
                return front.val;
            }
            return -1;
        }

        public bool IsEmpty()
        {
            if(front == null)
            {
                return true;
            }
            return false;
        }
    }
}