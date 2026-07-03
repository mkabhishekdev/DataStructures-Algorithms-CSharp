using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class BinarySeachSetTwo
    {
        public int BinarySearchImpl(int[] nums, int target)
        {
            if(nums.Length == 0)
            {
                return -1;
            }

            int low = 0, mid = -1;
            int high = nums.Length - 1;

            Array.Sort(nums);

            while(low <= high)
            {
                mid = (low+high)/2;

                if(target < nums[mid])
                {
                    high = mid - 1;
                }
                if(target > nums[mid])
                {
                    low = mid + 1;
                }
                if(target == nums[mid])
                {   
                    Console.WriteLine("The target was found at position: "+mid);
                    return mid;
                }
            }

            Console.WriteLine("The target element was not found");

            return -1;

        }
    }
}