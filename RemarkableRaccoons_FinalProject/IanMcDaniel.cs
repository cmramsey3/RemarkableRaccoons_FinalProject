/*
* Name: Ian McDaniel
* email:  mcdaniip@mail.uc.edu
* Assignment Number: Final Exam
* Due Date: 12 December 2024
* Course #/Section: IS3050 002 
* Semester/Year: FS2024
* Brief Description of the assignment: Using mastery of aspx to design a website with press of button runs this code in this file and displays an result
* Citations: https://leetcode.com/problems/maximum-score-words-formed-by-letters/description/, https://chatgpt.com/
* Anything else that's relevant:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemarkableRaccoons_FinalProject
{
    public class IanMcDaniel
    {
        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            // Convert letters array into a frequency dictionary
            int[] letterCounts = new int[26];
            foreach (char letter in letters)
            {
                letterCounts[letter - 'a']++;
            }

            return Backtrack(words, letterCounts, score, 0);
        }

        private int Backtrack(string[] words, int[] letterCounts, int[] score, int index)
        {
            if (index == words.Length)
                return 0;

            // Option 1: Skip the current word
            int maxScore = Backtrack(words, letterCounts, score, index + 1);

            // Option 2: Use the current word (if possible)
            int wordScore = 0;
            bool canUseWord = true;

            foreach (char c in words[index])
            {
                if (--letterCounts[c - 'a'] < 0) // Not enough letters to use this word
                    canUseWord = false;

                wordScore += score[c - 'a'];
            }

            if (canUseWord)
            {
                // Include the word's score and proceed with remaining words
                maxScore = Math.Max(maxScore, wordScore + Backtrack(words, letterCounts, score, index + 1));
            }

            // Restore letter counts for backtracking
            foreach (char c in words[index])
            {
                letterCounts[c - 'a']++;
            }

            return maxScore;
        }
    }
}