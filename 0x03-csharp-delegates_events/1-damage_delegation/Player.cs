using System;
public delegate void CalculateHealth(float hpInfo);
/// <summary>Class for a player.</summary>
public class Player{
	private string name;
	private float maxHp;
	private float hp;
	/// <summary>Player Constructor sets name and hp.</summary>
	public Player(string name="Player", float maxHp=100f){
		this.name = name;
		if (maxHp <= 0){
			maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		this.maxHp = maxHp;
		this.hp = maxHp;
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
	}
	/// <summary>Heal Damage.</summary>
	public void HealDamage(float heal){
		if (heal < 0)
			heal = 0f;
		Console.WriteLine($"{name} heals {heal} HP!");
	}
}

