using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Interval.YourTHINKINGWork
{
  /* My approach
1. start and end for each interval is unique
  i.e start of each interval should be 
different 
2. also end of each interval should be
  unique
3. use a Dictionary to save start of each interval as
key and end as value
4. each time check if unique key, if not dont add
it to the dictionary, save the count of the 
duplicate in a counter variable
5. return the counter variable 
  */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class NonOverlappingIntervals
    {
        public int NonOverlappingImpl(int[][] intervals)
        {
            int counter = 0;
            Dictionary<int,int> intervalMapper = new Dictionary<int, int>();

            foreach(int[] interval in intervals)
            {
                if(intervalMapper.ContainsKey(interval[0]))
                {
                    counter++; 
                }
                intervalMapper[interval[0]] = interval[1];
            }

            return counter;
        }
    }
}