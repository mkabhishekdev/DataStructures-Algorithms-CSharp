// VERY IMPORTANT SORTING TECHNIQUE DUE TO ITS BEST CASE TIME COMPLEXITY: O(nlogn) compared with other sorting techniques
//like bubble sort, insertion sort, selection sort 

public class Algo6_QuickSortImpl
{

    public void QuickSort(int[] input, int lowerBound, int upperBound)
    {
        if (lowerBound < upperBound)
        {
            int partitionedLocation = Partition(input, lowerBound, upperBound);
            QuickSort(input, lowerBound, partitionedLocation - 1);
            QuickSort(input, partitionedLocation + 1, upperBound);
        }
        Console.WriteLine("Array after sorting using Quick Sort approach is: ");
        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(input[i]);
        }
    }

    public int Partition(int[] input, int lowerBound, int upperBound)
    {
        int start = lowerBound;
        int end = upperBound;
        int pivot = input[lowerBound];

        while (start < end)
        {
            while (input[start] <= pivot)
            {
                start++;
            }
            while (input[end] > pivot)
            {
                end--;
            }
            if (start < end)
            {
                int temp;
                temp = input[start];
                input[start] = input[end];
                input[end] = temp;
            }
        }

        int store;
        store = pivot;
        pivot = input[end];
        input[end] = store;

        return end;
    }

}