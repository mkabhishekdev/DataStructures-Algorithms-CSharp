using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetOne
{
    /* My approach
- will use sliding window
- based up the satisfaction of i and j condition, keep increasing 
the window size
- until the end of the string  
    */

    /* any optimization later

    */

    /* time complexity: O(n)
    space complexity: O(1)
    */
    public class LongestSubstring
    {
        public int LongestSubstringImpl(string input)
        {
        
            int left = 0;
            int maxLen = 0;

            HashSet<char> myUnique = new HashSet<char>();

            for(int right = 0; right < input.Length; right++)
            {
                while(myUnique.Contains(input[right]))
                {
                    myUnique.Remove(input[left]);
                    left++;
                }

                myUnique.Add(input[right]);
                maxLen = Math.Max(maxLen, right - left + 1);
            }
            
            return maxLen;
        }
    }
}