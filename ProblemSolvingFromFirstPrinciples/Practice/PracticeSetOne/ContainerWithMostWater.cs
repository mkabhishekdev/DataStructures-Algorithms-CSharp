using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetOne
{
    /* My approach
    If(a[i] < a[j])
  i++;
if(a[i] > a[j])
  j--;
have a maxArea variable and keep checking if presentArea > MaxArea -> update it
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class ContainerWithMostWater
    {
        public int ContainerImpl(int[] height)
        {
            if(height.Length == 0)
            {
                return 0;
            }
            if(height.Length == 1)
            {
                return height[0];
            }
            int i = 0, j = height.Length - 1;
            int maxArea = 0, calcArea = 0;
            
            while(i < j)
            {
                if(height[i] == height[j])
                {
                    calcArea = height[i] * (j-i);
                    maxArea = Math.Max(maxArea,calcArea);       
                    i++;
                    j--; 
                }
                else if(height[i] < height[j])
                {
                    calcArea = height[i] * (j-i);
                    maxArea = Math.Max(maxArea, calcArea);
                    i++;
                }
                else
                {
                    calcArea = height[j] * (j-i);
                    maxArea = Math.Max(maxArea, calcArea);
                    j--;
                }
            }

            return maxArea;

        }
    }
}