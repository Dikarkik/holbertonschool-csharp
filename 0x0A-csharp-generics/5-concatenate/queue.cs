using System;

/// <summary>
/// Queue - Generic class
/// </summary>
/// <typeparam name="T">some type</typeparam>
public class Queue<T>
{
	/// <summary>
	/// Node - Queue's node
	/// </summary>
	public class Node
	{
		/// <summary>
		/// Contructor
		/// </summary>
		/// <param name="val">value</param>
		public Node(T val)
		{
			value = val;
			next = null;
		}

		private T value = default(T);
		/// <summary>
		/// property for 'value'
		/// </summary>
		public T Value
		{
			get { return value; }
			set { this.Value = value; }
		}

		private Node next = null;
		/// <summary>
		/// property for 'next'
		/// </summary>
		public Node Next
		{
			get { return next; }
			set { next = value; }
		}
	}

	private Node _head = null;
	private Node _tail = null;
	private int _count = 0;

	/// <summary>
	/// Enqueue - method to add a node to the Queue
	/// </summary>
	/// <param name="val">value</param>
	public void Enqueue(T val)
	{
		Node n = new Node(val);

		if (_head == null)
		{
			_head = n;
			_tail = n;
		}
		else
		{
			_tail.Next = n;
			_tail = n;
		}

		_count++;
	}

	/// <summary>
	/// Dequeue - removes the first node in the queue
	/// </summary>
	/// <returns>returns the value of the deleted node</returns>
	public T Dequeue()
	{
		if (_head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}

		Node deletedNode = _head;

		if (_head.Next != null)
			_head = _head.Next;

		_count--;
		return deletedNode.Value;
	}

	/// <summary>
	/// Peek - returns the value of the first node of the queue without removing the node
	/// </summary>
	/// <returns>the value of the first node. If the queue is empty, the default value of the parameter’s type</returns>
	public T Peek()
	{
		if (_head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}

		return _head.Value;
	}

	/// <summary>
	/// Count - method to check the size of the Queue
	/// </summary>
	/// <returns>the number of nodes in the Queue</returns>
	public int Count()
	{
		return _count;
	}

	/// <summary>
	/// CheckType - method to ckeck the Queue’s type
	/// </summary>
	/// <returns>the type of T</returns>
	public string CheckType()
	{
		return typeof(T).ToString();
	}

	/// <summary>
	/// Print - prints the queue, starting from the head
	/// </summary>
	public void Print()
	{
		if (_head == null)
		{
			Console.WriteLine("Queue is empty");
			return;
		}

		Node current = _head;

		for (int i = 0; i < _count; i++)
		{
			Console.WriteLine(current.Value);
			current = current.Next;
		}
	}

	/// <summary>
	/// Concatenate - concatenates all values in the queue only if the queue is of type String or Char.
	/// </summary>
	public String Concatenate()
	{
		if (_head == null)
		{
			Console.WriteLine("Queue is empty");
			return null;
		}

		String space;

		if (typeof(T) == typeof(String))
			space = " ";
		else if (typeof(T) == typeof(Char))
			space = "";
		else
		{
			Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
			return null;
		}

		Node current = _head;
		String text = "";

		for (int i = 0; i < _count; i++)
		{
			if (i < _count - 1)
			{
				text = $"{text}{current.Value}{space}";
			}
			else
				text = $"{text}{current.Value}";

			current = current.Next;
		}

		return text;
	}
}
