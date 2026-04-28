using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Arrays.YourTHINKINGWork
{
    /* My Approach
    1. start with left = 0 and right = height - 1
    2. idea is to keep shrinking the left, right and finding the areas and 
       picking the max area out of them
    3. Area = Min(left,right) - (right - left)
    4. if(height[left] < height[right]) -> left++
    5. else do right --
    6. do the above under the condition (left < right)
    */

    /* any optimization later
    - use two pointer technique
    */

    /* time complexity: O(n)
    space complexity: O(1)
    */
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while(left < right)
            {
                int width = right - left;

                int area = Math.Min(height[left],height[right]) - width;
                maxArea = Math.Max(area,maxArea);

                if(height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;

        }
    }
}

/* Failed approach and why?(should have thought on the lines of 'two pointer' approach)
 public int MaxArea(int[] height)
        {
            if(height.Length == 1)
            {
                return height[0];
            }

            int maxValue = 0;
            int secondMaxValue = 0;

            for(int i = 0; i < height.Length; i++)
            {
                if(height[i] > maxValue)
                {
                    maxValue = height[i];
                }
            }
            
            for(int i = 0; i < height.Length; i++)
            {
                if(height[i] == maxValue)
                {
                    height[i] = 1;
                }
            }
            
            for(int i = 0; i < height.Length; i++)
            {
                if(height[i] > secondMaxValue)
                {
                    secondMaxValue = height[i];
                }    
            }

            int ContainerWithMostWater = secondMaxValue * secondMaxValue;

            return ContainerWithMostWater;

        }

*/