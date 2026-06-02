using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class LongestCommonSubsequence
    {
        public int LongestSubsequenceImpl(string text1, string text2)
        {
            int[][] dp = new int[text1.Length+1][];

            for(int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[text2.Length+1];
            }

            dp[0][0] = 0;
            
            for(int i = 1; i <= text1.Length; i++)
            {
                for(int j = 1; j <= text2.Length; j++)
                {
                    if(text1[i-1] == text2[j-1])
                    {
                        dp[i][j] = 1 + dp[i-1][j-1];
                    }
                    else
                    {
                        dp[i][j] = Math.Max(dp[i-1][j],dp[i][j-1]);
                    }
                }
            }
            
            return dp[text1.Length][text2.Length];
        }
    }
}