using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class CountingBitsSetTwo
    {
        public int[] Counting(int n)
        {
            int[] result = new int[n+1];

            for(int i = 1; i <= n; i++)
            {
                result[i] = result[i>>1] + (i&1);
            }

            return result;
        }
    }
}