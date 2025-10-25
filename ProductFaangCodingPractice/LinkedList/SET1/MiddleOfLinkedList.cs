using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductFaangCodingPractice.LinkedList;

namespace ProductFaangCodingPractice.LinkedList.SET1
{
    public class MiddleOfLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode curr = head;
            int count = 0;

            while (curr != null)
            {
                curr = curr.next;
                count++;
            }

            int mid = count / 2;

            ListNode temp = head;

            while (temp != null && mid > 0)
            {
                temp = temp.next;
                mid--;
            }

            return temp;
        }

    }
}


// SCORE: 9/10