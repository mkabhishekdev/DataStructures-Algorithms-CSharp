using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.LinkedList.YourTHINKINGWork
{
    /*
    APPROACH I CAME UP WITH::
    1. If head is null -> return false
    2. Initialize a HashSet<ListNode> and keep saving the next addresses from the linked list
    3. If a duplicate value encountered -> return true, there is a cycle
    4. If not, traverse till the end of the linked list -> return false
    Time Complexity: O(n)
    Space Complexity: O(n)
    */

    public class DetectCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            HashSet<ListNode> checker = new HashSet<ListNode>();
            checker.Add(head);

            ListNode temp = head;

            while (temp.next != null)
            {
                if (!checker.Add(temp.next))
                {
                    return true;
                }
                temp = temp.next;
            }

            return false;
        }
    }
    
}

  // If all test cases not clearing, PRACTICE DEBUGGING
  /* FAILED APPROACH & WHY

  */ 