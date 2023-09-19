using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges.Challenges
{
    public class _121_Best_Time_to_Buy_and_Sell_Stock
    {
        //public int MaxProfit(int[] prices)
        //{
        //    if (prices.Length == 0) return 0;

        //    int lower = prices[0];
        //    int profit = 0;
        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        if (prices[i] <= lower)
        //        {
        //            lower = prices[i];
        //            for (int j = i + 1; j < prices.Length; j++)
        //            {
        //                if ((prices[j] - lower) >= profit)
        //                {
        //                    profit = prices[j] - lower;
        //                }
        //            }
        //        }
        //    }
        //    return profit;
        //}

        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int minPrice = prices[0];
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if ((prices[i] - minPrice) > profit)
                {
                    profit = prices[i] - minPrice;
                }

                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
            }
            return profit;
        }
    }
}
