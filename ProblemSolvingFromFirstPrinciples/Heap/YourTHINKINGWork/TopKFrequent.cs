using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Heap.YourTHINKINGWork
{
    public class TopKFrequent
    {
        /*
       MY APPROACH (THINK/CODE):
       1. keep a Dictionary<element, with its count>, add the elements from the int[] along with the count
       2. sort the Dictionary in decreasing order
       3. add a while condition,based on the k value. 
       4. In the while condition, keep picking elements from the dictionary until k > 0
       5. save those elements into a int[] -> return the result
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?
        - Developed solution takes O(nlogn) due to sorting
          Two optimization way of solving this problem are present:
          1. Min Heap(Priority Queue) [O(nlogk)]
          public int[] TopKFrequent_Heap(int[] nums, int k)
{
    Dictionary<int, int> map = new Dictionary<int, int>();

    foreach (int num in nums)
    {
        if (map.ContainsKey(num)) map[num]++;
        else map[num] = 1;
    }

    var pq = new PriorityQueue<int, int>(); // element, priority

    foreach (var pair in map)
    {
        pq.Enqueue(pair.Key, pair.Value);

        if (pq.Count > k)
        {
            pq.Dequeue(); // remove smallest frequency
        }
    }

    int[] result = new int[k];
    for (int i = 0; i < k; i++)
    {
        result[i] = pq.Dequeue();
    }

    return result;
}
Time: O(n log k)
Space: O(n)
          2. Bucket Sort [O(n)]
        */

        /*
        Time Complexity: O(nlogn)
        Space Complexity: O(n)
        */
        public int[] TopKFrequentImpl(int[] nums, int k)
        {
            Dictionary<int, int> elementCountMapper = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if(elementCountMapper.ContainsKey(nums[i]))
                {
                    elementCountMapper[nums[i]]++;
                }
                else
                {
                    elementCountMapper[nums[i]] = 1;
                }
            }
            
            List<KeyValuePair<int,int>> sortedMapper = elementCountMapper
                                                           .OrderByDescending(ecm => ecm.Value)
                                                           .ToList();
            
            int indexAccessor = 0;
            int[] result = new int[k];

            while(k > 0)
            {
                result[indexAccessor] =  sortedMapper[indexAccessor].Key;
                indexAccessor++;
                k--;      
            }

            return result;

        }
    }
}
        
        // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY?

       
        */ 
        /* CODE:
        

        */