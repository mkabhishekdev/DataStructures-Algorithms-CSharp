using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.DynamicProgramming.YourTHINKINGWork
{
    /* Approach
     Need to re-learn
    */

    /* Optimization thoughts

    */

    /*
    Time complexity:
    Space complexity:
    */
    public class LongestIncSubseq
    {
        public int LongestIncSubseqImpl(int[] nums)
        {
            int[] T = new int[nums.Length];

            for(int i = 1; i < nums.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(nums[i] > nums[j])
                    {
                        if(T[j] + 1 > T[i])
                        {
                            T[i] = T[j] + 1;
                        }
                    }
                }
            }

            int maxIndex = 0;
            for(int i = 0; i < T.Length; i++)
            {
                if(T[i] > T[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return T[maxIndex] + 1;
        }
    }
}

 /* FAILED APPROACH & WHY?
  1. start looping through the int[] checking if i > i+1
    2. if (i > i+1) keep moving i until this condition breaks, once a element is found where i < i+1,
    keep a queue and save it in that
    3. keep moving forward with i++, where i < i+1 satisfies put that element into our queue
    4. return the count of the elements from the queue
       
        */ 
        /* CODE:
        Queue<int> store = new Queue<int>();

            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] < nums[i+1])
                {
                    store.Enqueue(nums[i]);
                }
            }

            return store.Count;

        */