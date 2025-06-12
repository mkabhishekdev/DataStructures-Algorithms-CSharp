using System;

class Program
{
    static void Main(string[] args)
    {
        Algo6_QuickSortImpl quickSort = new Algo6_QuickSortImpl();
        int[] test = { 7, 6, 10, 5, 9, 2, 1, 15, 7 };

        quickSort.QuickSort(test, 0, 8);
    }
}