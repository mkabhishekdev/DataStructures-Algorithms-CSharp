using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.Arrays.SET1
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int i = m + n - 1;

            while(p2 >= 0)
            {
                if ((p1 >= 0) && (nums1[p1] > nums2[p2]))
                {
                    nums1[i--] = nums1[p1--];
                }
                else
                {
                    nums1[i--] = nums2[p2--];
                }
            }
            
        }
    }
}


/*
   int[] result = {};

            for(int i = 0; i < nums1.Length; i++)
            {
                for(int j = 0; j < nums2.Length; j++)
                {
                    if ((nums1[i] < nums2[j]) && (nums1[i] != 0))
                    {
                        result.Append(nums1[i]);
                        i++;
                    }
                    else if (nums1[i] == nums2[j])
                    {
                        result.Append(nums1[i]);
                        result.Append(nums2[j]);
                        i++;
                        j++;
                    }
                    else
                    {
                        result.Append(nums2[j]);
                        j++;
                    }
                    
                }
            } 
*/