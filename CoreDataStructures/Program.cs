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
            Console.WriteLine(pTwo.Name);

            var pThree = list.Where(x => x.Id == 3);
            Console.WriteLine(pThree);
            list.PrintAll();

            list.ForEach(x => x);

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
                Next = null
            };

            if (_head == null){
                _head = node;
                return;
            }

            var current = _head;
            while(current.Next != null){
                current = current.Next;
            }

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
