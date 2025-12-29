using System;

class Employee
{
  public int EmployeeId { get; set; }
  public string Name { get; set; }
  public float Salary { get; set; }

  public Employee()
  {
    EmployeeId = 0;
    Name = string.Empty;
    Salary = 0.0f;
  }

  public Employee(int empId, string name, float salary)
  {
    EmployeeId = empId;
    Name = name;
    Salary = salary;
  }

  public override string ToString()
  {
    return $"Employee Details are:\n" +
           $"Employee id is {EmployeeId}\n" +
           $"Employee name is {Name}\n" +
           $"Employee salary is {Salary}";
  }
}