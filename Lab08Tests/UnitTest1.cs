using Lab08_Collections.Classes;
using System;
using Xunit;

namespace Lab08Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Book_is_added_to_library()
        {
            // arrange
            Library library = new Library();
            library.Add("Bible", "John", "Bibleman", 1500);

            // act
            // test to see if library has book by name 
            int result = library.Count;

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Backpack_starts_empty()
        {
            // arrange 
            // act
            Backpack<string> bag = new Backpack<string>();

            // assert
            Assert.Empty(bag);
        }

        [Fact]
        public void Backpack_can_pack()
        {
            // arrange 
            
            Backpack<string> bag = new Backpack<string>();
            string item = "Water Bottle";
            // act
            bag.Pack(item);

            // assert
            Assert.Equal(new[] { item }, bag);
        }
    }
}
