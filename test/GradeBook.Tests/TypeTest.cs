using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
          // Arange
          var book1 = GetBook("Book 1");
          var book2 = GetBook("Book 2");
    
          // Act
        
          // Asert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);


        }

         [Fact]
        public void TwoVarsCanRefferenceSameObj()
        {
          // Arange
          var book1 = GetBook("Book 1");
          var book2 = book1;
          // Act
        
          // Asert
            Assert.Same(book1, book2);

        }

        [Fact]
        public void INTTEST()
        {
        var x = GetInt();
        SetInt(x);
        
        Assert.Equal(3,x);


        }

        private void SetInt(int z)
        {
        z = 42;
        }

        private int GetInt()
        {
          return 3;
        
        }

        [Fact]
        public void Test1()
        {
          // Arange
          var book1 = GetBook("Book 1");
    
          // Act
          GetBookSetName(book1, "New Name");
        
          // Asert
          Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);

        }



         [Fact]
        public void SetNewName()
        {
          // Arange
          var book1 = GetBook("Book 1");
    
          // Act
        SetName(book1, "New Name");
        
          // Asert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

    }
}
