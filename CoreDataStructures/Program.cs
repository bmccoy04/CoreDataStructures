using System;
using CoreDataStructures.List;
using CoreDataStructures.Models;

namespace CoreDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListFun();

            Person[] myArray = new Person[3];
            myArray[0] = new Person() { Name = "Mario" };
            myArray[1] = new Person() { Name = "Samuel" };
            myArray[2] = new Person() { Name = "Link" };

            foreach (var item in myArray)
            {
                Console.WriteLine(item.Name);
            }

            var arrayService = new ArrayService();

            Person[] reversedArray = arrayService.ReverseArray(myArray);

            Console.WriteLine("Reversed Array: ");
			foreach (var item in reversedArray)
			{
				Console.WriteLine(item.Name);
			}
        }

        private static void ListFun()
        {
            Console.WriteLine("Hello World!");

            var list = new LinkedList<Person>();
            list.Add(new Person { Id = 1, Name = "NAme" });
            list.Add(new Person { Id = 2, Name = "Another" });
            var p = list.FirstOrDefault(x => x.Id == 1);
            Console.WriteLine(p.Name);
            var pTwo = list.FirstOrDefault(x => x.Id == 2);
            Console.WriteLine(pTwo.Name);

            var pThree = list.FirstOrDefault(x => x.Id == 3);
            Console.WriteLine(pThree);
            list.PrintAll();
        }
    }
}
