using System;

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
	public Decoration(String name="Decoration", int durability=1, bool isQuestItem=false)
	{
		if (durability <= 0)
			throw new ArgumentException("Durability must be greater than 0");

		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
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
