class Program
{
    static void Main(string[] args)
    {
        MergeTwoSortedList mtsl = new MergeTwoSortedList();
        
        int[] input1 = {1,2,4};
        int[] input2 = {1,3,4};

        ListNode inputList1 = LinkedListHelper.BuildList(input1);
        ListNode inputList2 = LinkedListHelper.BuildList(input2);
        
        mtsl.MergeTwoLists(inputList1, inputList2);

    }
}
