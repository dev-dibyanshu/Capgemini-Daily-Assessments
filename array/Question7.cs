using System;

public class Question7
{
    public static void Run()
    {
        Console.Write("Input the number of elements to be stored in the first array :");
        int n1 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n1];
        Console.WriteLine($"Input {n1} elements in the array :");
        for (int i = 0; i < n1; i++)
        {
            Console.Write($"element - {i} : ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Input the number of elements to be stored in the second array :");
        int n2 = int.Parse(Console.ReadLine());
        int[] arr2 = new int[n2];
        Console.WriteLine($"Input {n2} elements in the array:");
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"element - {i} : ");
            arr2[i] = int.Parse(Console.ReadLine());
        }
        int[] merged = new int[n1 + n2];
        for (int i = 0; i < n1; i++)
        {
            merged[i] = arr1[i];
        }
        for (int i = 0; i < n2; i++)
        {
            merged[n1 + i] = arr2[i];
        }
        Array.Sort(merged);
        Console.Write("The merged array in ascending order is :");
        for (int i = 0; i < merged.Length; i++)
        {
            Console.Write(merged[i] + " ");
        }
        Console.WriteLine();
    }
}