/*
 * Program Documentation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemarkableRaccoons_FinalProject
{
    public class LucasIceman
    {
        public int StrongPasswordChecker(string password)
        {
            int n = password.Length;
            bool hasLower = false, hasUpper = false, hasDigit = false;

            // Check for character type requirements
            foreach (char c in password)
            {
                if (char.IsLower(c)) hasLower = true;
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            int missingTypes = (hasLower ? 0 : 1) + (hasUpper ? 0 : 1) + (hasDigit ? 0 : 1);

            // Check for three consecutive repeating characters
            int replace = 0;
            for (int i = 2; i < n; i++)
            {
                if (password[i] == password[i - 1] && password[i - 1] == password[i - 2])
                {
                    replace++;
                    i++; // Skip the next character to break the sequence
                }
            }

            if (n < 6)
            {
                return Math.Max(6 - n, missingTypes);
            }
            else if (n <= 20)
            {
                return Math.Max(replace, missingTypes);
            }
            else
            {
                int delete = n - 20;

                // Reduce replace count based on deletes in sequences
                int[] overflow = new int[3];
                for (int i = 2; i < n; i++)
                {
                    if (password[i] == password[i - 1] && password[i - 1] == password[i - 2])
                    {
                        int length = 2;
                        while (i < n && password[i] == password[i - 1])
                        {
                            length++;
                            i++;
                        }
                        overflow[length % 3]++;
                    }
                }

                for (int i = 0; i < 3 && delete > 0; i++)
                {
                    while (overflow[i] > 0 && delete > i)
                    {
                        delete -= i + 1;
                        overflow[i]--;
                        replace--;
                    }
                }

                replace -= delete / 3;

                return (n - 20) + Math.Max(replace, missingTypes);
            }
        }
    }
}
