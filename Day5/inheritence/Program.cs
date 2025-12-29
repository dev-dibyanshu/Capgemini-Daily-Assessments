using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
class Program
{
  public static void Main(string[] args)
  {
    //object initializer
    Employee employee = new Employee
    {
      EmployeeId = 101,
      Name = "Rajesh",
      Salary = 750000
    };

    // Console.WriteLine($" employee id is {employee.EmployeeId}");
    // Console.WriteLine($" employee name is {employee.Name}");
    // Console.WriteLine($" employee salary is {employee.Salary}");

    // System.Console.WriteLine($"{employee}");


    // Program program=new Program();
    // int[] arr={10,20,30,40,50,60,70,80,90};
    // program.Add(arr);

    // Calculator calculator = new Calculator();
    // calculator.Add(10, 20);

    // double distance=50.00;
    // double hour=5.0;
    // double fuel=10.0;
    // Vehical vehical=new Vehical(distance,hour,fuel);
    // vehical.Average();
    // vehical.Speed();    

    // Car car=new Car(distance,hour,fuel);
    // car.Average();
    // car.Speed();

    Furniture furniture;//can create a reference vairable
    Bookshelf obj=new Bookshelf();
    obj.Accept();
    obj.Display();
    furniture=new Chair();
    Chair  chair=new Chair();
    chair.Accept();
    chair.Display();

  }

  public void Add(params int[] arr)
  {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      sum += arr[i];
    }
    Console.WriteLine($"sum is {sum}");
  }

}
