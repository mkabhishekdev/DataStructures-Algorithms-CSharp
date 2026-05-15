using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ProductCodingPractice.DynamicProgramming.YourTHINKINGWork
{
    /* Referred approach
need to use DP - memoization concept
waysTodecode[i] = waysToDecode[i-1] (if new single digit is valid) + waysToDecode[i-2](if last 2 digits are valid)
    */

    /* any optimization later

    */

    /* time complexity:
   space complexity: 
   */
    public class DecodeWays
    {
        public int DecodeWaysImpl(string s)
        {
            int n = s.Length;
            int[] dp = new int[n+1];
            dp[0] = 1;
            dp[1] = s[0] == '0' ? 0 : 1;

            for(int i = 2; i <= n; i++)
            {
                int oneDigit = int.Parse(s.Substring(i-1,1));
                int twoDigits = int.Parse(s.Substring(i-2,2));

                if(oneDigit >= 1)
                {
                    dp[i] += dp[i-1];
                }
                if(twoDigits >=10 && twoDigits <= 26)
                {
                    dp[i] += dp[i-2];
                }
            }
            
            return dp[n];
        }
    }
}

/* Failed approach and why?(got the DP-memoization idea but implementation wrong)
 1. start with accessing each char in the string s 
    2. to start with if string length is greater than 2
       get the char values of s[0], s[1]
    3. go on iterating the string s, utilize the already computed previous values
       like s[i-1]
       - try to see if a alphabet could be formed using i with i-1 or not
    4. 
*/