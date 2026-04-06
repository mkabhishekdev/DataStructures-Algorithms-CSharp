

    /* My Approach
    1. declare prev, curr, next list nodes
    2. assign prev= null to start with, curr to head
    3. think now, you need to save the curr.next in a variable since when you point it 
       to previous that reference will be lost. Hence, save it in next
    4. than pint current next to prev
    5. Now, you have done the reverse operation. To move forward, your previous will become current
    6. and now you update current with 'next' variable value where you have kept the reference pointer 
       to current next safely
    7. once you reach the end of the while loop, its obvious that if current is null, than your previous will be the head
    8. Therefore return previous
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class ReverseLL
    {
        public ListNode ReverseImpl(ListNode head)
        {
            ListNode? prev = null;
            ListNode? curr =head;
            ListNode? next;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr =next;
            }           
            head =prev;

            return head;
        }

         public ListNode BuildList(int[] arr)
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

        public void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }

            Console.WriteLine("null");
        }
    }
