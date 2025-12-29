using System;

public class MethodOverloadingDemo
{
    public static void DemonstrateMethodOverloading()
    {
        
        Calculator overloadCalc = new Calculator();
        
        int result1 = overloadCalc.Add(10, 20);                    
        double result2 = overloadCalc.Add(10.5, 20.3);             
        int result3 = overloadCalc.Add(5, 10, 15);                 
        
        Console.WriteLine($"Method overloading allows same method name with different parameters");
        Console.WriteLine($"Results: {result1}, {result2}, {result3}");
        
        Console.WriteLine();
    }
}