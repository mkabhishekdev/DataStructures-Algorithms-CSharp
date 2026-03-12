
namespace ProblemSolvingFromFirstPrinciples.LinkedList.YourTHINKINGWork
{
      /*
       REFERRED APPROACH/MY APPROACH (THINK/CODE - 45mins):
       1. Handle base case, if any of the list are null return the other and if both are null return a null
       2. Declare a result of the list type. Check which list1 or list2 head has greater value, start with saving the minimal
          among those in the result list
       3. Keep comparing both the lists whichever is having lesser value save that in the result.
       4. Have two index pointer variables(firstListIndex, secondListIndex). This is to keep a track of next set of values to
          compare
       5. Iterate till the end of both the list
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?

        */

        /*
        Time Complexity:
        Space Complexity:
        */

    public class MergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
         
        }
    }
}

     // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY?

       
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