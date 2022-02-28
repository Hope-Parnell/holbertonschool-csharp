using System;
/// <summary>Base class containing name and string override.</summary>
public abstract class Base{
	/// <summary>Name of the object.</summary>
	public string name {get; set;}
	/// <summary>String override.</summary>
	public override string ToString() => $"{this.name} is a {this.GetType()}";
}

interface IInteractive{
	void Interact();
}
interface IBreakable{
	int durability{get; set;}
	void Break();
}

interface ICollectable{
	bool isCollected{get; set;}
	void Collect();
}
/// <summary>Test class for interfaces</summary>
public class TestObject: Base, IInteractive, IBreakable, ICollectable{
	/// <summary>Implementation of durability.</summary>
	public int durability{get; set;}
	/// <summary>Implementation of isCollected.</summary>
	public bool isCollected{get; set;}
	/// <summary>Implementation of Interact().</summary>
	public void Interact(){}
	/// <summary>Implementation of Break().</summary>
	public void Break(){}
	/// <summary>Implementation of Collect().</summary>
	public void Collect(){}
}
