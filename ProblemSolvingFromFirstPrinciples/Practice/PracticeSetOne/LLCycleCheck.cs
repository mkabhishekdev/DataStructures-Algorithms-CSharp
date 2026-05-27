using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    /* My approach
- use a Dictionary while iterating through the linked list
- keep a curr pointer
- and store each value of the LL as the 'key' 
the pointer address as the'value'
- while iterating curr, we check if we encounter a 
duplicate value. when we encounter a duplicate value
it means we are in a cycle, else no if we are able to reach
the end of the LL without facing a duplicate situation
    */

    /* an optimization later
this can be actually better done with 'HashSet' itself with O(1) lookup
rather than O(n) using Dictionary
    */

    /* time complexity: O(n)
    space complexity: O(n)
    */
    public class LLCycleCheck
    {
        public bool LLCycleCheckImpl(ListNode head)
        {
            ListNode curr = head;
            Dictionary<ListNode, ListNode> traversal = new Dictionary<ListNode, ListNode>();

            while(curr != null)
            {
                if(traversal.ContainsValue(curr.next))
                {
                    return true;
                }
                traversal.Add(curr,curr.next);
                curr = curr.next;
            }

            return false;
        }
    }
}