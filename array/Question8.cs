using System;

public class Question8
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
        Console.WriteLine("Frequency of all elements of array :");
        bool[] visited = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }
                Console.WriteLine($"{arr[i]} occurs {count} times");
            }
        }
    }
}