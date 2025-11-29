using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProductCodingPractice.LinkedList.SET1
{
    public class MergeSortedLL
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();

            ListNode temp1 = list1;
            ListNode temp2 = list2;

            if ((temp1 == null) && (temp2 == null))
            {
                return null;
            }
            if ((temp1 != null) && (temp2 == null))
            {
                result = temp1;
                return result;
            }
            if ((temp1 == null) && (temp2 != null))
            {
                result = temp2;
                return result;
            }

            while (temp1.next != null)
            {
                if (temp1.val <= temp2.val)
                {
                    result = temp1;
                    result.next = temp2;
                }
                if (temp1.val > temp2.val)
                {
                    result = temp2;
                    result.next = temp1;
                }
                temp1 = temp1.next;
                temp2 = temp2.next;
            }

            return result;
        }
        
    }
}