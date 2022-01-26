using System;

class GradeBookMain
{
    static void Main(string[] args)
    {
        var numbers = new[] {12.7, 10.3, 6.11};

        var result = 0.0;

        foreach(double number in numbers)
        {
            result += number;
        }

        // Display the number of command line arguments.
        if(args.Length > 0)
        {
        Console.WriteLine($"Hello, {args[1]}!");
        }
        else
        {
            Console.WriteLine("Hello, World!");
        }
        
        System.Console.WriteLine(result);
    }
}