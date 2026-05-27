using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    /* My approach
    1. use a for loop and iterate through each element to find the target
    2. If find the target, return i
    3. else return -1
    */

    /* any optimization later

    */

    /* time complexity: O(n)
    space complexity: O(1)
    */
    public class LinearSearch
    {
        public int LinearSearchImpl(int[] nums, int target)
        {
            if(nums.Length == 0)
            {
                return -1;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }    
    }
}