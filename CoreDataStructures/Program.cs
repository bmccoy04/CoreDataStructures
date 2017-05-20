using System;
using CoreDataStructures.List;
using CoreDataStructures.Models;

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

        }
    }
}
