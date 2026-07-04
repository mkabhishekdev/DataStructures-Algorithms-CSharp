using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class BubbleSortSetTwo
    {
        public int[] BubbleSortImpl(int[] nums)
        {
            if(nums.Length == 0)
            {
                return null;
            }

            for(int i = 0; i < nums.Length - 1; i++)
            {
                int flag = 0;
                for(int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if(nums[j] > nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j+1];
                        nums[j+1] = temp;
                        flag = 1;
                    }
                }
                if(flag == 0)
                {
                    return nums;
                }
            }

            return nums;
        }
    }
}