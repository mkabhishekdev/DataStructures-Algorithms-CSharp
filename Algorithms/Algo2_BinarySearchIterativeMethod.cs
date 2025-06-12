using System;

public class Algo2_BinarySearchIterativeMethod
{
    public void BinarySearch(int[] input, int itemToFind)
    {
        int left = 0, right = input.Length - 1;
        int mid;
        int flag = 0;

        //Array needs to be sorted in Binary Search firstly
        Array.Sort(input);

        while (left <= right)
        {
            mid = (left + right) / 2;

            if (itemToFind < input[mid])
            {
                right = mid - 1;
            }
            else if (itemToFind > input[mid])
            {
                left = mid + 1;
            }
            else if (itemToFind == input[mid])
            {
                flag = 1;
                Console.WriteLine("Element found at position: " + mid);
                break;
            }
        }
        if (flag == 0)
        {
            Console.WriteLine("Element not found in the input array");
        }
    }
}

// Time Complexity: Worst Case:  ,Best Case: 

/*
   Algo2_BinarySearchIterativeMethod bsi = new Algo2_BinarySearchIterativeMethod();
        int[] values = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
        bsi.BinarySearch(values,3);
*/