using System;

namespace CoreDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = new LinkedList<Person>();
            list.Add(new Person {Id = 1, Name = "NAme"});
            list.Add(new Person {Id = 2, Name = "Another"});
            var p = list.Where(x => x.Id == 1);
            Console.WriteLine(p.Name);
            var pTwo = list.Where(x => x.Id == 2);
            Console.Write(pTwo.Name);
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; }

        public T Data { get; set; }
    }

    public class LinkedList<T>
    {
        Node<T> _head;

        public void Add(T o){
            var node = new Node<T>
            {
                Data = o,
                Next = _head
            };

            if (_head == null){
                _head = node;
                return;
            }
                

            var current = _head;
            do
            {
                if (current.Next != null)
                    current = current.Next;
                
            } while (current.Next != null);

            current.Next = node;
        }

        public T GetLast(){
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
            } while (current.Next != null);

            return (T)new object();
        }
    }

    public class Person 
    {
        public int Id
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }
    }
}
