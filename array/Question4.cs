using System;

public class Question4
{
    public static void Run()
    {
        Console.Write("Input the number of elements to be stored in the array :");
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        Console.WriteLine($"Input {n} elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            arr2[i] = arr1[i];
        }
        Console.Write("The elements stored in the first array are :");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        Console.WriteLine();
        Console.Write("The elements copied into the second array are :");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr2[i] + " ");
        }
        Console.WriteLine();
    }
}