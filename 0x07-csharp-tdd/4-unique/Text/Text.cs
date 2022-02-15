using System;

namespace Text
{
    /// <summary>Contains methods to be used on strings.</summary>
    public class Str
    {
        /// <summary>Returns the index of the first unique character in a string.</summary>
        public static int UniqueChar(string s){
            if (s == null || s == "")
                return -1;
            for (int i = 0; i < s.Length; i++){
                int ct = 0;
                foreach (char c in s){
                    if (c == s[i])
                        ct++;
                    if (ct > 1)
                        break;
                }
                if (ct == 1)
                    return i;
            }
            return -1;
        }
    }
}
