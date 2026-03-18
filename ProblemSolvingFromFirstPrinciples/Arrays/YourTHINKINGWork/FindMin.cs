using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Arrays.YourTHINKINGWork
{
      /*
       MY APPROACH (THINK/CODE):
       1. start from the first index
       2. iterate using a for loop
       3. assign min to first element to start with, keep updating the min index by comparison
       4. upon reaching the end of the list, return the min
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?
        - the above needs to be optimized
        This problem is NOT about finding min in an array
It is about exploiting the structure of a rotated sorted array
That structure gives you: Binary Search opportunity → O(log n)
        */

        /*
        Time Complexity:
        Space Complexity:
        */
    public class FindMin
    { 
        public int FindMinImpl(int[] nums) // when applying binary search, make sure the array is sorted firstly 
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;

            while(left < right)
            {
                mid = (left + right)/2;
                
                if(nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return nums[mid];
        }
    }
}

   /* FAILED APPROACH & WHY?
int min = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] < min)
                {
                    min = nums[i];
                }
            }

            return min;
       
        */ 
        /* CODE:
        

        */