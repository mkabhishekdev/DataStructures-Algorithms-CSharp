using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.BitManipulation.YourTHINKINGWork
{
    /* Referred Approach
    1. The problem can be solved in two ways:
       - mathematical way: use the sum formula = n*(n+1)/2. This will give you the total sum based on n,
         than since you know the total sum -> keep subtracting from nums[], the final remaining
         value is the missing number.
    2. The Bit manipulation approach, is using the properties of logical 'XOR' operation
    3. Remember these basic XOR properties
        - XOR is commutative in natore i.e A XOR B = B XOR A
        - A XOR A = 0
        - A XOR 0 = A
    4. Based on the above properties, get the solution
    */

    /* any optimization later

    */

    /* time complexity: O(n)
    space complexity: O(1)
    */
    public class MissingNumber
    {
        public int MissingNumberImpl(int[] nums)
        {
            int XORSum = 0;

            for(int i = 0; i <= nums.Length; i++)
            {
                XORSum = XORSum ^ i;
            }

            foreach(int num in nums)
            {
                XORSum = XORSum ^ num;
            }

            return XORSum;
        }
    }
}

/* Failed approach and why?
    1. get the count of the int[]
    2. try to find out if all the values from [0,n] exists in nums[]
    3. if any value missing, return that number
    4. else return -1
 int range = nums.Length;

            for(int i = 0; i <= range; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(i == nums[j])
                    {
                        break;
                    }    
                }
              
            }

            return -1;
*/