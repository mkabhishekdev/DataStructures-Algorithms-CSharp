using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class LongestRepeatingCharacterSetTwo
    {
        public int RepeatingImpl(string s, int k)
        {
            int[] freq = new int[26];
            int left = 0;
            int maxWindow = 0;
            int maxFrequency = 0;

            for (int right = 0; right < s.Length; right++)
            {
                freq[s[right] - 'A']++;
                maxFrequency = Math.Max(maxFrequency, freq[s[right] - 'A']);
                int windowLength = right - left + 1;

                if (windowLength - maxFrequency > k)
                {
                    freq[s[left] - 'A']--;
                    left++;
                }

                windowLength = right - left + 1;
                maxWindow = Math.Max(maxWindow, windowLength);
            }

            return maxWindow;
        }
    }
}