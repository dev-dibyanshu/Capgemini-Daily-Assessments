using System;

public class Question6
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
        Console.Write("The unique elements found in the array are :");
        for (int i = 0; i < n; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < n; j++)
            {
                if (i != j && arr[i] == arr[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                Console.Write(arr[i] + " ");
            }
        }
        Console.WriteLine();
    }
}