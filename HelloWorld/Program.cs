// See https://aka.ms/new-console-template for more information

Console.Write("2. Enter a number:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered: {number}");


Console.Write("3. Enter a floating point number:");
float floatNumber = float.Parse(Console.ReadLine());
Console.WriteLine($"You entered: {floatNumber}");

Console.Write("4. Enter a string: ");
string userString = Console.ReadLine();
Console.WriteLine($"You entered: {userString}");

Console.WriteLine("5. Arithmetic Operations:");
Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");
Console.WriteLine($"Division: {num1} / {num2} = {(double)num1 / num2}");
Console.WriteLine($"Modulus: {num1} % {num2} = {num1 % num2}");

Console.WriteLine("6. Area of Circle:");
Console.Write("Enter radius: ");
double radius = double.Parse(Console.ReadLine());
double area = Math.PI * radius * radius;
Console.WriteLine($"Area of circle: {area:F2}");

Console.WriteLine("7. Even or Odd:");
Console.Write("Enter a number: ");
int evenOddNum = int.Parse(Console.ReadLine());
if (evenOddNum % 2 == 0)
    Console.WriteLine($"{evenOddNum} is Even");
else
    Console.WriteLine($"{evenOddNum} is Odd");

Console.WriteLine("8. Greatest of 2 numbers:");
Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
    Console.WriteLine($"{a} is greater");
else if (b > a)
    Console.WriteLine($"{b} is greater");
else
    Console.WriteLine("Both numbers are equal");

Console.WriteLine("9. Positive, Negative or Zero:");
Console.Write("Enter a number: ");
int checkNum = int.Parse(Console.ReadLine());
if (checkNum > 0)
    Console.WriteLine($"{checkNum} is Positive");
else if (checkNum < 0)
    Console.WriteLine($"{checkNum} is Negative");
else
    Console.WriteLine($"{checkNum} is Zero");

Console.WriteLine("10. Greatest of 3 numbers using nested if:");
Console.Write("Enter first number: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int z = int.Parse(Console.ReadLine());
if (x > y)
{
    if (x > z)
        Console.WriteLine($"{x} is the greatest");
    else
        Console.WriteLine($"{z} is the greatest");
}
else
{
    if (y > z)
        Console.WriteLine($"{y} is the greatest");
    else
        Console.WriteLine($"{z} is the greatest");
}

Console.WriteLine("11. Greatest of 3 numbers using conditional operator:");
Console.Write("Enter first number: ");
int p = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int q = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int r = int.Parse(Console.ReadLine());
int greatest = (p > q) ? ((p > r) ? p : r) : ((q > r) ? q : r);
Console.WriteLine($"{greatest} is the greatest");




Console.Write("4. Enter a string: ");
string userString = Console.ReadLine();
int n = userString.Length;
int number = int.Parse(userString);
while(true)
Console.WriteLine($"You entered: {userString}");