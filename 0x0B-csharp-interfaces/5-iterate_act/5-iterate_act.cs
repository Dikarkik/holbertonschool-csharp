using System;
using System.Collections.Generic;
using System.Reflection;

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
/// class
/// </summary>
public class RoomObjects
{
	/// <summary>
	/// execute methods depending on what interface that item implements
	/// </summary>
	/// <param name="roomObjects"></param>
	/// <param name="type"></param>
	public static void IterateAction(List<Base> roomObjects, Type type)
	{
		for (int i = 0; i < roomObjects.Count; i++)
		{
			if (type.IsAssignableFrom(roomObjects[i].GetType()))
			{
				Console.WriteLine("do work");
			}
		}
	}
}
