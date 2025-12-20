using System;
using System.Collections;

public class Algo7_MergeSortImpl_AbdulSir
{

    public int[] MergeSort(int[] input)
    {
        MergeSortingImpl(input, 0, input.Length - 1);
        return input;
    }

    public void MergeSortingImpl(int[] input, int low, int high)
    {
        if (low < high)
        {
            int mid = (low + high) / 2;
            MergeSortingImpl(input, low, mid);
            MergeSortingImpl(input, mid + 1, high);
            Merge(input,low, mid, high);  // lets say low=0,mid=4,high=8

        }
    }
    
    public void Merge(int[] input, int low , int mid, int high)
    {
        int m = mid - low + 1;  // 5
        int n = high - mid;   // 4

        int[] left = new int[m];
        int[] right = new int[n];

        for (int i = 0; i < m; i++)
        {
            left[i] = input[low + i]; //[0+0],[0+1],[0+2],[0+3],[0+4]
        }
        for(int j = 0; j < n; j++)
        {
            right[j] = input[mid + 1 + j]; // [5+0],[5+1],[5+2],[5+3]
        }

        int iIndex = 0, jIndex = 0, k = low;

        while (iIndex < m && jIndex < n)
        {
            if (left[iIndex] <= right[jIndex])
            {
                input[k++] = left[iIndex++];
            }
            else
            {
                input[k++] = right[jIndex++];
            }
        }

        for (; iIndex < m; iIndex++)
        {
            input[k++] = left[iIndex];
        }
        for(; jIndex < n; jIndex++)
        {
            input[k++] = right[jIndex];
        }
    }

}