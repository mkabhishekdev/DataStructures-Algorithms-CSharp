
namespace ProblemSolvingFromFirstPrinciples.LinkedList.YourTHINKINGWork
{
      /*
       REFERRED APPROACH:
       1. Create a Dummy linkedlist
       2. Than assign a Tail linkedList with Dummy. In memory the dummy and tail would be linked, tail
          keeps on moving forward and also in the memory the dummy will also be building since it is assigned
          with tail
        3. Based on the condition, keep moving the tail pointer
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?
        Need to use dummy/tail index movement idea for these kind of linked list problems
        */

        /*
        Time Complexity: O(n + m) n and m are size of the lists
        Space Complexity: O(n)
        */

    public class MergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(0);
            ListNode tail = dummy;

            while((list1 != null) && (list2 != null))
            {
                if(list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                tail = tail.next; // when the call goes for the next while condition, the tail has to be sitting at present
            }

            if(list1 == null)
            {
                tail.next = list2;
            }
            if(list2 == null)
            {
                tail.next = list1;
            }

            return dummy.next;

        }
    }
}

     // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY? (Thinking aproach was right, about moving the index pointers
         But the core idea is to use the dummy/tail pointer technique)
  MY APPROACH (THINK/CODE - 45mins):
       1. Keep a result list
       2. If l1 == l2, store both l1 and l2 in result move l1 = l1.next and l2 = l2.next
       3. If l1 < l2 -> store l1 in result and move only l1 = l1.next
       4. if l1 > l2 -> store l2 in result and move only l2 = l2.next
       
        */ 
        /* CODE:
           if(list1 == null && list2 == null)
            {
                return null;
            }
            if(list1 == null)
            {
                return list2;
            }
            if(list2 == null)
            {
                return list1;
            }

            ListNode result = new ListNode(0);
            
            if(list1.val == list2.val)
            {
                result = list1;
                result.next = list2;
                list1 = list1.next;
                list2 = list2.next;
            }
            if(list1.val < list2.val)
            {
                result = list1;
                list1 = list1.next;
            }
            else
            {
                result.val = list2.val;
                list2 = list2.next;
            }
            
            ListNode resultCurr = result;

            while(list1 != null && list2 != null)
            {
                if(list1.val < list2.val)
                {
                    resultCurr.next = list1;
                    list1 = list1.next;
                }
                else if(list1.val == list2.val)
                {
                    resultCurr.next = list1;
                    resultCurr.next.next = list2;
                    list1 = list1.next;
                    list2 = list2.next;
                }
                else
                {
                    resultCurr.next = list2;
                    list2 = list2.next;
                }
            }
            
            return resultCurr;

        */