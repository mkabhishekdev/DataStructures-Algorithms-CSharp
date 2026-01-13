using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductFaangCodingPractice.StackQueue.SET1
{
    public class NextGreaterElement
    {
        public int[] NextGreaterElementImpl(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        if (nums2[j + 1] > nums2[j])
                        {
                            result.Add(nums2[j + 1]);
                        }
                        else
                        {
                            result.Add(-1);
                        }
                    }
                }
            }

            return result.ToArray();


        }

    }
}

// SCORE: 4/10