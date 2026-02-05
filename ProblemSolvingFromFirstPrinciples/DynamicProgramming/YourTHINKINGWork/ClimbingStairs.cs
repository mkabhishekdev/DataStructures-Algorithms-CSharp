using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.DynamicProgramming.YourTHINKINGWork
{
    /*
    APPROACH I CAME UP WITH:
    1. Start with returning answer for base conditions like 0,1
    2. Idea of using 'Recursion' should flash, like something on the lines of fibonacci series problem - adding 
       the previous recursed result
    For fully correct logic, you still had to do below:
        - Notice in your logic, some values which are already computed get keep computed again and again.
          For large inputs, this will result in time limit exceeded error.
        - So you need to find a way to 'store' the already visited value similar to a local cache memory.
        - This is actually the 'memoization' dynamic programming concept. 
    */

    /*
    Time Complexity: O(n) Why? -> each n is compted once,all future calls return cached value
    Space Complexity: O(n) Why? -> storeMemory[] array: O(n), call stack: O(n)
    */

    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            int[] myLocal = new int[n + 1];
            return ClimbingStairsImpl(n, myLocal);
        }
        
        public int ClimbingStairsImpl(int n, int[] storeMemory)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }

            if (storeMemory[n] != 0)
            {
                return storeMemory[n];
            }

            storeMemory[n] = ClimbingStairsImpl(n - 1, storeMemory) + ClimbingStairsImpl(n - 2, storeMemory);

            return storeMemory[n];
        }
    }
}

   // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
   /* FAILED APPROACH & WHY?

       
   */ 