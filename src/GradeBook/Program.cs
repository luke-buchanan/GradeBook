﻿using System;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Erin Kyle");

            book.GradeAdded += OnGradeAdded;
            
            while(true)
            {
                System.Console.WriteLine("Enter A Grade");
                System.Console.WriteLine("Type 'q' to Quit");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }


                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                    // ...
                }
                catch(ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    System.Console.WriteLine("**");
                }
               
            }

            var stats = book.getStatistics();

            System.Console.WriteLine($"For the book named {book.Name}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The letter grade is {stats.letter}");
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            System.Console.WriteLine("A grade was added");
        }

    }
} 