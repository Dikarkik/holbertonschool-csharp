using System;

/// <summary>
/// Base - abstract class
/// </summary>
public abstract class Base
{
	/// <summary>
	/// name - public property
	/// </summary>
	public string name;

	/// <summary>
	/// property for 'name'
	/// </summary>
	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	/// <summary>
	/// ToString - override of 'ToString'
	/// </summary>
	/// <returns></returns>
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
/// TestObject - class to test inherits from abstract class and interfaces
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	/// <summary>
	/// durability property
	/// </summary>
	public int durability { get; set; }

	/// <summary>
	/// isCollected property
	/// </summary>
	public bool isCollected { get; set; }

	/// <summary>
	/// Interact implementation
	/// </summary>
	public void Interact()
	{
		throw new NotImplementedException();
	}

	/// <summary>
	/// Break implementation
	/// </summary>
	public void Break()
	{
		throw new NotImplementedException();
	}

	/// <summary>
	/// Collect implementation
	/// </summary>
	public void Collect()
	{
		throw new NotImplementedException();
	}
}
