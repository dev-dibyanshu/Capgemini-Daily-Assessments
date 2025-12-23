using System;

// Case Study 4: HR System - Call by Reference
public class HRSystem
{
    public static void DemonstrateHRSystem()
    {
        Console.WriteLine("=== Case Study 4: HR System - Call by Reference ===");
        
        Calculator hrCalc = new Calculator();
        
        int employeeId1 = 101;
        int employeeId2 = 102;
        
        Console.WriteLine($"Original Employee IDs: ID1 = {employeeId1}, ID2 = {employeeId2}");
        
        // Call by reference - original values will change
        hrCalc.Swap1(ref employeeId1, ref employeeId2);
        
        Console.WriteLine($"After method call (outside): ID1 = {employeeId1}, ID2 = {employeeId2}");
        Console.WriteLine("Notice: Original values have changed (Call by Reference)");
        
        Console.WriteLine();
    }
}