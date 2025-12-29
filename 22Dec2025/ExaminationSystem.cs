using System;

public class ExaminationSystem
{
    public static void DemonstrateExaminationSystem()
    {
        
        Calculator examCalc = new Calculator();
        
        int mathMarks = 85;
        int scienceMarks = 92;
        
        examCalc.Addition(mathMarks, scienceMarks, out int totalMarks, out int returnedMath, out int returnedScience);
        
        Console.WriteLine($"Input: Math = {mathMarks}, Science = {scienceMarks}");
        Console.WriteLine($"Output: Total = {totalMarks}, Returned Math = {returnedMath}, Returned Science = {returnedScience}");
        
        Console.WriteLine();
    }
}