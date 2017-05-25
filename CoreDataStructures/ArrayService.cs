using System;
using CoreDataStructures.Models;

namespace CoreDataStructures
{
    internal class ArrayService
    {
        public ArrayService()
        {
        }

        public Person[] ReverseArray(Person[] myArray)
        {
            var count = myArray.Length;
            var newArray = new Person[count];

            for (int i = 0; i < myArray.Length; i++)
            {
                count = count - 1;
                newArray[i] = myArray[count];
            }

            return newArray;
        }
    }
}