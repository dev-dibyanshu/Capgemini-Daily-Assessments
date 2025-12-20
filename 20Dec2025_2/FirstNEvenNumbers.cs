using System;

class FirstNEvenNumbers
{
    public static void Run()
    {
        Console.Write("Enter a positive integer N: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"First {n} even numbers:");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i * 2);
        }
    }
}