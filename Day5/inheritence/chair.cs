using System;
class Chair : Furniture
{
  public override void Accept()
  {
    Console.WriteLine("Enter number of chairs:");
    num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter color:");
    color = Console.ReadLine();

    Console.WriteLine("Enter width:");
    width = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter height:");
    height = Convert.ToInt32(Console.ReadLine());
  }
  public override void Display()
  {
    Console.WriteLine($"Number of chairs: {num}");
    Console.WriteLine($"Color: {color}");
    Console.WriteLine($"Width: {width}");
    Console.WriteLine($"Height: {height}");
  }

}