using System;

public class UnitConverter
{
    public double Convert(double value, string fromUnit, string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        if (fromUnit == "meters" && toUnit == "kilometers")
            return value * 0.001;
        if (fromUnit == "kilometers" && toUnit == "meters")
            return value * 1000;
        if (fromUnit == "miles" && toUnit == "feet")
            return value * 5280;
        if (fromUnit == "feet" && toUnit == "miles")
            return value / 5280;

        if (fromUnit == "grams" && toUnit == "kilograms")
            return value * 0.001;
        if (fromUnit == "kilograms" && toUnit == "grams")
            return value * 1000;
        if (fromUnit == "pounds" && toUnit == "ounces")
            return value * 16;
        if (fromUnit == "ounces" && toUnit == "pounds")
            return value / 16;

        if (fromUnit == "celsius" && toUnit == "fahrenheit")
            return (value * 9 / 5) + 32;
        if (fromUnit == "fahrenheit" && toUnit == "celsius")
            return (value - 32) * 5 / 9;
        if (fromUnit == "celsius" && toUnit == "kelvin")
            return value + 273.15;
        if (fromUnit == "kelvin" && toUnit == "celsius")
            return value - 273.15;

        return value;
    }

    public double Convert(double value, string fromUnit)
    {
        string type = GetUnitType(fromUnit);
        string defaultUnit = GetDefaultUnit(type);
        return Convert(value, fromUnit, defaultUnit);
    }

    private string GetDefaultUnit(string type)
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

    private string GetUnitType(string unit)
    {
        unit = unit.ToLower();
        if (unit == "meters" || unit == "kilometers" || unit == "miles" || unit == "feet")
            return "length";
        if (unit == "grams" || unit == "kilograms" || unit == "pounds" || unit == "ounces")
            return "weight";
        if (unit == "celsius" || unit == "fahrenheit" || unit == "kelvin")
            return "temperature";
        return "";
    }
}