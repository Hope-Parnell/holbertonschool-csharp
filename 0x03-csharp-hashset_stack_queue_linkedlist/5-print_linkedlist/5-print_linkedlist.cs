using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
		LinkedList<int> LinkList = new LinkedList<int>();
		for (int i = 0; i < size; i++)
			LinkList.AddLast(i);
		foreach (var n in LinkList)
			Console.WriteLine(n);
		return LinkList;
	}
}
