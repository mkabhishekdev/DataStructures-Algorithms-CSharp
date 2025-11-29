using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace ProductFaangCodingPractice.Arrays.SET1
{
    public class MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            int condition = (nums.Length) / 2;

            Dictionary<int, int> elementWithCount = new Dictionary<int, int>();
            List<int> myResult = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (elementWithCount.ContainsKey(nums[i]))
                {
                    elementWithCount[nums[i]]++;
                }
                else
                {
                    elementWithCount.Add(nums[i], 1);
                }
            }

            foreach (KeyValuePair<int, int> entry in elementWithCount)
            {
                if (entry.Value > condition)
                {
                    myResult.Add(entry.Key);
                }
            }

            if (myResult.Count == 1)
            {
                return myResult[0];
            }

            return myResult.Max(m => m);


        }
    }
}

//SCORE: 7/10