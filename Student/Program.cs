using System;

class Program
{
public static void Main(string[] args)
{
//Student student = new Student();

    Student std=new Student();
    std.studentId=1;
    std.studentName="Pankaj";
    std.englishMarks=85;
    std.hindiMarks=90;
    std.mathMarks=95;
    std.scienceMarks=80;
    std.socialStudiesMarks=88;
    std.DisplayDetails();

    Console.ReadKey();//to hold the console window.

    // student.AcceptDetails();
    // student.DisplayDetails();
}
}