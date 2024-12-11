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
        /// <summary>
        /// Calculates the maximum score of any valid subset of words formed by using given letters.
        /// </summary>
        /// <param name="words">Array of words to choose from.</param>
        /// <param name="letters">Array of available letters (may contain duplicates).</param>
        /// <param name="score">Array where score[i] represents the score of the letter 'a' + i.</param>
        /// <returns>Maximum score of any valid subset of words.</returns>
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

        /// <summary>
        /// Performs backtracking to explore all possible subsets of words and calculates the maximum score.
        /// </summary>
        /// <param name="words">Array of words to choose from.</param>
        /// <param name="letterCounts">Frequency array of available letters.</param>
        /// <param name="score">Array where score[i] represents the score of the letter 'a' + i.</param>
        /// <param name="index">Current index in the words array being processed.</param>
        /// <returns>Maximum score that can be achieved starting from the given index.</returns>
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