using System;

public class Calculator
{
    // Auto-implemented properties (Case Study 6)
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public int Result { get; set; }

    // Default Constructor (Case Study 2)
    public Calculator()
    {
        Number1 = 10;
        Number2 = 5;
        Console.WriteLine("Default Constructor: Calculator initialized with default values (10, 5)");
    }

    // Parameterized Constructor (Case Study 2)
    public Calculator(int number1, int number2)
    {
        this.Number1 = number1;
        this.Number2 = number2;
        Console.WriteLine($"Parameterized Constructor: Calculator initialized with values ({number1}, {number2})");
    }

    // Case Study 1: Addition with parameters and return type
    public int Add(int number1, int number2)
    {
        int result = number1 + number2;
        Console.WriteLine($"Addition: {number1} + {number2} = {result}");
        return result;
    }

    // Case Study 1: Subtraction without user input (using class properties)
    public void Subtract()
    {
        Result = Number1 - Number2;
        Console.WriteLine($"Subtraction: {Number1} - {Number2} = {Result}");
    }

    // Case Study 1: Multiplication with input parameters
    public int Multiply(int number1, int number2)
    {
        int result = number1 * number2;
        Console.WriteLine($"Multiplication: {number1} * {number2} = {result}");
        return result;
    }

    // Case Study 1: Division using predefined values
    public void Divide()
    {
        if (Number2 != 0)
        {
            Result = Number1 / Number2;
            Console.WriteLine($"Division: {Number1} / {Number2} = {Result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero!");
        }
    }

    // Case Study 3: Call by Value - Swap method (values don't change outside)
    public void Swap(int num1, int num2)
    {
        Console.WriteLine($"Before Swap (Call by Value): num1 = {num1}, num2 = {num2}");
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine($"After Swap (Inside method): num1 = {num1}, num2 = {num2}");
    }

    // Case Study 4: Call by Reference - Swap method (values change outside)
    public void Swap1(ref int num3, ref int num4)
    {
        Console.WriteLine($"Before Swap (Call by Reference): num3 = {num3}, num4 = {num4}");
        int temp = num3;
        num3 = num4;
        num4 = temp;
        Console.WriteLine($"After Swap (Inside method): num3 = {num3}, num4 = {num4}");
    }

    // Case Study 5: Output parameters - Multiple return values
    public void Addition(int n1, int n2, out int result, out int n3, out int n4)
    {
        result = n1 + n2;  // Total marks
        n3 = n1;           // Return first subject mark
        n4 = n2;           // Return second subject mark
        Console.WriteLine($"Addition with out parameters: {n1} + {n2} = {result}");
        Console.WriteLine($"Individual marks returned: Subject1 = {n3}, Subject2 = {n4}");
    }

    // Method overloading for Add (Extension)
    public double Add(double number1, double number2)
    {
        double result = number1 + number2;
        Console.WriteLine($"Addition (double): {number1} + {number2} = {result}");
        return result;
    }

    // Method overloading for Add with three parameters
    public int Add(int number1, int number2, int number3)
    {
        int result = number1 + number2 + number3;
        Console.WriteLine($"Addition (3 numbers): {number1} + {number2} + {number3} = {result}");
        return result;
    }
}