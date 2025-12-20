using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("17. Print numbers from 1 to n using while loop:");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        while (i <= n)
        {
            Console.Write(i + " ");
            i++;
        }

        Console.WriteLine("18. Print even numbers from 1 to n:");
        Console.Write("Enter n: ");
        int n2 = int.Parse(Console.ReadLine());
        int j = 2;
        while (j <= n2)
        {
            Console.Write(j + " ");
            j += 2;
        }

        Console.WriteLine("19. Sum of numbers from 1 to n using while loop:");
        Console.Write("Enter n: ");
        int n3 = int.Parse(Console.ReadLine());
        int sum = 0;
        int k = 1;
        while (k <= n3)
        {
            sum += k;
            k++;
        }
        Console.WriteLine($"Sum: {sum}");

        Console.WriteLine("20. Multiplication table:");
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        for (int l = 1; l <= 10; l++)
        {
            Console.WriteLine($"{num} x {l} = {num * l}");
        }
        Console.WriteLine("21. Power calculation:");
        Console.Write("Enter base: ");
        int baseNum = int.Parse(Console.ReadLine());
        Console.Write("Enter exponent: ");
        int exp = int.Parse(Console.ReadLine());
        int result = 1;
        for (int m = 1; m <= exp; m++)
        {
            result *= baseNum;
        }
        Console.WriteLine($"{baseNum}^{exp} = {result}");

        Console.WriteLine("22. Fibonacci series:");
        Console.Write("Enter n: ");
        int n4 = int.Parse(Console.ReadLine());
        int first = 0, second = 1;
        Console.Write(first + " " + second + " ");
        for (int p = 2; p < n4; p++)
        {
            int next = first + second;
            Console.Write(next + " ");
            first = second;
            second = next;
        }



        Console.WriteLine("23. Armstrong number check:");
        Console.Write("Enter number: ");
        int armNum = int.Parse(Console.ReadLine());
        int originalNum = armNum;
        int armSum = 0;
        int digits = armNum.ToString().Length;
        while (armNum > 0)
        {
            int digit = armNum % 10;
            armSum += (int)Math.Pow(digit, digits);
            armNum /= 10;
        }
        if (armSum == originalNum)
            Console.WriteLine($"{originalNum} is an Armstrong number");
        else
            Console.WriteLine($"{originalNum} is not an Armstrong number");






        Console.WriteLine("24. Armstrong numbers from n1 to n2:");
        Console.Write("Enter n1: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter n2: ");
        int n2_range = int.Parse(Console.ReadLine());
        Console.Write("Armstrong numbers: ");
        for (int q = n1; q <= n2_range; q++)
        {
            int tempNum = q;
            int tempSum = 0;
            int tempDigits = q.ToString().Length;
            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                tempSum += (int)Math.Pow(digit, tempDigits);
                tempNum /= 10;
            }
            if (tempSum == q)
                Console.Write(q + " ");
        }

        Console.WriteLine("25. Prime number check:");
        Console.Write("Enter number: ");
        int primeNum = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (primeNum <= 1)
            isPrime = false;
        else
        {
            for (int r = 2; r <= Math.Sqrt(primeNum); r++)
            {
                if (primeNum % r == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if (isPrime)
            Console.WriteLine($"{primeNum} is a prime number");
        else
            Console.WriteLine($"{primeNum} is not a prime number");

    }
}