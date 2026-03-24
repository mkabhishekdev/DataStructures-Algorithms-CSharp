class Program
{
    static void Main(string[] args)
    {
        RemoveNthNodeFromEnd rnn = new RemoveNthNodeFromEnd();

        ListNode inputNode = LinkedListHelper.BuildList(new int[]{1,2,3,4,5});

        LinkedListHelper.PrintList(inputNode);

        rnn.RemoveNthNodeFromEndImpl(inputNode, 2);
    }
}
