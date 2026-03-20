using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.BitManipulation.YourTHINKINGWork
{
    /* Referred Approach
    1. Think in terms of 'right shift >> bit operation' + 'i & 1'
    2. The above operation would give the resultant count of the number of 1s
    */

    /* Any optimization 
    - we need to think in terms of 'right shift >> operation' + 'i & 1'(this gives if the last value is 1 or not)
    */

    /*
    Time complexity: O(n)
    Space complexity: O(n) , Extra/auxiliary space: O(1)
    */
    public class CountBits
    {
        public int[] CountBitsImpl(int n)
        {
            int[] result = new int[n+1];

            for(int i = 1; i <=n; i++)
            {
                result[i] = result[i >> 1] + (i & 1);
            }

            return result;
        }
    }
}

/*
FAILED APPROACH & WHY? (Overcomplicated the problem, approach wrong, need to just focus on bit manipulation logic)
   1. based on the size of n, create a dictionary with key as the element from n and value as the binary representation
    of that element
    2. visit each value and find the count of 1 and save them in an array result
    3. return
CODE:
 Dictionary<int,int> elementCountMapper = new Dictionary<int, int>();

            for(int i = 0; i < n+1; i++)
            {
                for(int j = 31; j >= 0 ; j--)
                {
                    int bit = (elementCountMapper[i] >> j) & 1;
                    elementCountMapper[i] = bit;
                }
            }    
            
            int[] result = new int[n+1];
            int index = 0;
            
            foreach(var ecm in elementCountMapper)
            {
                int count = 0;
                string check = ecm.Value.ToString();
                for(int i = 0; i < check.Length; i++)
                {
                    if(check[i] == '1')
                    {
                        count++;
                    }
                }
                result[index] = count;
                index++;
            }

            return result; 
        }
*/
