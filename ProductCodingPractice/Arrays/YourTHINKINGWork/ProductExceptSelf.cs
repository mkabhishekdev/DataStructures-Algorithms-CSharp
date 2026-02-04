using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.Arrays.YourTHINKINGWork
{
    /*
    REFERRED APPROACH:
     // Step 1: Build left products
    // result[i] will contain product of all elements to the LEFT of i
       // Step 2: Multiply by right products
    // right holds product of all elements to the RIGHT of i
    */

    /*
    Time Complexity: O(n)
    Space Complexity: O(1)
    */

    public class ProductExceptSelf
    {
        public int[] ProductExceptSelfImpl(int[] nums)
        {

            if (nums == null || nums.Length == 0)
            {
                return Array.Empty<int>();
            }

            int n = nums.Length;
            int[] result = new int[n];

            result[0] = 1;
            for (int i = 1; i < n; i++)
            {
                result[i] = result[i-1] * nums[i-1];
            }

            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= right;
                right *= nums[i];
            }

            return result;

        }

    }
}

 // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY?(Time Limit exceeded for very huge arrays because of nested for loops O(n2))
    1. Create a res[] array to store the result and create a mulRes variable
    2. Have a outer for loop iterating through the input array
    3. Have a inner loop whivh iterates through the input array and within the inner loop lets have a if condition
       to check
    4. After check, within the if condition update the mulRes value
    5. Once you come out of the inner loop, add the mulRes into the res[]  
    6. output the res[]
     List<long> res = new List<long>();
            long mulRes = 1;     // this line to handle very large values

            if (nums == null || nums.Length == 0)
            {
                return Array.Empty<int>();
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                mulRes = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i)
                    {
                        mulRes = mulRes * nums[j];
                    }
                }
                res.Add(mulRes);
            }

            return res.Select(x => (int)x).ToArray();
        */ 