using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RemarkableRaccoons_FinalProject
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIan_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #1255";
            lblDescription.Text = "This is problem number 1255";
            lblSolution1.Text = "Test test test";
        }

        protected void btnColton_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #123";
            lblDescription.Text = "You are given an array prices where prices[i] is the price of a given stock on the ith day. Find the maximum profit you can achieve. You may complete at most two transactions. Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).";
            ColtonRamsey stocks = new ColtonRamsey();
            lblInputValues.Text = "{ 3, 3, 5, 0, 0, 3, 1, 4 },  { 7, 6, 4, 3, 1}";
            int[] stock_prices1 = { 3, 3, 5, 0, 0, 3, 1, 4 };
            lblSolution1.Text = "Test Case 1: " + stocks.MaxProfit(stock_prices1);
            int[] stock_prices2 = { 7, 6, 4, 3, 1};
            lblSolution2.Text = "Test Case 2: " + stocks.MaxProfit(stock_prices2);
        }

        protected void btnSai_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #";
            lblDescription.Text = "";
            lblSolution1.Text = "";
        }

        protected void btnLucas_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #";
            lblDescription.Text = "";
            lblSolution1.Text = "";
        }
    }
}