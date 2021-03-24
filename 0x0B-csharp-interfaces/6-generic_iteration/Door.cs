using System;

/// <summary>
/// Door
/// </summary>
public class Door : Base, IInteractive
{
	/// <summary>
	/// constructor
	/// </summary>
	public Door() => name = "Door";

	/// <summary>
	/// constructor with name
	/// </summary>
	/// <param name="name">name</param>
	public Door(String name) => this.name = name;

	/// <summary>
	/// Interact implementation
	/// </summary>
	public void Interact()
	{
		Console.WriteLine($"You try to open the {name}. It's locked.");
	}
}
