using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.LinkedList.YourTHINKINGWork
{
    public class ReorderList
    {
        /* Referred approach
        1. divide the list into two halves
        2. reverse the second half
        3. merge both the halves, the first half and the reversed half
        4. that is the result
        */

        /* any optimization later

        */

        /*
        time complexity:
        space complexity:
        */

        public void ReorderListImpl(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return;
            }
            
            // head of first half
            ListNode l1 = head;
            
            // head of second half
            ListNode slow = head;

            // tail of second half
            ListNode fast = head;

            // tail of first half
            ListNode prev = null;

            // This standard logic will always get us into the middle
            while(fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;     
            }
            
            prev.next = null;
    
            ListNode l2 = ReverseLL(slow);
            
            Merge(l1, l2);
        }

        public ListNode ReverseLL(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;;
            ListNode next;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr =next;
            }

            return prev;
        }

        public void Merge(ListNode l1, ListNode l2)
        {
            while(l1 != null)
            {
                ListNode l1_next = l1.next;
                ListNode l2_next = l2.next;

                l1.next = l2;

                if(l1_next == null)
                {
                    break;
                }

                l2.next = l1_next;
                l1 = l1_next;
                l2 = l2_next;
            }
        }
    }
}

/*
Failed approach and why?
1. count the size of the linked list
2. create a dummy LL with L0 being the head
3. point the next to the nth item from the original LL
4. need to rethink, how to each time call L1,2,3 etc. than Ln-1,n-2,n-3 etc repeatedly
  public void ReorderListImpl(ListNode head)
        {
            ListNode temp = head;
            int sizeCounter = 1;

            while(temp.next != null)
            {
                temp = temp.next;
                sizeCounter++;
            }           

            ListNode dummy = new ListNode(head.val);


        }
*/