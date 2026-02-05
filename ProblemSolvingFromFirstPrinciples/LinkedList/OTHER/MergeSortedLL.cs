using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using ProductCodingPractice.LinkedList;

namespace ProductCodingPractice.LinkedList.SET1
{
    public class MergeSortedLL
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode tempNode = new ListNode(0); // to create a starting point LL initialize with 0
            ListNode currentNode = tempNode;

            while ((list1 != null) && (list2 != null))
            {
                if (list1.val < list2.val)
                {
                    currentNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    currentNode.next = list2;
                    list2 = list2.next;
                }
                currentNode = currentNode.next;
            }

            if (list1 != null)
            {
                currentNode.next = list1;
                list1 = list1.next;
            }
            if(list2 != null)
            {
                currentNode.next = list2;
                list2 = list2.next;
            }
            return tempNode.next;
        }
        
    }
}