using System;

internal class Student
{
    private int _rollnumber = 0;
    private string _name = string.Empty;

    private int _subject1 =  0;
    private int _subject2 =  0;
    private int _subject3 =  0;
    private int _subject4 =  0;
    private int _subject5 =  0;
    private int _subject6 =  0;

    public int RollNumber
    {
        get
        {
            return _rollnumber;
        }
        set
        {
            _rollnumber = value;
        }
    }

    public int Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    
    
    public int Subject1
    {
        get
        {
            return _subject1;
        }
        set
        {
            _subject1 = value;
        }
    }

    public int Subject2
    {
        get
        {
            return _subject2;
        }
        set
        {
            _subject2 = value;
        }
    }

    public int Subject3
    {
        get
        {
            return _subject3;
        }
        set
        {
            _subject3 = value;
        }
    }

    public int Subject4
    {
        get
        {
            return _subject4;
        }
        set
        {
            _subject4 = value;
        }
    }

    public int Subject5
    {
        get
        {
            return _subject5;
        }
        set
        {
            _subject5 = value;
        }
    }

    public int Subject6
    {
        get
        {
            return _subject6;
        }
        set
        {
            _subject6 = value;
        }
    }


    public void AcceptDetails()
    {
        System.Console.WriteLine("===Enter Student Details===");
        
        System.Console.WriteLine("Roll number :");
        RollNumber = Convert.ToInt32(Console.ReadLine());
        
        System.Console.WriteLine("Name :");
        Name = Console.ReadLine();

        System.Console.WriteLine("==Enter Marks==");
        System.Console.WriteLine("Subject 1 :");
        Subject1 = Convert.ToInt32(Console.ReadLine());
        
        System.Console.WriteLine("Subject 2 :");
        Subject2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Subject 3 :");
        Subject3 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Subject 4 :");
        Subject4 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Subject 5 :");
        Subject5 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Subject 6 :");
        Subject6 = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayDetails()
    {
        Console.WriteLine("====Student Details====");
        Console.WriteLine("Student Roll Number: " + StudentId);
    
    }
}