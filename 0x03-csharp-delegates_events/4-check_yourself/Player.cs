using System;
/// <summary>enum for modifiers</summary>
public enum Modifier {
	/// <summary>Weak mod.</summary>
	Weak,
	/// <summary>No mod.</summary>
	Base,
	/// <summary>Strong mod.</summary>
	Strong
}
/// <summary>Delegate for modifier calculation.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
/// <summary>Delegate for health changes.</summary>
public delegate void CalculateHealth(float hpInfo);
/// <summary>Class for a player.</summary>
public class Player{
	private string name;
	private float maxHp;
	private float hp;
	private string status;
	/// <summary>Checks HP.</summary>
	public EventHandler<CurrentHPArgs> HPCheck;
	/// <summary>Player Constructor sets name and hp.</summary>
	public Player(string name="Player", float maxHp=100f){
		this.name = name;
		if (maxHp <= 0){
			maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		this.maxHp = maxHp;
		this.hp = maxHp;
		this.status = $"{name} is ready to go!";
		this.HPCheck = this.CheckStatus;
	}
	/// <summary>Displays current health to the console.</summary>
	public void PrintHealth(){
		Console.WriteLine($"{name} has {hp} / {maxHp} health");
	}
	/// <summary>Take Damage.</summary>
	public void TakeDamage(float damage){
		if (damage < 0)
			damage = 0f;
		Console.WriteLine($"{name} takes {damage} damage!");
		ValidateHP(this.hp - damage);
	}
	/// <summary>Heal Damage.</summary>
	public void HealDamage(float heal){
		if (heal < 0)
			heal = 0f;
		Console.WriteLine($"{name} heals {heal} HP!");
		ValidateHP(this.hp + heal);
	}
	/// <summary>Change current HP to reflect damage/heals.</summary>
	public void ValidateHP(float newHp){
		if (newHp < 0)
			newHp = 0f;
		if (newHp > this.maxHp)
			newHp = this.maxHp;
		this.hp = newHp;
		this.HPCheck(this, new CurrentHPArgs(this.hp));
	}
	/// <summary>Applies modifiers</summary>
	public float ApplyModifier(float baseValue, Modifier modifier){
		if (modifier == Modifier.Weak)	{ return baseValue / 2; }
		if (modifier == Modifier.Strong)	{ return baseValue * 1.5f; }
		return baseValue;
	}
	private void CheckStatus(object sender, CurrentHPArgs e){
		if (this.hp == this.maxHp)
			this.status = $"{name} is in perfect health!";
		else if (this.hp >= maxHp / 2)
			this.status = $"{name} is doing well!";
		else if (this.hp >= maxHp / 4)
			this.status = $"{name} isn't doing too great...";
		else if (this.hp > 0)
			this.status = $"{name} needs help!";
		else
			this.status = $"{name} is knocked out!";
		Console.WriteLine(status);
	}
}
/// <summary>HP Event class.</summary>
public class CurrentHPArgs: EventArgs{
	/// <summary>The current HP.</summary>
	public readonly float currentHp;
	/// <summary>Sets current HP.</summary>
	public CurrentHPArgs(float newHp){
		this.currentHp = newHp;
	}
}
