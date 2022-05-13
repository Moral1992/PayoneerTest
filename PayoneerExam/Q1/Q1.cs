using System;
using System.Collections.Generic;
using System.Text;

namespace PayoneerExam
{
    public class Q1
    {
        public static int getMaxRevenue(int[] stockRates)
        {
            if (stockRates == null || stockRates.Length < 2)
            {
                return 0;
            }

            int buy = stockRates[0];
            int sell = stockRates[1];
            int max_revenue = sell - buy;

            int current_profit = 0;

            for (int i = 1; i < stockRates.Length; i++)
            {
                current_profit = stockRates[i] - buy;

                if (current_profit > max_revenue)
                {
                    max_revenue = current_profit;
                    sell = stockRates[i];
                }

                if (buy > stockRates[i])
                {
                    buy = stockRates[i];
                }
            }

            return max_revenue;
        }
    }
}
