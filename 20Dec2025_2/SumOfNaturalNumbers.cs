using System;

class SumOfNaturalNumbers
{
    public static void Run()
    {
        Console.Write("Enter a positive integer N: ");
        int n = int.Parse(Console.ReadLine());
        
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        
        Console.WriteLine($"Sum of the first {n} natural numbers: {sum}");
    }
}