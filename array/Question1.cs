using System;

public class Question1
{
    public static void Run()
    {
        int[] arr = new int[10];
        Console.WriteLine("Input 10 elements in the array:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Elements in array are: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}