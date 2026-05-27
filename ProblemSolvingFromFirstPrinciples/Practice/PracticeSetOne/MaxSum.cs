using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    public class MaxSum
    {
        public int MaxSumImpl(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            int maxSum = nums[0];
            int currSum = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                currSum = Math.Max(nums[i], currSum+nums[i]);
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }
    }
}