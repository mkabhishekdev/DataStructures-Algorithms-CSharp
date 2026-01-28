using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
  APPROACH I CAME UP WITH::
  1. Use a HashSet<int>
  2. Store the values from the array into the HashSet
  3. If size of HashSet equals size of array -> return false
  4. If size of HashSet not equal to the size of the array -> return true

  Time Complexity: O(n)
  Space Complexity: O(n)
*/

namespace ProductCodingPractice.Arrays.YourTHINKINGWork
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateImpl(int[] nums)
        {
            int arrLength = nums.Length;

            HashSet<int> store = new HashSet<int>();
            for (int i = 0; i < arrLength; i++)
            {
                store.Add(nums[i]);
            }

            if (store.Count != arrLength)
            {
                return true;
            }

            return false;
        }

    }
}

/* FAILED APPROACH & WHY

*/