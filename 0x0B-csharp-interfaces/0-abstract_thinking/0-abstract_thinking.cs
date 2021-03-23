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
