using System;
using System.Drawing;
using System.Globalization;
class Bookshelf: Furniture
{
  public override void Accept()
  {
    Console.WriteLine("enterno of shelvers");
    Num=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" enter color");
    Color=Convert.ToString(Console.ReadLine());
    Console.WriteLine("enter width");
    width=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter heighth");
    height=Convert.ToInt32(Console.ReadLine());
  }
  public override void Display()
  {
    Console.WriteLine("num of shelves is : {0}",num);
    Console.WriteLine("color is : {0}",color);
    Console.WriteLine("height is  : {0}",height);
    Console.WriteLine("width is : {0}",width);
  }
}
