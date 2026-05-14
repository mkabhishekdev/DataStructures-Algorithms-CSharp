using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.DynamicProgramming.YourTHINKINGWork
{
    /* Referred approach
    1. use memoization, think in terms of each house. How to use the values from 
       the previous house robbery?
    2. like if you are in the nth house
           - if you decide to rob nth house -> obviously you cannot rob (n-1) house
             So, [robbery till (n-2) house + rob at nth house]
           - if you decide not to rob nth house
             Tahn, [robbery till (n-1)th house]
    3. compute the Max value: Max([robbery till (n-2) house + rob at nth house],[robbery till (n-1)th house])
    4. return the nums[length-1] -> last value will have the max computed value
    */

    /* any optimization later

    */

    /* time complexity: O(n)
    space complexity: O(n)
    */
    public class HouseRobber
    {
        public int HouseRobberImpl(int[] nums)
        {
            if(nums.Length < 2)
            {
                return nums[0];
            }

            int[] dp = new int[nums.Length];

            //memoize base initial values
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for(int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i-2]+nums[i],dp[i-1]);
            }

            return dp[nums.Length-1];
        }
    }
}

/* Failed approach & why? (almost thought in DP angle, but implementation incorrect)
    1. in the nums[] find the total sum for each element skipping the adjacent element
       each time we may need to keep saving the previous sum,Keep saving the previous sum and do the 
add operation (memoization)  
    2. store that value in a max variable
    3. each time compare the sum and if the sum is greater than the max -> update max to that sum
    4. return the max
      public int HouseRobberImpl(int[] nums)
        {
            if(nums.Length == 0)
            {
                return -1;
            }

            int max = -1;
            int sum = -1;

            for(int i = 0; i < nums.Length - 2; i++)
            {
                sum = nums[i];
                for(int j = i+2; j < nums.Length; j = j+2)
                {
                    sum += nums[j];

                    if(sum > max)
                    {
                        max = sum;
                    }
                }
            }           

            return max;
        }
*/