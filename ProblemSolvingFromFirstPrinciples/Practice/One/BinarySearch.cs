using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    public class BinarySearch
    {
        public int BinarySearchImpl(int[] nums, int target)
        {
            if(nums == null || nums.Length == 0)
            {
                return -1; 
            }

            int low = 0;
            int high = nums.Length - 1;

            while(low <= high)
            {
                int mid = (low+high)/2;
                
                if(target == nums[mid])
                {
                    return mid;
                }
                else if(target < nums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}