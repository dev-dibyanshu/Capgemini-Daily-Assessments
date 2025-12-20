using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== C# Programming Exercises ===\n");
        
        Console.WriteLine("1. Leap Year Checker:");
        LeapYear.Run();
        Console.WriteLine();
        
        Console.WriteLine("2. Temperature Converter:");
        TemperatureConverter.Run();
        Console.WriteLine();
        
        Console.WriteLine("3. Grade Calculator:");
        GradeCalculator.Run();
        Console.WriteLine();
        
        Console.WriteLine("4. Sum of Natural Numbers:");
        SumOfNaturalNumbers.Run();
        Console.WriteLine();
        
        Console.WriteLine("5. Factorial Calculator:");
        FactorialCalculator.Run();
        Console.WriteLine();
        
        Console.WriteLine("6. First N Even Numbers:");
        FirstNEvenNumbers.Run();
        Console.WriteLine();
        
        Console.WriteLine("All exercises completed!");
        Console.ReadKey();
    }
}
