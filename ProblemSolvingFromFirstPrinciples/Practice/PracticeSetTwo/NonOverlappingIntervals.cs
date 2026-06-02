using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class NonOverlappingIntervals
    {
        public int NonOverlappingImpl(int[][] intervals)
        {
            if(intervals.Length == 0)
            {
                return 0;
            }

            Array.Sort(intervals, (a,b) => a[1].CompareTo(b[1]));

            int count = 1;
            int previous_interval = 0;

            for(int i = 1; i < intervals.Length; i++)
            {
                if(intervals[i][0] >= intervals[previous_interval][1])
                {
                    previous_interval = i;
                    count++;
                }
            }

            return intervals.Length - count;

        }
    }
}