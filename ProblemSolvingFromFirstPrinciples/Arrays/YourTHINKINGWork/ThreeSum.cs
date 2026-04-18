using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace ProductCodingPractice.Arrays.YourTHINKINGWork
{
    public class ThreeSum
    {
        /* Referred Approach
        1. This problem is a extension of 'two pointer' pattern
        2. first, sort the nums[] in ascending order
        3. than pick the element as i
        4. now in the remaining nums[] subarray you need to find two elements(j,k)
           which when added with i give 0. i.e: i+j+k = 0
        5. keep finding it in the way
        6. Once you found the triplets, use a HashSet kind of a data structure to remove the duplicates
        */

        /* any optimization later

        */

        /* time complexity:
        space complexity:
        */
        public IList<IList<int>> ThreeSumImpl(int[] nums)
        {
            if((nums == null) || (nums.Length < 3))
            {
                return new List<IList<int>>();
            }

            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();

            for(int i = 0; i < nums.Length - 2; i++)
            {
                // 🔑 Skip duplicate 'i'
                if (i > 0 && nums[i] == nums[i - 1])
                continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while(left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if(sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    
                          int currentLeft = nums[left];
                    int currentRight = nums[right];

                    // 🔑 Move past duplicates safely
                    while (left < right && nums[left] == currentLeft)
                        left++;

                    while (left < right && nums[right] == currentRight)
                        right--;
                    }
                    else if(sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result.Select(triplet => (IList<int>)triplet).ToList();
        }
    }
}