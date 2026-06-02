using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.AlgorithmCoding
{
    /* My approach
    1. pick the pivot, partition, pivot gets sorted
    2. next keep doing the same idea on partioned sub arrays
    3. start pivot with the first element of the array/sub-array

    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class QuickSort
    {
        public int[] QuickSortImpl(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;

            QuickSorting(nums,low,high);

            return nums;
        }
        
        private void QuickSorting(int[] nums,int low, int high)
        {
            if(low < high)
            {
                int pivotIndex = Partition(nums, low, high);
                QuickSorting(nums, low, pivotIndex - 1);
                QuickSorting(nums, pivotIndex+1, high);
            }
        }
        
        private int Partition(int[] nums,int low, int high)
        {
            int pivot = nums[low];
            int i = low, j = high;
            int temp;
            
            while(i < j)
            {
                do
                {
                    i++;
                } while(nums[i] <= pivot);
                do
                {
                    j--;
                } while(nums[j] > pivot);
                if(i < j)
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }

            temp = nums[low];
            nums[low] = nums[j];
            nums[j] = temp;
            
            return j;
        }

    }
}