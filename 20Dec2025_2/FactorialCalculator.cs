using System;

class FactorialCalculator
{
    public static void Run()
    {
        while (true)
        {
            Console.Write("Enter a non-negative integer (or 'q' to quit): ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "q")
            {
                break;
            }
            
            if (int.TryParse(input, out int number))
            {
                if (number < 0)
                {
                    Console.WriteLine("Invalid input! Please enter a non-negative integer.");
                }
                else
                {
                    long factorial = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"The factorial of {number} is {factorial}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a non-negative integer.");
            }
        }
    }
}