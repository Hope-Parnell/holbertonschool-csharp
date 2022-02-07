using System;
using System.Collections.Generic;

class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		List<int> commonList = new List<int>();
		foreach (var n in list1)
		{
			if (!commonList.Contains(n) && !list2.Contains(n))
				commonList.Add(n);
		}
		foreach (var n in list2)
		{
			if (!commonList.Contains(n) && !list1.Contains(n))
				commonList.Add(n);
		}
		commonList.Sort();
		return commonList;
	}
}
