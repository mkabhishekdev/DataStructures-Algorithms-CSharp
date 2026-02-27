using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.DynamicProgramming.YourTHINKINGWork
{
      /*
      REFERRED APPROACH:
      https://www.youtube.com/watch?v=NNcN5X1wsaw
       - Don't see the video code but understand the DP technique through the cideo, 
       see your code below to understand
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?
        - We have to use DP (Memoization)
        */

        /*
        Time Complexity: O(amount × number_of_coins)
        Space Complexity: O(amount)
        */

    public class CoinChange
    {
        public int CoinChangeImpl(int[] coins, int amount)
        {
            if(amount == 0)
            {
                return 0;
            }

            int[] dp = new int[amount+1];

            // to start with fill each index with a 'max' value, next you will be comparing in a Min method
            for(int i = 1; i <= amount; i++)
            {
                dp[i] = amount + 1;
            }

            dp[0] = 0;

            // you start entering the values from the ground up
            for(int i = 1; i <= amount; i++)
            {
                foreach(int coin in coins)
                {
                    if(coin <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
           
        }
    }
}

  // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY? (You tried 'greedy' method, it won't work for all test cases. Need to use DP)
         APPROACH I CAME UP WITH:
      1. Place the coin array in decreasing order
      2. Keep subtracting the amount given starting from the first index in the decreasing order
         array, keep subtracting from that element until you are unable to subtract
      3. Than move to the next element
      4. Try to subtract until you can satisfy: index element - saved subtracted value >= 0
      5. Keep a count variable, to track count of elements which underwent the subtraction operation
      6. Return that count
       
        */ 
        /* CODE:
        
 if(amount == 0)
            {
                return 0;
            }
            
            if(coins.Length == 1)
            {
                if(amount < coins[0])
                {
                    return -1;
                }
                if(coins[0] - amount > 0)
                {
                    return -1;
                }    
                else
                {
                    return 1;
                }
            }

            Array.Sort(coins);
            Array.Reverse(coins);

            int count = 0;
            
            for(int i = 0; i < coins.Length; i++)
            {
         
                while(coins[i] <= amount)
                {
                    amount = amount - coins[i];
                    count++;
                }

            }
            
            if((amount > 0) && (count > 0))
            {
                return -1;
            }
            return count;
        */