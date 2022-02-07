using System;
using System.Collections.Generic;

class MyStack
{
	public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
	{
		// Number of items in stack
		Console.WriteLine("Number of items: {0}", aStack.Count);
		// First item in stack
		if (aStack.Count > 0)
			Console.WriteLine("Top item: {0}", aStack.Peek());
		else
			Console.WriteLine("Stack is empty");
		// Stack contains <search>
		Console.WriteLine("Stack contains {0}: {1}", search, aStack.Contains(search));
		while (aStack.Contains(search))
		{
			aStack.Pop();
		}
		aStack.Push(newItem);
		return aStack;

	}
}
