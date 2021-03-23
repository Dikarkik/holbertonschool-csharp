using System;

/// <summary>
/// Base - abstract class
/// </summary>
public abstract class Base
{
	/// <summary>
	/// name - public property
	/// </summary>
	public string name { get; set; }

	/// <summary>
	/// ToString - override of 'ToString'
	/// </summary>
	/// <returns>'name' is a 'type'</returns>
	public override string ToString()
	{
		return $"{name} is a {this.GetType()}";
	}
}

interface IInteractive
{
	void Interact();
}

interface IBreakable
{
	int durability { get; set; }
	void Break();
}

interface ICollectable
{
	bool isCollected { get; set; }
	void Collect();
}

/// <summary>
/// Decoration
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
	/// <summary>
	/// durability property
	/// </summary>
	public int durability { get; set; }

	/// <summary>
	/// isQuestItem property
	/// </summary>
	public bool isQuestItem { get; set; }

	/// <summary>
	/// contructor
	/// </summary>
	/// <param name="name"></param>
	/// <param name="durability"></param>
	/// <param name="isQuestItem"></param>
	public Decoration(String name, int durability, bool isQuestItem)
	{
		CheckDurability(durability);
		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}

	/// <summary>
	/// contructor
	/// </summary>
	/// <param name="durability"></param>
	/// <param name="isQuestItem"></param>
	public Decoration(int durability, bool isQuestItem)
	{
		CheckDurability(durability);
		this.name = "Decoration";
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}

	/// <summary>
	/// contructor
	/// </summary>
	/// <param name="name"></param>
	/// <param name="isQuestItem"></param>
	public Decoration(String name, bool isQuestItem)
	{
		this.name = name;
		this.durability = 1;
		this.isQuestItem = isQuestItem;
	}

	/// <summary>
	/// contructor
	/// </summary>
	/// <param name="name"></param>
	/// <param name="durability"></param>
	public Decoration(String name, int durability)
	{
		CheckDurability(durability);
		this.name = name;
		this.durability = durability;
		this.isQuestItem = false;
	}

	private void CheckDurability(int durability)
	{
		if (durability <= 0)
			throw new ArgumentException("Durability must be greater than 0");
	}

	/// <summary>
	/// Interact implementation
	/// </summary>
	public void Interact()
	{
		if (this.durability <= 0)
			Console.WriteLine($"The {this.name} has been broken.");
		else
		{
			if (isQuestItem)
				Console.WriteLine($"You look at the {this.name}. There's a key inside.");
			else
				Console.WriteLine($"You look at the {this.name}. Not much to see here.");
		}
	}

	/// <summary>
	/// Break implementation
	/// </summary>
	public void Break()
	{
		this.durability--;

		if (this.durability > 0)
			Console.WriteLine($"You hit the {this.name}. It cracks.");
		else if (this.durability == 0)
			Console.WriteLine($"You smash the {this.name}. What a mess.");
		else
			Console.WriteLine($"The {this.name} is already broken.");
	}
}
