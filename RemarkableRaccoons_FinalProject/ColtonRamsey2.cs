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
    public class ColtonRamsey2
    {
        /// <summary>
        /// Calculates the area of a rectangle give the input coordinates. No entered point can be in the center of the made rectangle.
        /// </summary>
        /// <param name="xCoord">Input of all x coordinates</param>
        /// <param name="yCoord">Input of all y coordinates</param>
        /// <returns>Area of the rectangle or -1 if rectangle is not formed</returns>
        public int MaxRectangleArea(int[] xCoord, int[] yCoord)
        {
            int n = xCoord.Length;
            if (n < 4) return -1;
            var points = new HashSet<(int, int)>();
            for (int i = 0; i < n; i++)
            {
                points.Add((xCoord[i], yCoord[i]));
            }
            int maxArea = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (xCoord[i] != xCoord[j] && yCoord[i] != yCoord[j])
                    {
                        var corner1 = (xCoord[i], yCoord[j]);
                        var corner2 = (xCoord[j], yCoord[i]);

                        if (points.Contains(corner1) && points.Contains(corner2))
                        {
                            bool hasInnerPoint = false;
                            foreach (var point in points)
                            {
                                if (point.Item1 > Math.Min(xCoord[i], xCoord[j]) && point.Item1 < Math.Max(xCoord[i], xCoord[j]) &&
                                    point.Item2 > Math.Min(yCoord[i], yCoord[j]) && point.Item2 < Math.Max(yCoord[i], yCoord[j]))
                                {
                                    hasInnerPoint = true;
                                    break;
                                }
                            }
                            if (!hasInnerPoint)
                            {
                                int area = Math.Abs(xCoord[i] - xCoord[j]) * Math.Abs(yCoord[i] - yCoord[j]);
                                maxArea = Math.Max(maxArea, area);
                            }
                        }
                    }
                }
            }
            return maxArea;
        }

    }
}