using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class JumpGameSetTwo
    {
        public bool JumpGameImpl(int[] nums)
        {
            if(nums.Length == 0)
            {
                return false;
            }

            int maxReach = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(i > maxReach)
                {
                    return false;
                }

                maxReach = Math.Max(maxReach, i + nums[i]);

                if(maxReach >= nums.Length - 1)
                {
                    return true;
                }
            }

            return true;
        }
    }
}