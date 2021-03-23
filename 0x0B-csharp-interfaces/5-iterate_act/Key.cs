using System;

/// <summary>
/// Decoration
/// </summary>
public class Key : Base, ICollectable
{
	/// <summary>
	/// isCollected property
	/// </summary>
	public bool isCollected { get; set; }

	/// <summary>
	/// constructor
	/// </summary>
	/// <param name="name"></param>
	/// <param name="isCollected"></param>
	public Key(String name, bool isCollected)
	{
		this.name = name;
		this.isCollected = isCollected;
	}

	/// <summary>
	/// constructor
	/// </summary>
	/// <param name="isCollected"></param>
	public Key(bool isCollected)
	{
		this.name = "Key";
		this.isCollected = isCollected;
	}

	/// <summary>
	/// constructor
	/// </summary>
	/// <param name="name"></param>
	public Key(String name)
	{
		this.name = name;
		this.isCollected = false;
	}

	/// <summary>
	/// Collect implementation
	/// </summary>
	public void Collect()
	{
		if (!this.isCollected)
		{
			Console.WriteLine($"You pick up the {this.name}.");
			this.isCollected = true;
		}
		else
			Console.WriteLine($"You have already picked up the {this.name}.");
	}
}
