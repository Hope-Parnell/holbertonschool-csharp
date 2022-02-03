using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>();
        foreach (var item in myDict)
            keys.Add(item.Key);
        keys.Sort();
        keys.ForEach(key => Console.WriteLine("{0}: {1}", key, myDict[key]));
    }
}
