using System;
namespace Enemies
{
	/// <summary>This is the Zombie class.</summary>
	public class Zombie{
		int health;
		/// <summary>Constructor for Zombie sets health to 0.</summary>
		public Zombie(){
			this.health = 0;
		}
		/// <summary>
		/// Constructor for custom Zombie health.
		/// Throws a ArgumentException error if input is less than 0.
		/// </summary>
		public Zombie(int value){
			if (value < 0)
				throw new ArgumentException("Health must be greater than or equal to 0");
			this.health = value;
		}
		/// <summary>Returns the health of a Zombie.</summary>
		public int GetHealth() {
			return this.health;
		}
	}
}
