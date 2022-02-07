using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		// Number of items in queue
		Console.WriteLine("Number of items: {0}", aQueue.Count);
		// First item in queue
		if (aQueue.Count > 0)
			Console.WriteLine("First item: {0}", aQueue.Peek());
		else
			Console.WriteLine("Queue is empty");
		// Queue contains <search>
		Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));
		while (aQueue.Contains(search))
		{
			aQueue.Dequeue();
		}
		aQueue.Enqueue(newItem);
		return aQueue;
	}
}
