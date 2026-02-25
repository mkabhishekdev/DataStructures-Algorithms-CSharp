using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

  /*
  APPROACH I CAME UP WITH:
   1. Create two variables, leftProduct and rightProduct
   2. LeftProduct iterate from leftside of the array and rightProduct iterate from the right side
   3. If a product is 0, just not to break the flow keep it as '1'
   4. Find the max out of the leftProduct, righProduct and the initial value
   */

   /*
   Any Optimization question while thinking through?
     - So this question of if the array is very large like 'n' number of elements, than the above approach may
       throw time limit exceeded exception? 
       * Yeah above is right analysis, some cases will face with O(n2) time complexity, you need to bring
         down this code to O(n) time complexity
       * This is a variant of Kadanes algorithm (but Kadanes algorithm cannot be applied to get product, only for sum)
   */

   /*
   Time Complexity: O(n)
   Space Complexity: O(1)
   */

namespace ProblemSolvingFromFirstPrinciples.Arrays.YourTHINKINGWork
{
    public class MaxProduct
    {
        public int MaxProductImpl(int[] nums)
        {
            int n = nums.Length;
            int leftProduct = 1;
            int rightProduct = 1;
            int ans = nums[0];

            for(int i = 0; i < n; i++)
            {
                leftProduct = leftProduct == 0 ? 1 : leftProduct;
                rightProduct = rightProduct == 0 ? 1: rightProduct;

                leftProduct *= nums[i];
                rightProduct *= nums[n-1-i];

                ans = Math.Max(ans, Math.Max(leftProduct, rightProduct));
            }

            return ans;

        }
    }
}

 // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY?(some cases will face with O(n2) time complexity, you need to bring
         down this code to O(n) time complexity)
           1. Create a List<int>
   2. First add each element from the int[] into the list
   3. Start looping like use a for loop to iterate through the elements, multiple them, keep saving
      the multiplied value into the list and iterate till end of the int[]
   4. Return the maximum element from the list
       
        */ 
        /* CODE:
        
        public int MaxProductImpl(int[] nums)
        {
            if(nums == null || (nums.Length == 0))
            {
                return 0;
            }
            
            long max = long.MinValue;
            long prod;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    max = Math.Max(max,0);
                    continue;
                }

                prod = 1;

                for(int j = i; j < nums.Length; j++)
                {
                    prod *= nums[j];
                    max = Math.Max(max, prod);

                    if(prod == 0)
                    {
                        break;
                    }                        
                }
            }

            return (int)max;

        }

        */
