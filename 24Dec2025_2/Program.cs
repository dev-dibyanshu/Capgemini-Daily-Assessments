using System;

class Program
{
    static void Main(string[] args)
    {
        UnitConverter converter = new UnitConverter();

        Console.Write("Enter conversion type (length/weight/temperature): ");
        string type = Console.ReadLine();

        Console.Write("Enter value to convert: ");
        double value = double.Parse(Console.ReadLine());

        Console.Write("Enter from unit: ");
        string fromUnit = Console.ReadLine();

        Console.Write("Enter to unit (or press Enter for default): ");
        string toUnit = Console.ReadLine();

        double result;
        if (string.IsNullOrEmpty(toUnit))
        {
            result = converter.Convert(value, fromUnit);
            string defaultUnit = GetDefaultUnit(type);
            Console.WriteLine($"{value} {fromUnit} = {result} {defaultUnit}");
        }
        else
        {
            result = converter.Convert(value, fromUnit, toUnit);
            Console.WriteLine($"{value} {fromUnit} = {result} {toUnit}");
        }
    }

    private static string GetDefaultUnit(string type)
    {
        switch (type.ToLower())
        {
            case "length":
                return "meters";
            case "weight":
                return "kilograms";
            case "temperature":
                return "celsius";
            default:
                return "";
        }
    }
}