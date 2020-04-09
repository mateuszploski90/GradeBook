using System.Collections.Generic;
using System;
namespace GradeBook
{
    public class Book
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

        public Stats GetStats()
        {

            var result = new Stats();
            result.Average = 0.0;

            result.High = double.MinValue;
            result.Low = double.MaxValue;

            Console.WriteLine("Średnia liczb: ");
            foreach (var grade in grades)
            {
                result.Low = Math.Min (grade, result.Low);
                result.High = Math.Max (grade, result.High);
                result.Average += grade;
                Console.Write($"{grade}, ");
            }

            result.Average /= grades.Count;
            return result;
        }
        private List<double> grades;
        private string name;

    }
}