using System;

namespace Text
{
    /// <summary>Contains methods to be used on strings.</summary>
    public class Str
    {
        /// <summary>Returns number of words in a camel case string.</summary>
        public static int CamelCase(string s){
            if (s.Length == 0) { return 0; }
            int words = 1;
            foreach (char c in s){
                if (Char.IsUpper(c)) { words++; }
            }
            return words;
        }
    }
}
