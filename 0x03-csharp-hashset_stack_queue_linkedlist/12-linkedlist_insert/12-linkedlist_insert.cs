using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		var node = myLList.First;
		if (node == null || n < node.Value)
			return myLList.AddFirst(n);
		if (n > myLList.Last.Value)
			return myLList.AddLast(n);
		while (node != null && n > node.Value)
			node = node.Next;
		return myLList.AddBefore(node, n);
	}
}
