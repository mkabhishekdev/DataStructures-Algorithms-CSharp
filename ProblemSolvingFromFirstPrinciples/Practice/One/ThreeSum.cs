using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    /* Referred approach
  
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class ThreeSum
    {
        public List<List<int>> ThreeSumImpl(int[] nums)
        {
            if(nums == null || nums.Length < 3)
            {
                return new List<List<int>>();
            }
            
            Array.Sort(nums); // this is not a sorting question, so you can use in-built functions for simplicity
            HashSet<List<int>> result = new HashSet<List<int>>();

            for(int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while(left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if(sum == 0)
                    {
                        result.Add(new List<int>{nums[i],nums[left],nums[right]});
                        left++;
                        right--;
                    }
                    else if(sum > 0)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return new List<List<int>>(result);

        }
    }
}

/*
intuitive approach
 public List<List<int>> ThreeSumImpl(int[] nums)
        {
            List<List<int>> myRes = new List<List<int>>();
            List<int> innerRes;
            
            for(int i = 0; i < nums.Length - 2; i++)
            {
                for(int j = i + 1; j < nums.Length - 1; j++)
                {
                    for(int k = j + 1; k < nums.Length; k++)
                    {
                    
                        if((nums[i]+nums[j]+nums[k]) == 0)
                        {
                            innerRes = new List<int>()
                            {
                                nums[i],
                                nums[j],
                                nums[k]
                            };
                            

                            myRes.Add(innerRes);
                        }
                   
                    }
                }
            }

            return myRes;
        }
*/