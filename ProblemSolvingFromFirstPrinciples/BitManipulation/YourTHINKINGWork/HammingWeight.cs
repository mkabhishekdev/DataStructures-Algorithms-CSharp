using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
        /*
      APPROACH I CAME UP WITH:
       1. Convert the given number into binary format
       2. Once you get the binary format number
       3. Count the number of '1' in that binary format and return that count
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?
  

        */

        /*
        Time Complexity:
        Space Complexity:
        */

namespace ProblemSolvingFromFirstPrinciples.BitManipulation.YourTHINKINGWork
{
    public class HammingWeight
    {
        public int HammingWeightImpl(int n)
        {
            string binaryRepresentation = Convert.ToString(n,2);

            int count = 0;

            for(int i = 0; i < binaryRepresentation.Length; i++)
            {
                if(binaryRepresentation[i] == '1')
                {
                    count++;
                }
            }

            return count;
        }
    }
}

  // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY?

       
        */ 
        /* CODE:
        

        */