using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Strings.YourTHINKINGWork
{
    /* My Approach
      - logic to count from the centre
    */

    /*
    time complexity: O(n2)
    space complexity: O(1)
    */

    public class PalindromicSubstrings
    {
        public int CountSubstrings(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // Odd length palindromes (center at i)
                count += CountPalindromes(s, i, i);

                // Even length palindromes (center between i and i+1)
                count += CountPalindromes(s, i, i + 1);
            }

            return count;
        }

        private int CountPalindromes(string s, int left, int right)
        {
            int count = 0;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }

            return count;
        }
    }
}