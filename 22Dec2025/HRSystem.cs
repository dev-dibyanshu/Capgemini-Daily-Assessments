using System;

public class HRSystem
{
    public static void DemonstrateHRSystem()
    {
        
        Calculator hrCalc = new Calculator();
        
        int employeeId1 = 101;
        int employeeId2 = 102;
        
        Console.WriteLine($"Original Employee IDs: ID1 = {employeeId1}, ID2 = {employeeId2}");
        
        hrCalc.Swap1(ref employeeId1, ref employeeId2);
        
        Console.WriteLine($"After method call (outside): ID1 = {employeeId1}, ID2 = {employeeId2}");
        
        Console.WriteLine();
    }
}