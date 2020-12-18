using System;

namespace Text
{
    /// <summary>
    /// This class defines operations for strings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// method that determines how many words are in a string.
        /// Each word begins with a capital letter except the first word.
        /// <param name="s">string to check</param>
        /// <returns>number of words in s</returns>
        /// </summary>
        public static int CamelCase(string s)
        {
            int count = 0;
            bool canCount = false;

            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (canCount == false && Char.IsLower(s[i]))
                    {
                        canCount = true;
                        count++;
                    }
                    else if (canCount == true && Char.IsUpper(s[i]))
                        count++;
                }
            }
            catch (NullReferenceException)
            { 
                return count;
            }
            return count;
        }
    }
}
