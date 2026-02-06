using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Arrays.YourTHINKINGWork
{
   /*
   REFERRED APPROACH
   1. This is the approach called 'Kadanes Algorithm'
   2. You start with the firstelement assigning it the currentSum and maxSum
   3. Idea is to start from the index=1 and keep updating currentSum and maxSum
   4. currentSum will be the max value between the present nums[index] or the currentSum+nums[index].
      You need to store the max at each point
   5. maxSum stores the max value between either currentSum or maxSum, maxSum keeps getting updated
      on every iteration in the loop
   6. return the maxSum
   */
    
    /*
    Time Complexity:O(n)
    Space Complexity: O(1)
    */

    public class MaximumSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }
            if(nums.Length == 1)
            {
                return 1;
            }
           
            int currentSum = nums[0];
            int maxSum = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum+nums[i]);
                maxSum = Math.Max(currentSum, maxSum);
            }
            
            return maxSum;
        }

    }
}

    // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
    /* FAILED APPROACH & WHY?(Dictionary not needed, complicated the logic)
    APPROACH I CAME UP WITH:
   1. Store the total array sum in a variable say 'total'
   2. Create a max variable and assign that value of total, now you have total array sum in max
   3. Using loop, iterate through the array adding adjacent elements and comparing if the added value
      is greater than max
   4. If it is greater than max,have a list to save those elements and also have a list to save that sum value as
      well. Here I want to do something where, I can have something like a key,value where the sum maps to
      all the adjacent elements involved.(thinking how to do this?)
   5. Than, I can pick the mapping of the max elements and return that has the max sub array
       // CODE
          public int MaxSubArray(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }
            if(nums.Length == 1)
            {
                return 1;
            }
            int total=0, max = 0;
            Dictionary<(int,int),int> maxStorage = new Dictionary<(int, int), int>();

            for(int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }

            max = total;

            for(int i = 0; i < nums.Length; i++)
            {
                if((nums[i]+nums[i+1]) > max)
                {
                    max = nums[i] + nums[i+1];
                    maxStorage.Add((nums[i],nums[i+1]),max); //something on this lines    
                }
            }
            
            return max;
        }
    */