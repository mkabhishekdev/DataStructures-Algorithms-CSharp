//TIME: 45 minutes , Easy:10pts, Med:20pts, Hard:30pts

public class Set1Problem1ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;
        ListNode next;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        head = prev;

        return head;
    }
}


// SCORE: 10/10