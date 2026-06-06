using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class ClimbinStairsSetTwo
    {
        public int CSImpl(int n)
        {
            int[] myLocal = new int[n+1];
            return ClimbingImpl(n,myLocal);
        }
       
        public int ClimbingImpl(int n, int[] storeMemory)
        {
            if(n == 0)
            {
                return 1;
            }
            if(n == 1)
            {
                return 1;
            }
          
            // below is doing memoization, saving previous results to reuse. Instead of making same recursive calls over and over
            if(storeMemory[n] != 0)
            {
                return storeMemory[n];
            }

            storeMemory[n] = ClimbingImpl(n-1,storeMemory) + ClimbingImpl(n-2,storeMemory);

            return storeMemory[n];
        }
    }
}