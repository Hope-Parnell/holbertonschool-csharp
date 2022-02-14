using System;

namespace Text
{
    /// <summary>Contains methods to be used on strings</summary>
    public class Str
    {
        /// <summary>Checks if a string is a palandrome</summary>
        public static bool IsPalindrome(string s){
            string s1 = "";
            foreach (char c in s){
                if (Char.IsLetterOrDigit(c)) {
                    s1 += c;
                }
            }
            s1 = s1.ToLower();
            string s2 = "";
            for (int i = s1.Length - 1; i >= 0 ; i--)
            {
                s2 += s1[i];
            }
            return s1 == s2;
        }
    }
}
