using System.Collections.Generic;
using System;
namespace GradeBook
{
    class Book
    {
        
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStats()
        {

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            Console.WriteLine("Średnia liczb: ");
            foreach (var number in grades)
            {
                lowGrade = Math.Min (number, lowGrade);

             
                if (number > highGrade)
                {
                    highGrade = number;
                }
                result += number;
                Console.Write($"{number}, ");
            }

            result /= grades.Count;
            Console.WriteLine($"Wynosi {result:N1}");
            Console.WriteLine($"Najniższa liczba to: {lowGrade:N1}");
            Console.WriteLine($"Najwyższa liczba to: {highGrade:N1}");
        }
        private List<double> grades;
        private string name;

    }
}