using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    /* Referred approach
    1. you need to access each index, apply recursion on that
    2. go on subtracting -> checking true/false condition of whether you are reaching the value 0
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class CombinationSum
    {
        public IList<IList<int>> CombinationSumImpl(int[] candidates, int target)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            FindCombinations(0, candidates, target, ans, new List<int>());
            return ans;
        }

        private void FindCombinations(int index, int[] arr, int target, IList<IList<int>> ans, List<int> ds)
        {
            if(index == arr.Length)
            {
                if(target == 0)
                {
                    ans.Add(new List<int>(ds));
                }    
                return;
            }

            if(arr[index] <= target)
            {
                ds.Add(arr[index]);
                FindCombinations(index, arr, target - arr[index], ans, ds);
                ds.RemoveAt(ds.Count - 1);
            }
            FindCombinations(index + 1, arr, target, ans, ds);
        }
    }
}

/* Failed Approach and why?(should use backtacking - DP approach)
    1. find the mod % value of each element with the target
    2. which is 0 -> get the division value, the number of times you have is the count
    3. need to figure how to add different combinations
     int innerCheck;
            List<int> result = new List<int>();

            for(int i = 0; i < candidates.Count; i++)
            {
                innerCheck = candidates[i]%target;

                if(innerCheck == 0)
                {
                    int divVal = candidates[i]/target;
                    
                    for(int j = 0; j < divVal; j++)
                    {
                        result.Add(candidates[i]);
                    }
                }    
            }
*/