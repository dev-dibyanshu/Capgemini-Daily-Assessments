using System;

class Patterns
{
    public static void Pattern1()
    {   
        Console.WriteLine("Write a number between 1-n : ");
        int n = (Convert.ToInt32(Console.ReadLine()));

        System.Console.WriteLine();
        
        for(int i = 1; i <= n; i++)
        {   
            for(int j = 1; j <= n-i; j++)
            {
                System.Console.Write(" ");
            }
            for(int j = 1; j <= i; j++)
            {   
                System.Console.Write(j + " ");
            }
            System.Console.WriteLine();
        }
    }
}