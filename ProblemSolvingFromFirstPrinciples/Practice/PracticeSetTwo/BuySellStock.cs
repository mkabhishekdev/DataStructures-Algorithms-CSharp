using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class BuySellStock
    {
        public int BuySell(int[] prices)
        {
            if(prices.Length == 0)
            {
                return 0;
            }

           int minPrice = prices[0];
           int maxProfit = 0;

           for(int i = 1; i < prices.Length; i++)
           {
               if(prices[i] < minPrice)
               {
                   minPrice = prices[i];
               }

               int currentProfit = prices[i] - minPrice;

               if(currentProfit > maxProfit)
               {
                   maxProfit = currentProfit; 
               }
           }

           return maxProfit;
        }
    }
}