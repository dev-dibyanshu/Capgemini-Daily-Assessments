using System.Runtime.CompilerServices;

namespace Calculator
{
    public delegate int Calculator(int num1, int num2){
        Calculator calculator = new Calculator();

        CalculatorDelegate calcutAdd = new CalculatorDelegate(Calculator.Add());
        CalculatorDelegate calcutSub = new CalculatorDelegate(Calculator.Subtract());
        CalculatorDelegate calcutMul = new CalculatorDelegate(Calculator.Mul());
        CalculatorDelegate calcutDivide = new CalculatorDelegate(Calculator.Divide());
        CalculatorDelegate calculatorMultiCast;
    }
}

// class Program
// {
//     public static void Main(String[] args)
//     {
//         double distance = 50.00;
//         double hour = 5.0;
//         double fuel = 10.0;

//         Vecical vehical = new Vehical(distance, hour, fuel);
//         vehical.Average();
//         vehical.Speed();

//         Car car = new Car(distance, hour, fuel);
//         car.Average();
//         car.Speed();
//     }
//     public void Add(params int[]){

//         int sum = 0;
//         for (int i=0; i<arr.size();i++){
            
//         }
//     }
// }