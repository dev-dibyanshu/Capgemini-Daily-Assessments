using System;
public class BankingSystem
{
    public static void DemonstrateBankingOperations()
    {
        
        Calculator bankCalculator = new Calculator(1000, 50);
        
        int newBalance = bankCalculator.Add(1000, 250);
        Console.WriteLine($"New account balance after deposit: ${newBalance}");
        
        int interest = bankCalculator.Multiply(1000, 5); 
        Console.WriteLine($"Interest earned: ${interest}");
        
        bankCalculator.Subtract();
        Console.WriteLine($"Balance after transaction fee: ${bankCalculator.Result}");
        
        bankCalculator.Divide();
        Console.WriteLine($"Monthly installment: ${bankCalculator.Result}");
        
        Console.WriteLine();
    }
}