using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetOne
{
    public class ThreeSum
    {
        public IList<IList<int>> ThreeSumImpl(int[] nums)
        {
            if (nums == null || nums.Length < 3)
            {
                return new List<IList<int>>();
            }

            IList<IList<int>> res = new List<IList<int>>();
       
    

            Array.Sort(nums);

            for(int i = 0; i < nums.Length - 2; i++)
            {
                if(i > 0 && (nums[i] == nums[i-1]))
                {
                    continue;
                }

                int start = i + 1;
                int end = nums.Length - 1;

                while(start < end)
                {
                    if((nums[i]+nums[start]+nums[end]) == 0)
                    {
                                
                        res.Add(new List<int>
                        {
                            nums[i],
                            nums[start],
                            nums[end]  
                        });
                        start++;
                        end--;

                        while((start < end) && (nums[start] == nums[start-1]))
                        {
                            start++;
                        }
                        while((start < end) && (nums[end] == nums[end+1]))
                        {
                            end--;
                        }
                    }
                    else if((nums[i]+nums[start]+nums[end]) > 0)
                    {
                        end--;
                    }
                    else
                    {
                        start++;
                    }
                }
            
            }

            return res;
        }
    }
}