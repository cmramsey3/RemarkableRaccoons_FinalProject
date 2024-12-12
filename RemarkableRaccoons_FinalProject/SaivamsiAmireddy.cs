/*
* Name: Saivamsi Amireddy
* email:  amiredsr@mail.uc.edu
* Assignment Number: Final Exam
* Due Date: 12 December 2024
* Course #/Section: IS3050 002 
* Semester/Year: FS2024
* Brief Description of the assignment: Using mastery of aspx to design a website with press of button runs this code in this file and displays an result
* Citations: https://leetcode.com/problems/median-of-two-sorted-arrays/, https://chatgpt.com/
* Anything else that's relevant:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemarkableRaccoons_FinalProject
{
    public class SaivamsiAmireddy
    {
        /// <summary>
        /// Finds the median of the two sorted arrays
        /// </summary>
        /// <param name="nums1">The first sorted integer array</param>
        /// <param name="nums2">The second sorted integer array</param>
        /// <returns>The median of the combined sorted arrays</returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            int i = 0;
            int j = 0;
            int k = 0;


            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] <= nums2[j])
                {
                    mergedArray[k++] = nums1[i++];
                }
                else
                {
                    mergedArray[k++] = nums2[j++];
                }
            }


            while (i < nums1.Length)
            {
                mergedArray[k++] = nums1[i++];
            }


            while (j < nums2.Length)
            {
                mergedArray[k++] = nums2[j++];
            }


            if (mergedArray.Length % 2 == 1)
            {

                return (double)mergedArray[mergedArray.Length / 2];
            }
            else
            {

                int mid1 = mergedArray.Length / 2 - 1;
                int mid2 = mergedArray.Length / 2;
                return (double)(mergedArray[mid1] + mergedArray[mid2]) / 2.0;
            }
        }
    }
}