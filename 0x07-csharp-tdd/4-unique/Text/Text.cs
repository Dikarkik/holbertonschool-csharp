using System;

namespace Text
{
    /// <summary>
    /// This class defines operations for strings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// method that returns the index of the first non-repeating character of a string
        /// <param name="s">
        /// - string to check
        /// - You can assume the string contains only lowercase letters, no spaces or special characters
        /// </param>
        /// <returns> index of first non-repeating character or -1 if there is no non-repeating character</returns>
        /// </summary>
        public static int UniqueChar(string s)
        {
            int repetitions = 1;
            char currentChar = s[0];

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == currentChar)
                {
                    repetitions++;
                }
                else if (s[i] != currentChar && repetitions == 1)
                {
                    return i - 1;
                }
                else if (s[i] != currentChar && i == s.Length - 1)
                {
                    return i;
                }
                else if (s[i] != currentChar)
                { 
                    currentChar = s[i];
                    repetitions = 1;
                }
            }

            return -1;
        }
    }
}
