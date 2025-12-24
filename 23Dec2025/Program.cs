using System;

class Program
{
    static void Main(string[] args)
    {
        Student defaultStudent = new Student();
        
        Console.WriteLine("Default Student:");
        defaultStudent.DisplayInfo();
        
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter student age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Enter student grade: ");
        string grade = Console.ReadLine();
        
        Student newStudent = new Student(name, age, grade);
        
        Console.WriteLine("New Student:");
        newStudent.DisplayInfo();
    }
}