using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class RemoveNNodeSetTwo
    {
        public ListNode RemoveNodeImpl(ListNode head, int n)
        {
            if(head == null)
            {
                return null;
            }

            int checkLen = 0;
            ListNode curr = head;

            while(curr != null)
            {
                checkLen++;
                curr = curr.next;
            }
            
            if(n == checkLen)
            {
                return head.next;
            }

            int findIndex = checkLen - n;

            ListNode temp = head;

            while(findIndex > 1)
            {
                temp = temp.next;
                findIndex--;
            }

            temp.next = temp.next.next;

            return head;
        }
    }
}