using System;

// Case Study 5: Examination System - Output Parameters
public class ExaminationSystem
{
    public static void DemonstrateExaminationSystem()
    {
        Console.WriteLine("=== Case Study 5: Examination System - Output Parameters ===");
        
        Calculator examCalc = new Calculator();
        
        int mathMarks = 85;
        int scienceMarks = 92;
        
        // Using out parameters to get multiple values
        examCalc.Addition(mathMarks, scienceMarks, out int totalMarks, out int returnedMath, out int returnedScience);
        
        Console.WriteLine($"Input: Math = {mathMarks}, Science = {scienceMarks}");
        Console.WriteLine($"Output: Total = {totalMarks}, Returned Math = {returnedMath}, Returned Science = {returnedScience}");
        Console.WriteLine("Multiple values returned using 'out' parameters");
        
        Console.WriteLine();
    }
}