using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.LinkedList.YourTHINKINGWork
{
    /* My approach
    1. iterate to the end of the node, get the length of the list
    2. subtract the nodelength with n, this will give the index where the node to be deleted is there
    3.reach the node, previous to the node to be deleted and update the next pointer to next.next, this will
      jump the next pointer skipping the node to delete
      Idea is you don't essentially delete the node rather you update the link to the next node in your existing list
    */

    /* any optimization later

    */

    /*
    time complexity: O(n)
    space complexity: O(1) : You are only creating references (pointers), so it will be O(n) and not O(1)
    */
    public class RemoveNthNodeFromEnd
    {
        public ListNode RemoveNthNodeFromEndImpl(ListNode head, int n)
        {

            
            ListNode curr = head;
            int nodeLength = 1;

            while(curr.next != null)
            {
                curr = curr.next;
                nodeLength++;
            }

            int nodeIndex = nodeLength - n;

            ListNode temp = head;

            if(nodeIndex == 0)
            {
                head = head.next;
                return head;
            }
            while(nodeIndex > 1)
            {
                temp = temp.next;
                nodeIndex--;
            }

            temp.next = temp.next.next;

            return head;
        }
    }
}