/*
 * Program Documentation
 */

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
            lblDescription.Text = "Given a list of words, list of  single letters (might be repeating) and score of every character. Return the maximum score of any valid set of words formed by using the given letters (words[i] cannot be used two or more times). It is not necessary to use all characters in letters and each letter can only be used once. Score of letters 'a', 'b', 'c', ... ,'z' is given by score[0], score[1], ... , score[25] respectively.";
            IanMcDaniel solver = new IanMcDaniel();
            lblInputValues.Text = "Test Case 1: Words= [dog,cat,dad,good] Letter Array= [a,a,c,d,d,d,g,o,o] Letter Scores= [ 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ]       Test Case 2: Words = [xxxz, ax, bx, cx] , Letter Array [z, a, b, c, x, x, x] Letter Scores = [4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10]";
            string[] words1 = { "dog", "cat", "dad", "good" };
            char[] letters1 = { 'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o' };
            int[] score1 = { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int result1 = solver.MaxScoreWords(words1, letters1, score1);
            string[] words2 = { "xxxz", "ax", "bx", "cx" };
            char[] letters2 = { 'z', 'a', 'b', 'c', 'x', 'x', 'x' };
            int[] score2 = { 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10 };
            int result2 = solver.MaxScoreWords(words2, letters2, score2);
            lblSolution1.Text = $"Test Case 1 : {result1}";
            lblSolution2.Text = $"Test Case 2 : {result2}";
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
            lblLeetCode.Text = "Leet Code Problem #420";
            lblDescription.Text = "A password is considered strong if the below conditions are all met:It has at least 6 characters and at most 20 characters.It contains at least one lowercase letter, at least one uppercase letter, and at least one digit.It does not contain three repeating characters in a row (i.e., \"Baaabb0\" is weak, but \"Baaba0\" is strong).\r\nGiven a string password, return the minimum number of steps required to make password strong. if password is already strong, return 0.In one step, you can:Insert one character to password,Delete one character from password, or Replace one character of password with another character.";
            LucasIceman pwrd = new LucasIceman();
            lblInputValues.Text = "PasswordTest@1 , Baaabb0";
            string password1 =  "PasswordTest@1"  ;
            lblSolution1.Text = "Test Case 1: " + pwrd.StrongPasswordChecker(password1);
            string password2 = "Baaabb0";
            lblSolution2.Text = "Test Case 2: " + pwrd.StrongPasswordChecker(password2);
        }
    }
}