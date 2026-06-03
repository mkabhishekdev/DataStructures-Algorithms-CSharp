using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class ReverseLinkedList
    {
        public ListNode ReverseLLImpl(ListNode head)
        {
            ListNode prev = null;
            ListNode curr =head;
            ListNode next;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            head = prev;

            return head;
        }
    }
}