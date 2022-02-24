using System;

/// <summary>Class for creating and using Queues.</summary>
public class Queue<T>{
	/// <summary>Returns the type for the queue.</summary>
	public Type CheckType(){
		return typeof(T);
	}
	/// <summary>Node class for members of the queue.</summary>
	public class Node{
		/// <summary>Value contained in the node.</summary>
		public T value;
		/// <summary>Next node in the queue.</summary>
		public Node next = null;
		/// <summary>Constructor for a node.</summary>
		public Node(T value){
			this.value = value;
		}
	}
	Node head = null;
	Node tail = null;
	int count = 0;
	/// <summary>Adds item to end of Queue</summary>
	public void Enqueue(T value){
		Node n = new Node(value);
		if (this.head == null)
			this.head = n;
		else
			this.tail.next = n;
		this.tail = n;
		count++;
	}
	/// <summary>Retruns the number of items in Queue</summary>
	public int Count() => this.count;
	/// <summary>Removes top item of Queue and returns its value</summary>
	public T Dequeue(){
		if (head == null){
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		Node hide = this.head;
		this.head = this.head.next;
		count--;
		return hide.value;
	}
	/// <summary>Returns top value of Queue.</summary>
	public T Peek(){
		if (head == null){
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		return this.head.value;
	}
	/// <summary>Prints the Queue.</summary>
	public void Print(){
		if (head == null){
			Console.WriteLine("Queue is empty");
		}
		else{
			for (Node n = head; n != null; n = n.next)
				Console.WriteLine(n.value);
		}
	}
	/// <summary>Concatinates the Queue if it contains Strings or Chars.</summary>
	public string Concatenate(){
		if (head == null){
			Console.WriteLine("Queue is empty");
			return null;
		}
		if (typeof(T) != typeof(string) && typeof(T) != typeof(char)){
			Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
			return null;
		}
		string cat = "";
		for (Node n = head; n != null; n = n.next)
			cat += n.value;
		return cat;
	}
}
