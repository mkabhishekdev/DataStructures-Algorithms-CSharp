using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProblemSolvingFromFirstPrinciples.DynamicProgramming.YourTHINKINGWork
{
    /* Referred approach
    1. Use memoization (DP concept)
    2. create a dp[] array
    3. idea is to pick each character from string 's' and increasing it to search
       if any of the word from the dictionary exists
    4. and also, declare a maxLen variable which store the maxLength from the dictionary. This is the 
       maxLength to compare with
    5. so while searching for each word, when you find you assign that index = true.
       So this is memoization i.e next time you don't have to recompute it. You can use this existing value.
    6. keep doing this and return the boolean value of the last index since that value suggest whether 
       we found the segmented word blocks in the given string or not.
    */

    /* any optimization later

    */

    /* time complexity: O(n2)
    space complexity: O(n)
    */
    public class WordBreak
    {
        public bool WordBreakImpl(string s, IList<string> wordDict)
        {
            HashSet<string> wordSet = new HashSet<string>(wordDict);

            int maxLen = 0;
            for(int i = 0; i < wordDict.Count; i++)
            {
                if(maxLen < wordDict[i].Length)
                {
                    maxLen = wordDict[i].Length;
                }
            }
            
            int n = s.Length;

            bool[] dp = new bool[n+1];
            dp[0] = true;

            for(int i = 1; i <= n; i++)
            {
                for(int j = i-1; j >= Math.Max(0, i-maxLen);j--)
                {
                    if(dp[j] && wordSet.Contains(s.Substring(j,i-j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }
            
            return dp[n];
        }
    }
}

/*
Failed approach and why?(need to use DP -> memoization approach for this problem)
    1. start accessing each element form the wordDict and check if it exists in s
    2. if it exists in s -> remove it from s
    3. keep on iterating the list and check each element with the updated s
    4. if exists continue till end of the list, if any element not found -> return false
    5. if you reach the end of the list and have covered all the elements -> return true

  public bool WordBreakImpl(string s, IList<string> wordDict)
        {
            for(int i = 0; i < wordDict.Count; i++)
            {
                if(s.Contains(wordDict[i]))
                {
                    s = s.Replace(wordDict[i],"").Trim();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
*/