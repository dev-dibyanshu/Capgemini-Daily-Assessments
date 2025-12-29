using System;
class Car : Vehical
{
  public Car(double distance,double hour,double fuel) : base(distance, hour, fuel)//calling base class constructor in derive class
  {
    
  }
  public new void Average()
  {
     double average=0.0;
    average=disteance/fuel;

    Console.WriteLine("vehicle average is {0:0.00}",average);
  }
  public override void Speed()
  {
    double speed =0.0;
    speed=distance/hour;
    Console.WriteLine("Speed of the vehicle is {0:0.0}/kmp",speed);
  }
}