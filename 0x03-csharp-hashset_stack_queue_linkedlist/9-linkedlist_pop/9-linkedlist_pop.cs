using System;
using System.Collections.Generic;

class LList
{
	public static int Pop(LinkedList<int> myLList)
	{
		var node = myLList.First;
		if (node == null)
			return 0;
		int value = node.Value;
		myLList.RemoveFirst();
		return value;
	}
}
