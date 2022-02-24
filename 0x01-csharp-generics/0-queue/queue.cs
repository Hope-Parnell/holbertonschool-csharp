using System;

/// <summary>Class for creating and using Queues.</summary>
public class Queue<T>{
	/// <summary>Returns the type for the queue.</summary>
	public Type CheckType(){
		return typeof(T);
	}
}
