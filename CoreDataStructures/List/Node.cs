using System;
namespace CoreDataStructures.List
{
	public class Node<T>
	{
		public Node<T> Next { get; set; }

		public T Data { get; set; }
	}
}
