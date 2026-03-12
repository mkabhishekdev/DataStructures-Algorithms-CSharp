using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.LinkedList
{
    public static class LinkedListHelper
    {
        
        public static ListNode BuildList(int[] arr)
        {
            if (arr.Length == 0) return null;

            ListNode head = new ListNode(arr[0]);
            ListNode current = head;

            for (int i = 1; i < arr.Length; i++)
            {
                current.next = new ListNode(arr[i]);
                current = current.next;
            }

            return head;
        }

        public static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }

            Console.WriteLine("null");
        }

    }
}