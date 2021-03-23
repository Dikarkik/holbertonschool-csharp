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
	public Key(String name="Key", bool isCollected=false)
	{
		this.name = name;
		this.isCollected = isCollected;
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
