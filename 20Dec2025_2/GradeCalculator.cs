using System;

class GradeCalculator
{
    public static void Run()
    {
        Console.Write("Enter exam score: ");
        int score = int.Parse(Console.ReadLine());
        
        if (score >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else
        {
            if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                if (score >= 70)
                {
                    Console.WriteLine("Grade: C");
                }
                else
                {
                    if (score >= 60)
                    {
                        Console.WriteLine("Grade: D");
                    }
                    else
                    {
                        Console.WriteLine("Grade: F");
                    }
                }
            }
        }
    }
}