using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Interval
{
       /*
       Referred APPROACH (THINK/CODE):
       1. sort the array first
       2. save the first element index in start and end
       3. iterate through for loop from the '1st' element, save the start and end in 
          cariables say currStart, currEnd
       4. you need to keep updating currStart and currWindow intervals thats the main catch
       5. if currStart <= end // there is overlap, update the end by finding the max
       6. if not, no overlap: add the elements to the list
       7. return the result
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?
        - think in terms of updating 'intervals' between start/end index 
        */

        /*
        Time Complexity: O(nlogn) // because of sorting
        Space Complexity: O(n)
        */
        /*
        int[][] intervals =
        {
            new int[] {1, 3},  // {(0,0),(0,1)}
            new int[] {2, 6},  // {(1,0),(1,1)}
            new int[] {8, 10}, // {(2,0),(2,1)}
            new int[] {15, 18} // {(3,0),(3,1)}
        };
        */
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if(intervals.Length == 0)
            {
                return new int[0][];    
            }
            
            // 1.sort it first
            Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

            List<int[]> myResult = new List<int[]>();

            // 2. start with first interval
            int start = intervals[0][0];
            int end = intervals[0][1];

            for(int i = 1; i < intervals.Length; i++)
            {
                int currStart = intervals[i][0];
                int currEnd = intervals[i][1];

                // 3. overlap
                if(currStart <= end)
                {
                    end = Math.Max(end, currEnd);
                }    
                else
                {
                    // no overlap, save previous
                    myResult.Add(new int[]{start, end}); //adding the entry
                    
                    start = currStart;
                    end = currEnd;
                }
            }
            
            // 5. add last interval
            myResult.Add(new int[]{start, end});

            return myResult.ToArray();
        }
    }
}

   // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY? (idea right, implementation flawed)
       1. iterate through the intervals
       2. for every i and i+1, check if there is overlap of values
       3. if there is an overlap of values, convert them into a single interval
       4. for the next iteration, use this interval as the ith interval for comparing with the next i+1 interval
       4. if there is no overlap, keep them as separate intervals
       
        */ 
        /* CODE:
         public int[][] Merge(int[][] intervals)
        {
            List<int[]> myResult = new List<int[]>();

            for(int i = 0; i < intervals.Length; i++)
            {
                int iUpdatedStart = 0, jUpdatedEnd = 0;

                if(iUpdatedStart > 0 && jUpdatedEnd > 0)
                {
                    int start = iUpdatedStart;
                    int end = jUpdatedEnd;
                }
                else
                {
                    int start = intervals[i][0];
                    int end = intervals[i][1]; 
                }
                
                if(intervals[i+1][0] == start || intervals[i+1][0] == end || (intervals[i+1][0] < end))
                {
                    myResult.Add(new int[]{start,intervals[i+1][1]});
                    iUpdatedStart = start;
                    jUpdatedEnd = intervals[i+1][1];
                }
            }

            return myResult.ToArray();
        }

        */