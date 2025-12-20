using System;

class TemperatureConverter
{
    public static void Run()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        
        double fahrenheit = (celsius * 9 / 5) + 32;
        
        Console.WriteLine($"Temperature in Celsius: {celsius}");
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
    }
}