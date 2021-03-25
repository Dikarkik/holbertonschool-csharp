using System;

/// <summary>
/// enum
/// </summary>
public enum Modifier
{
	/// <summary>
	/// Weak
	/// </summary>
	Weak,
	/// <summary>
	/// Base
	/// </summary>
	Base,
	/// <summary>
	/// Strong
	/// </summary>
	Strong
}

/// <summary>
/// delegate
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// class
/// </summary>
public class Player
{
	private String name { get; set; }
	private float maxHp { get; set; }
	private float hp { get; set; }

	/// <summary>
	/// constructor
	/// </summary>
	/// <param name="name"></param>
	/// <param name="maxHp"></param>
	public Player(String name = "Player", float maxHp = 100f)
	{
		this.name = name;

		if (maxHp > 0)
			this.maxHp = maxHp;
		else
		{
			this.maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}

		this.hp = this.maxHp;
	}

	/// <summary>
	/// Delegate
	/// </summary>
	/// <param name="amount"></param>
	public delegate void CalculateHealth(float amount);

	/// <summary>
	/// TakeDamage - If damage is negative, the Player takes 0.
	/// </summary>
	/// <param name="damage"></param>
	public void TakeDamage(float damage)
	{
		if (damage < 0)
			damage = 0;

		ValidateHP(this.hp - damage);
		Console.WriteLine($"{this.name} takes {damage} damage!");
	}

	/// <summary>
	/// HealDamage - If heal is negative, the Player heals 0 HP.
	/// </summary>
	/// <param name="heal"></param>
	public void HealDamage(float heal)
	{
		if (heal < 0)
			heal = 0;

		ValidateHP(this.hp + heal);
		Console.WriteLine($"{this.name} heals {heal} HP!");
	}

	/// <summary>
	/// ValidateHP - set the new health
	/// </summary>
	/// <param name="newHp"></param>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0)
			this.hp = 0;
		else if (newHp > maxHp)
			this.hp = maxHp;
		else
			this.hp = newHp;
	}

	/// <summary>
	/// print the player's health
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
	}

	/// <summary>
	/// Return the value depending of the modifier
	/// </summary>
	/// <param name="baseValue"></param>
	/// <param name="modifier"></param>
	/// <returns></returns>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		switch (modifier)
		{
			case Modifier.Weak:
				return baseValue * 0.5f;
			case Modifier.Strong:
				return baseValue * 1.5f;
			default:
				return baseValue;
		}
	}
}
