using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> list = new List<bool>();
        myList.ForEach(n => list.Add(n % 2 == 0));
        return list;
    }
}
