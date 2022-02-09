using System.Diagnostics;

enum Rating {Good, Great, Excellent}

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
struct Dog {
	public string name;
	public float age;
	public string owner;
	public Rating rating;

	public Dog(string name, float age, string owner, Rating rating){
		this.name = name;
		this.age = age;
		this.owner = owner;
		this.rating = rating;
	}

	public override string ToString() => string.Join('\n',
							$"Dog Name: {name}",
							$"Age: {age}",
							$"Owner: {owner}",
							$"Rating: {rating}");
}
