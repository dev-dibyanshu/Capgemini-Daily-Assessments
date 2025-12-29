using System;

public class Question5
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
        int duplicateCount = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    duplicateCount++;
                    break;
                }
            }
        }
        Console.WriteLine($"Total number of duplicate elements found in the array is : {duplicateCount}");
    }
}