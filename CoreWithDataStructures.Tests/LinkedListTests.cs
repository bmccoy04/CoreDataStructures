using System;
using CoreDataStructures.List;
using CoreDataStructures.Models;
using Xunit;

namespace CoreWithDataStructures.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void Add()
        {
            var list = new LinkedList<Person>();
            var expected = new Person();
            list.Add(expected);
            var actual = list.GetLast();

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetLast()
        {
            var list = new LinkedList<Person>();
            var first = new Person() { Id = 1, Name = "First"};
            var expected = new Person() {Id = 2, Name = "Second"};
            list.Add(first);
			list.Add(expected);
			var actual = list.GetLast();

			Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void GetFirst()
        {
            var list = new LinkedList<Person>();
            var expected = new Person() { Id = 1, Name = "First"};
            var second = new Person() {Id = 2, Name = "Second"};
            list.Add(expected);
            list.Add(second);
            var actual = list.GetFirst();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Where_Find()
        {
            var list = new LinkedList<Person>();
            var expected = new Person() { Id = 1, Name = "First"};
            var second = new Person() {Id = 1, Name = "Second"};
            list.Add(expected);
            list.Add(second);
            var actual = list.FirstOrDefault(x => x.Id == 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Where_Default()
        {
			var list = new LinkedList<Person>();
			var first = new Person() { Id = 1, Name = "First" };
			var second = new Person() { Id = 1, Name = "Second" };
			list.Add(first);
			list.Add(second);
			var actual = list.FirstOrDefault(x => x.Id == 2);

			Assert.Null(actual);
        }
    }
}
