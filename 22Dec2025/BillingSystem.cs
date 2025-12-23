using System;


public class BillingSystem
{
    public static void DemonstrateBillingSystem()
    {
        Calculator defaultBilling = new Calculator();
        Console.WriteLine("Standard billing calculator created with default values");
        
        Calculator customBilling = new Calculator(100, 25);
        Console.WriteLine("Custom billing calculator created with specific values");
        
        defaultBilling.Add(defaultBilling.Number1, defaultBilling.Number2);
        customBilling.Multiply(customBilling.Number1, customBilling.Number2);
        
        Console.WriteLine();
    }
}