// using System;
// class Employee
// {
//     public static void Employee13()
//     {
        
//         Console.Write("Enter Employee Number:");
//         int eno = int.Parse(Console.ReadLine());
        
//         Console.Write("Enter Employee Name:");
//         string ename =Console.ReadLine();
        
//         Console.Write("Enter Basic Salary: ");
//         double basicSalary= double.Parse(Console.ReadLine());
        
//         double pf = 0.12 * basicSalary;      
//         double hra = 0.20 * basicSalary;     
//         double da = 0.15 * basicSalary;      
//         double grossSalary = pf + hra + basicSalary;
//         double netSalary = grossSalary - pf;
//         System.Console.WriteLine();
//         System.Console.WriteLine();
//         System.Console.WriteLine();
//         Console.WriteLine("Employee Salary Details:");
//         Console.WriteLine($"Employee Number: {eno}");
//         Console.WriteLine($"Employee Name: {ename}");
//         Console.WriteLine($"Basic Salary: ₹{basicSalary}");
//         Console.WriteLine($"Gross Salary: ₹{grossSalary}");
//         Console.WriteLine($"Net Salary: ₹{netSalary}");
//     }
// }


using System;

internal class Employee
{
    private int _empId=0;
    private string _name=string.Empty;

    string _department=string.Empty;

    private float _salary=0.0f;

    private bool _status=true;

    public int EmpId
    {
        get
        {
            return _empId;
        }
        set
        {
            _empId = value;
        }
    }
    public string name
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
    public string department
    {
        get
        {
            return _department;
        }
        set
        {
            _department = value;
        }
    }
    public float salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
    public bool status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }

    public void AcceptDetails()
    {
        Console.WriteLine("Enter Employee Details:   ");
        Console.WriteLine("Enter Employee ID:");
        EmpId=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name:");
        name=Console.ReadLine();
        Console.WriteLine("Enter Employee Department:");
        department=Console.ReadLine();
        Console.WriteLine("Enter Employee Salary:");
        salary=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Employee Status (true/false):");
        status=Convert.ToBoolean(Console.ReadLine());
    }

    
        
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details");
        Console.WriteLine("Employee ID: " + _empId);
        Console.WriteLine("Employee Name: " + _name);
        Console.WriteLine("Employee Department: " + _department);
        Console.WriteLine("Employee Salary: " + _salary);
        Console.WriteLine("Employee Status: " + _status);
    }

}