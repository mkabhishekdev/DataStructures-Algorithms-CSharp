using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetOne
{
    public class TwoSum
    {
        public int[] TwoSumImpl(int[] nums, int target)
        {
            int[] res = new int[2];

            Dictionary<int,int> myRecord = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if(myRecord.ContainsKey(target - nums[i]))
                {
                    res[0] = myRecord[target - nums[i]];
                    res[1] = i;
                }
                myRecord[nums[i]] = i;
            }

            return res;
        }
    }
}