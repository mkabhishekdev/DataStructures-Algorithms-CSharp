using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class ProductSubArray
    {
        public int ProductSubImpl(int[] nums)
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