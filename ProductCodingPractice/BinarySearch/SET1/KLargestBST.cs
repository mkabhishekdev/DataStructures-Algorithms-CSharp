using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.BinarySearch.SET1
{
    public class KLargestBST
    {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        int check;

        public void KthLargest(int k, int[] nums) 
        {

            check = k;

            for(int i = 0; i < nums.Length; i++)
            {
                Add(nums[i]);
            }
        }
    
        public int Add(int val) 
        {
            minHeap.Enqueue(val, val);

            if (minHeap.Count > check)
            {
                minHeap.Dequeue();
            }
            
            return minHeap.Peek();
        }

    }
}




