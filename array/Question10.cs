using System;

public class Question10
{
    public static void Run()
    {
        Console.Write("Input the number of elements to be stored in the array :");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine($"Input {n} elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int[] even = new int[n];
        int[] odd = new int[n];
        int evenCount = 0, oddCount = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
            {
                even[evenCount] = arr[i];
                evenCount++;
            }
            else
            {
                odd[oddCount] = arr[i];
                oddCount++;
            }
        }
        Console.Write("The Even elements are:");
        for (int i = 0; i < evenCount; i++)
        {
            Console.Write(even[i] + " ");
        }
        Console.WriteLine();
        Console.Write("The Odd elements are :");
        for (int i = 0; i < oddCount; i++)
        {
            Console.Write(odd[i] + " ");
        }
        Console.WriteLine();
    }
}