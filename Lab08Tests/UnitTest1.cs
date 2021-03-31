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

            // assert
            Assert.Throws<NotImplementedException> (() =>
            {


            })
            // act
            // test to see if library has book by name 


            // assert

        }
    }
}
