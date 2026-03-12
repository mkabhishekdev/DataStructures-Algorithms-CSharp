using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Interval.YourTHINKINGWork
{
    /*
    REFERRED APPROACH
    1. Add all intervals that come before the newInterval(no overlap)
    2. Merge overlapping intervals with newInterval
    3. Do the expand operation to include the current overlapping interval by defining the min and max start
    4. Add the merged interval, Add all intervals that come after newInterval (no overlap)
    */

    /*
    ANY OPTIMIZATION thoughts?
    */

    /*
    Time complexity: O(n)
    Space complexity: O(n)
    */

    public class InsertInterval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();

            //Case 1: Add all intervals that come before the newInterval(no overlap)
            int i = 0;
            while(i < intervals.Length && intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i++]);
            }

            //Case 2: Merge overlapping intervals with newInterval
            while(i < intervals.Length && intervals[i][0] <= newInterval[1])
            {
                //Do the expand operation to include the current overlapping interval by defining the min and max start
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                i++;
            }
            
            // Add the merged interval
            result.Add(newInterval);

            //Case 3: Add all intervals that come after newInterval (no overlap)
            while(i < intervals.Length)
            {
                result.Add(intervals[i++]);
            }

            return result.ToArray();
        }    
    }
}

 // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY? (no need to create new intervals everytime, you got to think of using the
                                   overlapping intervals by defining max and min for the interval, intervals before that
                                   and intervals after that)
        1. Check if newInterval exists in the intervals
        2. If not 
         -> say from 'i' in the interval[i] to [i+1], create a new interval to store in the result[][]
         -> than from 'i+1' create a new interval until the last item and add it to the result[][]
        3. If yes, new interval exists in the intervals
         -> the interval manipulation logic will be different
       
        */ 
        /* CODE:
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            bool exists = false;
            int[][] result;

            for(int i = 0; i < intervals.Length; i++)
            {
                if((intervals[i][0] == newInterval[0]) && (intervals[i][1] == newInterval[1]))
                {
                    exists = true;
                    break;
                }
            }
        */