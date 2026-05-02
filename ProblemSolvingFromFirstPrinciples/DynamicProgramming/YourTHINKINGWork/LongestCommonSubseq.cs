using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    /* Referred  approach
    1. Use Dynamic programming
    2. use jagged 2d array and define with length of both text1 and text2
    3. do memoization // if previously recomputed, use that value in that present step
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class LongestCommonSubseq
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] dp = new int[text1.Length + 1, text2.Length + 1];

            for(int i = 1; i <= text1.Length; i++)
            {
                for(int j = 1; j <= text2.Length; j++)
                {
                    if(text1[i-1] == text2[j-1])
                    {
                        dp[i,j] = 1 + dp[i-1, j-1];
                    }
                    else
                    {
                        dp[i,j] = Math.Max(dp[i-1,j], dp[i,j-1]);
                    }
                }
            }

            return dp[text1.Length,text2.Length];
        }
    }
}

/*
Failed approach and why? (unclear problem understanding -> used greedy approach, need to use Dynamic programming)
  1. check the length of text1 and text2
    2. if text1 > text2 -> assign char of text1 into list say toSearchIn and
       text2 in sequence
    3. if text2 > text1 -> assign char of text2 into list say toSearchIn and text1
       in say sequence
    4. search for each element in list sequence in list toSearchIn using loops and in the same
       order as the elements are in sequence
    5. if you find the sequence, return the length
  List<char> toSearchIn = new List<char>();
            List<char> sequence = new List<char>();

            if(text1.Length >= text2.Length)
            {
                for(int i = 0; i < text1.Length; i++)
                {
                    toSearchIn.Add(text1[i]);
                }
                for(int j = 0; j < text2.Length; j++)
                {
                    sequence.Add(text2[j]);
                }
            }
            else
            {
                for(int i = 0; i < text2.Length; i++)
                {
                    toSearchIn.Add(text2[i]);
                }
                for(int j = 0; j < text1.Length; j++)
                {
                    sequence.Add(text1[j]);
                }
            }
            
            int count = 0, innerIndex = 0;

            for(int i = 0; i < sequence.Count; i++)
            {
                for(int j = innerIndex; j < toSearchIn.Count; j++)
                {
                    if(sequence[i] == toSearchIn[j])
                    {
                        i = i+1;
                        innerIndex = j + 1;
                        count++;
                    }
                }
            }

            return count; 
*/