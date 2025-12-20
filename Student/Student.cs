using System;

class Student
{
private int StudentId=0;
private string StudentName=string.Empty;
private int HindiMarks=0;
private int EnglishMarks=0;
private int MathMarks=0;
private int ScienceMarks=0;
private int SocialStudiesMarks=0;

public int studentId
{
    get
    {
        return StudentId;
    }
    set
    {
        StudentId=value;
    }
}

public string studentName
{
    get
    {
        return StudentName;
    }
    set
    {
        StudentName=value;
    }
}

public int hindiMarks
{
    get
    {
        return HindiMarks;
    }
    set
    {
        HindiMarks=value;
    }
}

public int englishMarks
{
    get
    {
        return EnglishMarks;
    }
    set
    {
        EnglishMarks=value;
    }
}   

public int mathMarks
{
    get
    {
        return MathMarks;
    }
    set
    {
        MathMarks=value;
    }
}

public int scienceMarks
{
    get
    {
        return scienceMarks;
    }
    set
    {
        ScienceMarks=value;
    }
}

public int socialStudiesMarks
{
    get
    {
        return SocialStudiesMarks;
    }
    set
    {
        SocialStudiesMarks=value;
    }
}

public void AcceptDetails()
{
    Console.WriteLine("====Enter Student Details====");
    Console.WriteLine("Enter Student Id:");
    StudentId=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Student Name:");
    StudentName=Console.ReadLine();
    Console.WriteLine("Enter Hindi Marks:");
    HindiMarks=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter English Marks:");
    EnglishMarks=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Math Marks:");
    MathMarks=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Science Marks:");
    ScienceMarks=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Social Studies Marks:");
    SocialStudiesMarks=Convert.ToInt32(Console.ReadLine());
    
}

public void DisplayDetails()
    {
        Console.WriteLine("====Student Details====");
        Console.WriteLine("Student Id: " + StudentId);
        Console.WriteLine("Student Name: " + StudentName);
        Console.WriteLine("Hindi Marks: " + HindiMarks);
        Console.WriteLine("English Marks: " + EnglishMarks);
        Console.WriteLine("Math Marks: " + MathMarks);
        Console.WriteLine("Science Marks: " + ScienceMarks);
        Console.WriteLine("Social Studies Marks: " + SocialStudiesMarks);

        Console.WriteLine("Total Marks: " + (HindiMarks + EnglishMarks + MathMarks + ScienceMarks + SocialStudiesMarks) + "/500");
        Console.WriteLine("Average Marks: " + (HindiMarks + EnglishMarks + MathMarks + ScienceMarks + SocialStudiesMarks) / 5.0);
    }
}