using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Interval.YourTHINKINGWork
{
    /* My approach
    1. have a maxReach variable starting with 0
    2. keep updating maxReach value to max you obtain in the for loop iteration,
       cimparing i+nums[i] and maxReach
    3. if maxReach greater than nums.Length - 1 -> return true
    4. if i > maxReach -> means you cannot reach i -> return false
    */
    /* any optimization later

    */
    /* time complexity: O(n)
    space complexity: O(1 )
    
    */
    public class JumpGame
    {
        public bool JumpGameImpl(int[] nums)
        {
            int maxReach = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(i > maxReach)
                {
                    return false;
                }

                maxReach = Math.Max(maxReach, i + nums[i]);

                if(maxReach >=(nums.Length - 1))
                {
                    return true;
                }
            }

            return true;
        }
    }
}

/* Failed approach and why?
    public bool JumpGameImpl(int[] nums)[162/180 test cases passed but the below approach is not covering all situations]
        {
            if(nums.Length == 0)
            {
                return false;
            }
            if(nums.Length == 1)
            {
                return true;
            }
            int incrementer = 0;

            for(int i = 0; i < nums.Length - 1; i = incrementer)
            {
                if(nums[i] == 0)
                {
                    return false;
                }

                incrementer = incrementer + nums[i];
            }

            return true;
        }
*/