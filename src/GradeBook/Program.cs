using System;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("Erin Kyle");
            book.AddGrade(89.1);
            book.AddGrade(30.2);
            book.AddGrade(65.5);

            var stats = book.getStatistics();

            
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");
            
        }
    }
}