using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.LinkedList.YourTHINKINGWork
{
    public class MergeKSortedList
    {
       /*
       MY APPROACH (THINK/CODE):
         1. pick the smallest element from the list of listNodes
         2. make it the head of a listnode called result which will be the result node holding all values
            of the result
         3. remove the list from the list of listNode entries once you had them into the result
         4. next, keep finding the minimum element and also its address
         5. in the result list, keep pointing the next pointer to the address of the minimum element and value to the 
            minimum element found
         6. return the result list
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?

        */

        /*
        Time Complexity: O(N * k) , N: total iterations and each iteration: O(k)
        Space Complexity: O(N)
        */
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode result = new ListNode(0); // create dummy node
            ListNode current = result;

            if(lists == null)
            {
                return result;
            }


            while(lists.Any(list => list != null))
            {
                int min = int.MaxValue;
                int minListIndex = -1;

                for(int i = 0; i < lists.Length; i++)
                {
                    if(lists[i] != null && lists[i].val < min)
                    {
                        min = lists[i].val;
                        minListIndex = i;
                    }
                }

                current.next = new ListNode(min);
                current = current.next; 

                lists[minListIndex] = lists[minListIndex].next;

            }

            return result.next;
        }
    }
}

 // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY?

       
        */ 
        /* CODE:
        

        */