using System;

namespace CoreDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Node
    {
        public Node Next { get; set; }

        public Object Data { get; set; }
    }

    public class LinkedList
    {
        Node _head;

        public void AddFront(Object o){
            var node = new Node
            {
                Data = o,
                Next = _head
            };

            _head = node;
        }
    }
}
