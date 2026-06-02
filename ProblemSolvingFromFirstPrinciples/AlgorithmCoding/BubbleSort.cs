using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.AlgorithmCoding
{
    /* My Approach
     1. keep comparing the adjacent elements and move the element to the last by comparison
     2. outer loop keeps track of the passes
     3. inner loop handles the swapping in each pass
     4. for a int[] with n size, you do (n-1) passes 
    */

    /* any optimization later

    */

    /* time complexity: O(n2)
    space complexity: O(1)
    */
    public class BubbleSort
    {
        public int[] BubbleSortImpl(int[] nums)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if(nums[j] > nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j+1];
                        nums[j+1] = temp;
                    }
                }
            }
            return nums;
        }

     
    }
}