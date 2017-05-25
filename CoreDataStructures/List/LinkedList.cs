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

		public T GetFirst()
		{
			return _head.Data;
		}

        public T GetLast(){
            var current = _head;

            while(current.Next != null){
                current = current.Next;
            }

            return current.Data;
        }

		public T FirstOrDefault(Func<T, bool> f)
		{
			var current = _head;

			do
			{
				if (f(current.Data))
					return current.Data;

				current = current.Next;
			} while (current != null);

			return default(T);
		}

		public void PrintAll()
		{
			var current = _head;
			do
			{
				current = current.Next;
			} while (current != null);
		}

		public void ForEach(Func<T, T> p)
		{
			throw new NotImplementedException();
		}
	}

}
