using System;

public class PayrollSystem
{
    public static void DemonstratePayrollSystem()
    {
        
        Calculator payrollCalc = new Calculator();
        
        int baseSalary = 5000;
        int bonus = 1500;
        
        Console.WriteLine($"Original salary components: Base = ${baseSalary}, Bonus = ${bonus}");
        
        payrollCalc.Swap(baseSalary, bonus);
        
        Console.WriteLine($"After method call (outside): Base = ${baseSalary}, Bonus = ${bonus}");
        Console.WriteLine("Notice: Original values remain unchanged (Call by Value)");
        
        Console.WriteLine();
    }
}