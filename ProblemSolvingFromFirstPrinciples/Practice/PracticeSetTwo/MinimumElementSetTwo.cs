using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class MinimumElementSetTwo
    {
        public int MinElementImpl(int[] nums)
        {
            if(nums == null)
            {
                return -1;
            }

            int min = nums[0];
            
            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] < min)
                {
                    min = nums[i];
                }
            }
            
            return min;
        }
    }
} 