using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class QuickSortSetTwo
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

        private int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[low];
            int i = low, j = high;
            
            while(i < j)
            {
                do
                {
                    i++;
                }while(nums[i] <= pivot);
                do
                {
                    j--;
                }while(nums[j] > pivot);
                if(i < j)
                {
                    Swap(nums[i],nums[j]);
                }
            }
            Swap(nums[low],nums[j]);
            return j;
        }

        private void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}