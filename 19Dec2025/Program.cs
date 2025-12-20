// See https://aka.ms/new-console-template for more information

// using System;

// class Program
// {
//     static void Main(String[] args)
//     {
//         // Patterns.Pattern1();
//         // Armstrong.CheckArmstrong();

//         Employee.Employee13();
//     }
// }


using System;
class Program
{
public static void Main(string[] args)
{
//creating rhe wobjectof Employee class
Employee employee = new Employee();

//employee.DisplayDetails();//binding the employee object to DisplayDetails method

//Employee employee1=new Employee();
// employee.EmpId=101;
// employee.name="Pankaj";
// employee.department="IT";
// employee.salary=45000f;
// employee.status=true;


employee.AcceptDetails();
employee.DisplayDetails();

Console.ReadKey();

}
}