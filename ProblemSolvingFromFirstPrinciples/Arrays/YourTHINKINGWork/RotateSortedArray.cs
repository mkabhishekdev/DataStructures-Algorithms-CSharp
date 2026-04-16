using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace ProductCodingPractice.Arrays.YourTHINKINGWork
{
    /* My Approach
    1. iterate through nums, and find out i where nums[i] > nums[i+1]
    2. That point is where nums was rotated 
    3. (0-i) and (i+1 to n) are two further divided intervals
    4. if target is (< nums[n]) it lies between (i+1 to n)
    5. if target is (> nums[0]) than it migh lie between (0-i)
    */

    /* any optimization later

    */

    /*
    time complexity: O(n)
    space complexity: O(1)
    */
    public class RotateSortedArray
    {
        public int Search(int[] nums, int target)
        {
            if(nums.Length == 1)
            {
                if(target == nums[0])
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] > nums[i+1])
                {
                    Console.WriteLine("The array was rotated at index: "+i);
                    Console.WriteLine("The first index of the array is: "+nums[i+1]);
                    
                    int x = BinarySearch(i+1,nums.Length-1,nums,target);
                    int y = BinarySearch(0,i,nums,target);

                    if((x != -1) && (y == -1))
                    {
                        return x;
                    }
                    else if((x == -1) && (y != -1))
                    {
                        return y;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if(nums[i] == target)
                    {
                        return i;
                    }
                 
                }
            }
            return -1;
        }

        private int BinarySearch(int low,int high, int[] nums,int key)
        {
           
            while(low <= high)
            {
                int mid = (low + high)/2;
                if(key < nums[mid])
                {
                    high = mid - 1;
                }
                else if(key > nums[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}