using System;

namespace Text
{
    public class Str
    {
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
