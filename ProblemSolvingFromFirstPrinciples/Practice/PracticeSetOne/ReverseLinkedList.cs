using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetOne
{
    public class ReverseLinkedList
    {
        public ListNode ReverseLLImpl(ListNode head)
        {
            ListNode prev = null, curr = head, next;

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