using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCodingPractice.LinkedList;

namespace ProductCodingPractice.LinkedList.SET1
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode curr = head;
            List<int> store = new List<int>();
            List<int> reverseStore = new List<int>();

            while (curr != null)
            {
                store.Add(curr.val);
                curr = curr.next;
            }

            for (int i = store.Count - 1; i >= 0; i--)
            {
                reverseStore.Add(store[i]);
            }

            bool result = store.SequenceEqual(reverseStore);

            return result;

        }
    }
}