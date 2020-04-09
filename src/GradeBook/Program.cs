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
            
            var stats = book.GetStats();
            
            Console.WriteLine($"Wynosi {stats.Average:N1}");
            Console.WriteLine($"Najniższa liczba to: {stats.Low:N1}");
            Console.WriteLine($"Najwyższa liczba to: {stats.High:N1}");

        }
    }
}
