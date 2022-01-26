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

            book.showStatistics();
            
        }
    }
}