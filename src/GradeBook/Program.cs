using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Scot's Grade Book"); 
            book.AddGrade(89.3);
            book.AddGrade(69.69);
            book.AddGrade(48978.789);
            book.ShowStats();
        

        }
    }
}
