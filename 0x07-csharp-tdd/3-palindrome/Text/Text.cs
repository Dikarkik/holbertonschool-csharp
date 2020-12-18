using System;

namespace Text
{
    /// <summary>
    /// This class defines operations for strings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// method that returns True if a string is a palindrome
        /// <param name="s">
        /// - string to check
        /// - Here, palindromes are not case sensitive (Racecar = True)
        /// - Spaces and punctuation should be ignored (A man, a plan, a canal: Panama. = True)
        /// </param>
        /// <returns>True if string is a palindrome, False if it’s not</returns>
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            int i1, i2;

            s = s.ToLower();
            s = String.Join("", s.Split(' ', ',', '.', ';', ':', '\''));
            i1 = 0;
            i2 = s.Length - 1;

            while (i1 < i2)
            {
                if (s[i1] != s[i2])
                    return false;

                i1++;
                i2--;
            }

            return true;
        }
    }
}
