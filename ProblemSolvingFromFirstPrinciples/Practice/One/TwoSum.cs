using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    /* My approach
    1. iterate through nums and find if target sum is obtained
    2. think about impoving this
    */

    /* any optimization later
    use Dictionary, time can be reduced to O(n)
    */

    /* time complexity: O(n2)
    space complexity: O(1) // you are using constant space when returning the result (i.e 2 indices), result size not growing with n
    */
    public class TwoSum
    {
        public List<int> TwoSumImpl(int[] nums, int target)
        {
            Dictionary<int,int> store = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int subtractedValue = target - nums[i];

                if(store.ContainsKey(subtractedValue))
                {
                    return new List<int>{store[subtractedValue],i};
                }

                store[nums[i]] = i;
                
            }

            return new List<int>();
        }
    }
}

/*
intuitive approach

 public List<int> TwoSumImpl(int[] nums, int target)
        {
            List<int> result = new List<int>();

            for(int i = 0 ; i < nums.Length - 1; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if((nums[i]+nums[j]) == target)
                    {
                        result.Add(i);
                        result.Add(j);
                        return result;
                    }
                }
            }

            return new List<int>();
        }

*/