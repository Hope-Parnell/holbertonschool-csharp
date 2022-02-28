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
/// <summary>Door class.</summary>
public class Door: Base, IInteractive{
	/// <summary>Door constructor.</summary>
	public Door(string dName = "Door") => name = dName;
	/// <summary>Interact with the door.</summary>
	public void Interact() => Console.WriteLine($"You try to open the {name}. It's locked.");
}
