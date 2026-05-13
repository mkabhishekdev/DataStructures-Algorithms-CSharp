using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    /* time complexity: O(n)
    space complexity: O(1)
    */
    public class ReverseLinkedList
    {
        public ListNode ReverseLinkedListImpl(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            ListNode next;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr =next;
            }
            head = prev;

            return head;
        }
    }
}