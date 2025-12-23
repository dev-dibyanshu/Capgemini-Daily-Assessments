using System;

// Extension: Method Overloading Demonstration
public class MethodOverloadingDemo
{
    public static void DemonstrateMethodOverloading()
    {
        Console.WriteLine("=== Extension: Method Overloading Demonstration ===");
        
        Calculator overloadCalc = new Calculator();
        
        // Different versions of Add method
        int result1 = overloadCalc.Add(10, 20);                    // int, int
        double result2 = overloadCalc.Add(10.5, 20.3);             // double, double
        int result3 = overloadCalc.Add(5, 10, 15);                 // int, int, int
        
        Console.WriteLine($"Method overloading allows same method name with different parameters");
        Console.WriteLine($"Results: {result1}, {result2}, {result3}");
        
        Console.WriteLine();
    }
}