using System;
class Program
{
  public static void Main(string[] args)
  {
    int[] arr;

    Console.Write("Enter number of elements: ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
    {
      Console.Write("Invalid input. Enter a positive integer: ");
    }

    arr = new int[n];

    for (int i = 0; i < n; i++)
    {
      Console.Write($"Enter element {i}: ");
      while (!int.TryParse(Console.ReadLine(), out arr[i]))
      {
        Console.Write("Invalid integer. Enter again: ");
      }
    }

    Console.WriteLine("Array elements:");
    for (int i = 0; i < arr.Length; i++)
    {
      Console.WriteLine($"arr[{i}] = {arr[i]}");
    }


    Console.Write("Enter number of characters: ");
    int m;
    while (!int.TryParse(Console.ReadLine(), out m) || m < 1)
    {
      Console.Write("Invalid input. Enter a positive integer: ");
    }

    char[] carr = new char[m];
    for (int i = 0; i < m; i++)
    {
      Console.Write($"Enter character {i}: ");
      string s = Console.ReadLine();
      while (string.IsNullOrEmpty(s) || s.Length != 1)
      {
        Console.Write("Invalid input. Enter a single character: ");
        s = Console.ReadLine();
      }
      carr[i] = s[0];
    }

    Console.WriteLine("Character array elements:");
    for (int i = 0; i < carr.Length; i++)
    {
      Console.WriteLine($"carr[{i}] = {carr[i]}");
    }

    int total = Sum(arr);
    Console.WriteLine($"Sum of integer array elements: {total}");
  }

  public static int Sum(int[] a)
  {
    int s = 0;
    foreach (int v in a)
      s += v;
    return s;
  }
}