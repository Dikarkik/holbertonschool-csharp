using System;

/// <summary>
/// Queue - Generic class
/// </summary>
/// <typeparam name="T">some type</typeparam>
public class Queue<T>
{
	/// <summary>
	/// CheckType - method to ckeck the Queue’s type
	/// </summary>
	/// <returns>the type of T</returns>
	public string CheckType()
	{
		return typeof(T).ToString();
	}
}
