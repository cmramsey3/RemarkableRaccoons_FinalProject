/*
* Name: Colton Ramsey
* email: ramseyc6@mail.uc.edu
* Assignment Number: Final Exam
* Due Date: 12/12/2024
* Course #/Section: IS3050-002 
* Semester/Year: Fall 2024
* Brief Description of the assignment: Use asp.net to run leet code solutions.
* Citations: https://leetcode.com/problems/maximum-score-words-formed-by-letters/description/, https://chatgpt.com/
* Anything else that's relevant:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemarkableRaccoons_FinalProject
{
    public class ColtonRamsey1
    {
        /// <summary>
        /// Calculates the profit that you could earn by making stock trades. (Max two trades).
        /// </summary>
        /// <param name="prices">Daily stock prices entered as a list</param>
        /// <returns>Maximum profit from the stock trades.</returns>
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 2) return 0;
            int firstBuy = int.MinValue;
            int firstSell = 0;
            int secondBuy = int.MinValue;
            int secondSell = 0;
            foreach (int price in prices)
            {
                firstBuy = Math.Max(firstBuy, -price);
                firstSell = Math.Max(firstSell, firstBuy + price);
                secondBuy = Math.Max(secondBuy, firstSell - price);
                secondSell = Math.Max(secondSell, secondBuy + price);
            }
            return secondSell;
        }
    }
}