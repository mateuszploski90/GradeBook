using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalcAverageGrade()
        {
          // Arange
          var book = new Book("");
          book.AddGrade(55.32);
          book.AddGrade(69.23);
          book.AddGrade(7373.32);


          // Act
          var result = book.GetStats();

          // Asert
            Assert.Equal(2499.29, result.Average, 1);
            Assert.Equal(7373.3, result.High, 1);
            Assert.Equal(55.32, result.Low, 1);


        }
    }
}
