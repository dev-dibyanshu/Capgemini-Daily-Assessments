using System;
class Calculator
{
  //method overloading
  public int Add(int n)
  {
    int num1=30;
    int num2=50;
    return num1+num2;
    
  }
  public int Add(int n1,int n2)
  {
    int num1=n1;
    int num2=n2;
    return num1+num2;
    
  }
  public int Add(string str1,string str2)
  {
    string str3=str1+str2;
    Console.WriteLine($"Concatenated string is {str3}");
    return 0;
    
  }

  public int Add(string str1,float flt1,int num)
  {
    Console.WriteLine($"string is {str1}\n float is {flt1} integer is {num}");
    return 0;
    
  }


}