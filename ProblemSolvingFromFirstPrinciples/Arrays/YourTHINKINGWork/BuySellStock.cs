using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.Arrays.YourTHINKINGWork
{
    /*
  APPROACH I CAME UP WITH::
  1. Start with the first element set as MinPriceSoFar variable & MaxProfit = 0
  2. Keep updating MinPriceSoFar and Profit inside the for loop based on the conditions to satisfy
  3. Get the MaxProfit
  
  Time Complexity: O(n)
  Space Complexity: O(1)
   */

    public class BuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            if ((prices.Length == 0) || (prices.Length == 1))
            {
                return 0;
            }

            int minPriceSofar = prices[0];
            int maxProfit = 0;

        
            for (int i = 1; i < prices.Length; i++)
            {
                int profit = prices[i] - minPriceSofar;

                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
                    
                if(prices[i] < minPriceSofar)
                {
                    minPriceSofar = prices[i];
                }
            }
            
            return maxProfit;

        
        }
    }



}

  
  
  
  
    // If all test cases not clearing, PRACTICE DEBUGGING
  /* FAILED APPROACH & WHY()
    1. Find the minimum value and remember the array min index
    2. Go through the indexes after min index and subtract that value with min index value and store them in a list
    3. Pick the max from the list, that is the profit
    4. Handle edge case, if it is the last index or if you get 0,or less than 0 -> return 0
        */ 