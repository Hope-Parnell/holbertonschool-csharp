using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string best = "None";
        if (myList != null)
        {
            foreach(var entry in myList)
            {
                if (best == "None" || entry.Value > myList[best])
                    best = entry.Key;
            }
        }
        return best;
    }
}
