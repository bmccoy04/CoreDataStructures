﻿using System;
namespace CoreDataStructures.List
{
    public class LinkedList<T>
	{
		Node<T> _head;

		public void Add(T o)
		{
			var node = new Node<T>
			{
				Data = o,
				Next = null
			};

			if (_head == null)
			{
				_head = node;
				return;
			}

			var current = _head;
			while (current.Next != null)
			{
				current = current.Next;
			}

			current.Next = node;
		}

		public T GetLast()
		{
			return _head.Data;
		}

		public T Where(Func<T, bool> f)
		{
			var current = _head;

			do
			{
				if (f(current.Data))
					return current.Data;

				current = current.Next;
			} while (current != null);

			Console.WriteLine("end");

			return default(T);
		}

		public void PrintAll()
		{
			var current = _head;
			do
			{
				Console.WriteLine(current.Data);
				current = current.Next;
			} while (current != null);
		}

		public void ForEach(Func<T, T> p)
		{
			throw new NotImplementedException();
		}
	}

}
