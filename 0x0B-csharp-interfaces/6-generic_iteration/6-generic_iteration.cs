using System;
using System.Collections.Generic;
using System.Collections;

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
/// Objs - generic class that creates a collection of type T objects that can be iterated through using foreach.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Objs<T> : IEnumerable<T>
{
	private List<T> mylist = new List<T>();

	/// <summary>
	/// Add - to add a new object
	/// </summary>
	/// <param name="obj"></param>
	public void Add(T obj)
	{
		mylist.Add(obj);
	}

	/// <summary>
	/// GetEnumerator - http://james-ramsden.com/implement-ienumerable-c/
	/// </summary>
	/// <returns></returns>
	public IEnumerator<T> GetEnumerator()
	{
		foreach (T val in mylist)
			yield return val;
	}

	//This method is also needed, but usually you don't need to change it from this.
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
