using System;

/// <summary>
/// Base - abstract class
/// </summary>
public abstract class Base
{
	/// <summary>
	/// name - public property
	/// </summary>
	public string name { get; set; } = "Door";

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
/// Door
/// </summary>
public class Door : Base, IInteractive
{
	/// <summary>
	/// constructor
	/// </summary>
	/// <param name="n">name</param>
	public Door(String n)
	{
		name = n;
	}

	/// <summary>
	/// Interact implementation
	/// </summary>
	public void Interact()
	{
		Console.WriteLine("You try to open the <name>. It's locked.");
	}
}
