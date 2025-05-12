using System;

public class Algo2_BinarySearchIterativeMethod
{
    public void BinarySearch(int[] input, int itemToFind)
    {
        int left = 0, right = input.Length-1;
        int mid;
        int flag = 0;
        
        //Array needs to be sorted in Binary Search firstly
        Array.Sort(input);

        while(left <= right)
        {
            mid = (left+right)/2;
            
            if(itemToFind < input[mid])
            {
                right = mid - 1;
            }
            else if(itemToFind > input[mid])
            {
                left = mid + 1;
            }
            else if(itemToFind == input[mid])
            {
                flag = 1;
                Console.WriteLine("Element found at position: "+mid);
                break;
            }
        }
        if(flag == 0)
        {
            Console.WriteLine("Element not found in the input array");
        }
    }
}