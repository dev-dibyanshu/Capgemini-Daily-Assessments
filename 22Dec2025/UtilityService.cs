using System;

public class UtilityService
{
    public static void DemonstrateUtilityService()
    {
        
        Calculator utilityCalc = new Calculator();
        
        Console.WriteLine($"Initial values: Number1 = {utilityCalc.Number1}, Number2 = {utilityCalc.Number2}");
        
        utilityCalc.Number1 = 25;
        utilityCalc.Number2 = 15;
        Console.WriteLine($"Modified values: Number1 = {utilityCalc.Number1}, Number2 = {utilityCalc.Number2}");
        
        utilityCalc.Subtract();
        Console.WriteLine($"Result stored in property: {utilityCalc.Result}");
        
        Console.WriteLine("Properties provide controlled access to private data");
        
        Console.WriteLine();
    }
}