/*
* Name: Colton Ramsey, Lucas Iceman, Ian McDaniel, Saivamsi Amireddy
* email: ramseyc6@mail.uc.edu, icemanlc@mail.cu.edu, mcdaniip@mail.uc.edu, amiredsr@mail.uc.edu
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
            lblInputValues.Text = "Test Case 1: Words= [dog,cat,dad,good] Letter Array= [a,a,c,d,d,d,g,o,o] Letter Scores= [ 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ]   |    Test Case 2: Words = [xxxz, ax, bx, cx] , Letter Array [z, a, b, c, x, x, x] Letter Scores = [4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10]";
            string[] words1 = { "dog", "cat", "dad", "good" };
            char[] letters1 = { 'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o' };
            int[] score1 = { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int result1 = solver.MaxScoreWords(words1, letters1, score1);
            string[] words2 = { "xxxz", "ax", "bx", "cx" };
            char[] letters2 = { 'z', 'a', 'b', 'c', 'x', 'x', 'x' };
            int[] score2 = { 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10 };
            int result2 = solver.MaxScoreWords(words2, letters2, score2);
            lblSolution1.Text = $"Test Case 1: {result1}";
            lblSolution2.Text = $"Test Case 2: {result2}";
        }

        protected void btnColton1_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #123";
            lblDescription.Text = "You are given an array prices where prices[i] is the price of a given stock on the ith day. Find the maximum profit you can achieve. You may complete at most two transactions. Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).";
            ColtonRamsey1 stocks = new ColtonRamsey1();
            lblInputValues.Text = "Test Case 1: { 3, 3, 5, 0, 0, 3, 1, 4 }     |     Test Case 2: { 7, 6, 4, 3, 1}";
            int[] stock_prices1 = { 3, 3, 5, 0, 0, 3, 1, 4 };
            lblSolution1.Text = "Test Case 1: " + stocks.MaxProfit(stock_prices1);
            int[] stock_prices2 = { 7, 6, 4, 3, 1 };
            lblSolution2.Text = "Test Case 2: " + stocks.MaxProfit(stock_prices2);
            lblResults.Text = "Results";
        }

        protected void btnColton2_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #3382";
            lblDescription.Text = "There are n points on an infinite plane. You are given two integer arrays xCoord and yCoord where (xCoord[i], yCoord[i]) represents the coordinates of the ith point.\r\n\r\nYour task is to find the maximum area of a rectangle that:\r\n\r\nCan be formed using four of these points as its corners.\r\nDoes not contain any other point inside or on its border.\r\nHas its edges parallel to the axes.\r\nReturn the maximum area that you can obtain or -1 if no such rectangle is possible.";
            ColtonRamsey2 rectangle = new ColtonRamsey2();
            lblInputValues.Text = "Test Case 1: xCoord = [1,1,3,3], yCoord = [1,3,1,3]    |    Test Case 2: xCoord = [1,1,3,3,2], yCoord = [1,3,1,3,2]";
            int[] xCoord1 = { 1, 1, 3, 3 };
            int[] xCoord2 = { 1, 1, 3, 3, 2 };
            int[] yCoord1 = { 1, 3, 1, 3 };
            int[] yCoord2 = { 1, 3, 1, 3, 2 };
            lblSolution1.Text = "Test Case 1: " + rectangle.MaxRectangleArea(xCoord1, yCoord1);
            lblSolution2.Text = "Test Case 2: " + rectangle.MaxRectangleArea(xCoord2, yCoord2);
            lblResults.Text = "Results";
        }

        protected void btnLucas_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #420";
            lblDescription.Text = "A password is considered strong if the below conditions are all met:It has at least 6 characters and at most 20 characters.It contains at least one lowercase letter, at least one uppercase letter, and at least one digit.It does not contain three repeating characters in a row (i.e., \"Baaabb0\" is weak, but \"Baaba0\" is strong).\r\nGiven a string password, return the minimum number of steps required to make password strong. if password is already strong, return 0.In one step, you can:Insert one character to password,Delete one character from password, or Replace one character of password with another character.";
            LucasIceman pwrd = new LucasIceman();
            lblInputValues.Text = "Test Case 1: PasswordTest@1 | Test Case 2: Baaabb0";
            string password1 =  "PasswordTest@1"  ;
            lblSolution1.Text = "Test Case 1: " + pwrd.StrongPasswordChecker(password1);
            string password2 = "Baaabb0";
            lblSolution2.Text = "Test Case 2: " + pwrd.StrongPasswordChecker(password2);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "";
            lblDescription.Text = "";
            lblInputValues.Text = "";
            lblSolution1.Text = "";
            lblSolution2.Text = "";
            lblResults.Text = "";
        }

        protected void btnSaivamsi_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem: Find Median of Two Sorted Arrays";
            lblDescription.Text = "Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.";
            SaivamsiAmireddy solver = new SaivamsiAmireddy();
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            double result = solver.FindMedianSortedArrays(nums1, nums2);
            lblSolution1.Text = $"Median is: {result}";
            lblInputValues.Text = "Test Case: nums1 = [1, 3], nums2 = [2]";
            
            int[] nums1b = {1, 2};
            int[] nums2b = {3, 4};
            double result2 = solver.FindMedianSortedArrays(nums1b, nums2b);
            lblSolution2.Text = $"Test Case 2: {result2}";

        }
    }
}